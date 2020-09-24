using Inventor;
using InventorWrapper.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper
{
    public static class InventorApplication
    {
        public static Inventor.Application _inventor;

        public static Inventor.ApplicationEvents _events;

        public delegate void DocumentChangedHandler();

        public static event DocumentChangedHandler DocumentChanged;

        public static void Listen()
        {
            _events.OnActivateDocument += new ApplicationEventsSink_OnActivateDocumentEventHandler(NotifyDocumentChanged);
        }

        public static void StopListening()
        {
            _events.OnActivateDocument -= new ApplicationEventsSink_OnActivateDocumentEventHandler(NotifyDocumentChanged);
        }

        public static void NotifyDocumentChanged(_Document DocumentObject, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode)
        {
            HandlingCode = HandlingCodeEnum.kEventNotHandled;

            if (BeforeOrAfter != EventTimingEnum.kAfter)
            {
                return;
            }

            HandlingCode = HandlingCodeEnum.kEventHandled;

            DocumentChanged();
        }

        public static void AddinAttach(Inventor.Application inventor)
        {
            _inventor = inventor;
            _events = _inventor.ApplicationEvents;
        }

        public static void Attach()
        {
            try
            {
                _inventor = (Inventor.Application)Marshal.GetActiveObject("Inventor.Application");
                _events = _inventor.ApplicationEvents;
            }
            catch (Exception)
            {
                try
                {
                    Type invAppType = Type.GetTypeFromProgID("Inventor.Application");

                    _inventor = (Inventor.Application)System.Activator.CreateInstance(invAppType);
                    _events = _inventor.ApplicationEvents;
                    _inventor.Visible = true;
                }
                catch (Exception exception)
                {
                    throw new Exception("Unable to get or start inventor");
                }
            }
        }

        public static bool Attached
        {
            get
            {
                if (_inventor == null)
                {
                    return false;
                }
                else
                {
                    try
                    {
                        var doc = _inventor.Documents.Count;

                        return true;
                    }
                    catch (Exception ex)
                    {
                        _inventor = null;
                        return false;
                    }
                }
            }
        }

        public static InventorDocument ActiveDocument
        {
            get
            {
                var doc = _inventor.ActiveDocument;

                if (doc == null)
                {
                    return null;
                }
                else
                {
                    return new InventorDocument(doc);
                }
            }
        }

        public static InventorDocument Open(string name, string options, bool visible = true)
        {
            var document = _inventor.Documents.Open(name, visible);

            return new InventorDocument(document);
        }

        public static void CloseAll() => _inventor.Documents.CloseAll();

        public static void Dispose()
        {
            if (_inventor != null)
            {
                Marshal.ReleaseComObject(_inventor);
                Marshal.ReleaseComObject(_events);
            }
        }
    }
}
