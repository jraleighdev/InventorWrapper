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
    /// <summary>
    /// Base wrapper around the inventor
    /// </summary>
    public static class InventorApplication
    {
        #region Interops

        /// <summary>
        /// Reference to interop inventor application
        /// </summary>
        public static Inventor.Application _inventor;

        // Reference to interop inventor application events
        public static Inventor.ApplicationEvents _events;

        #endregion

        #region Inventor Event Handling

        /// <summary>
        /// Handler for when the active document changes
        /// </summary>
        public delegate void DocumentChangedHandler();

        /// <summary>
        /// Event for when the active document changes
        /// </summary>
        public static event DocumentChangedHandler DocumentChanged;

        /// <summary>
        /// Tells the wrapper to listen for changes in the active document
        /// </summary>
        public static void Listen()
        {
            _events.OnActivateDocument += new ApplicationEventsSink_OnActivateDocumentEventHandler(NotifyDocumentChanged);
        }

        /// <summary>
        /// Tells the wrapper to stop listening to changes with the active dcoument
        /// </summary>
        public static void StopListening()
        {
            _events.OnActivateDocument -= new ApplicationEventsSink_OnActivateDocumentEventHandler(NotifyDocumentChanged);
        }

        /// <summary>
        /// Notifies listeners that the active document has changed
        /// Parameters are passed from inventor into this metho
        /// </summary>
        /// <param name="DocumentObject"></param>
        /// <param name="BeforeOrAfter"></param>
        /// <param name="Context"></param>
        /// <param name="HandlingCode"></param>
        public static void NotifyDocumentChanged(_Document DocumentObject, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode)
        {
            // Let inventor know the event has not been handled
            HandlingCode = HandlingCodeEnum.kEventNotHandled;

            // Make sure that the document has changed by checking for after
            if (BeforeOrAfter != EventTimingEnum.kAfter)
            {
                return;
            }

            // Let inventor know the event was handled
            HandlingCode = HandlingCodeEnum.kEventHandled;

            // Emit event to listeners that the active document has changed
            DocumentChanged();
        }

        /// <summary>
        /// If you are developing an addin use this method to attach the wrapper to inventor
        /// </summary>
        /// <param name="inventor"></param>
        public static void AddinAttach(Inventor.Application inventor)
        {
            _inventor = inventor;
            _events = _inventor.ApplicationEvents;
        }

        #endregion

        #region Application methods and properties

        /// <summary>
        /// Checks if the wrapper is attached to inventor
        /// </summary>
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
                    // if the inventor has been closed or crashed the attachment process will fail
                    try
                    {
                        // do a quick to check to make sure we can use the application
                        var doc = _inventor.Documents.Count;

                        return true;
                    }
                    catch (Exception ex)
                    {
                        // set inventor to null
                        _inventor = null;
                        return false;
                    }
                }
            }
        }

        /// <summary>
        /// Attaches the wrapper to inventor
        /// </summary>
        public static void Attach()
        {
            try
            {
                // try to attach to a running instance of inventor
                _inventor = (Inventor.Application)Marshal.GetActiveObject("Inventor.Application");
                _events = _inventor.ApplicationEvents;
            }
            // if the attachment process failed
            catch (Exception)
            {
                // try to start a new session of inventor
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

        #endregion

        #region Document Methods and Properties

        /// <summary>
        /// Gets the active document from the running session
        /// </summary>
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

        /// <summary>
        /// Opens an inventor document by file name
        /// </summary>
        /// <param name="name">File path of the document</param>
        /// <param name="visible">If the document should be visible</param>
        /// <returns></returns>
        public static InventorDocument Open(string name, bool visible = true)
        {
            var document = _inventor.Documents.Open(name, visible);

            return new InventorDocument(document);
        }

        /// <summary>
        /// Close all active documents
        /// </summary>
        public static void CloseAll() => _inventor.Documents.CloseAll();

        #endregion

        /// <summary>
        /// Release resources
        /// </summary>
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
