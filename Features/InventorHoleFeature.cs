using System;
using System.Runtime.InteropServices;
using Inventor;
using InventorWrapper.General;
using InventorWrapper.Parameters;

namespace InventorWrapper.Features
{
    public class InventorHoleFeature : IDisposable
    {
        public HoleFeature _holeFeature;

        public HoleFeatures _collectionRef;

        public InventorHoleFeature(HoleFeature feature, HoleFeatures collectionRef)
        {
            _holeFeature = feature;
            _collectionRef = collectionRef;
        }

        private InventorParameter _bottomTipAngle;
        
        public InventorParameter BottomTipAngle
        {
            get
            {
                if (_bottomTipAngle == null)
                {
                    _bottomTipAngle = new InventorParameter(_holeFeature.BottomTipAngle);
                }

                return _bottomTipAngle;
            }
        }
        
        private InventorParameter _cBoreDepth;
        
        public InventorParameter CBoreDepth
        {
            get
            {
                if (_cBoreDepth == null)
                {
                    _cBoreDepth = new InventorParameter(_holeFeature.CBoreDepth);
                }

                return _cBoreDepth;
            }
        }

        public double Depth => _holeFeature.Depth;

        public double ConvertedDepth => UnitManager.UnitsFromInventor(_holeFeature.Depth);

        private InventorParameter _holeDiameter;
        
        public InventorParameter HoleDiameter
        {
            get
            {
                if (_holeDiameter == null)
                {
                    _holeDiameter = new InventorParameter(_holeFeature.HoleDiameter);
                }

                return _holeDiameter;
            }
        }

        public HoleTypes HoleType => (HoleTypes)_holeFeature.HoleType;

        public string Name
        {
            get => _holeFeature.Name;
            set => _holeFeature.Name = value;
        }

        public void Delete() => _holeFeature.Delete();
        
        public bool Tapped => _holeFeature.Tapped;

        private InventorParameter _spotFaceDepth;
        
        public InventorParameter SpotFaceDepth
        {
            get
            {
                if (_spotFaceDepth == null)
                {
                    _spotFaceDepth = new InventorParameter(_holeFeature.SpotFaceDepth);
                }

                return _spotFaceDepth;
            }
        }
        
        private InventorParameter _spotFaceDiameter;
        
        public InventorParameter SpotFaceDiameter
        {
            get
            {
                if (_spotFaceDiameter == null)
                {
                    _spotFaceDiameter = new InventorParameter(_holeFeature.SpotFaceDiameter);
                }

                return _spotFaceDiameter;
            }
        }

        public object TapInfo
        {
            get => _holeFeature.TapInfo;
            set => _holeFeature.TapInfo = value;
        }

        public bool Suppressed
        {
            get => _holeFeature.Suppressed;
            set => _holeFeature.Suppressed = value;
        }

        public void SetTapInfo(bool rightHanded, string threadType, string threadDesignation, string threadClass, bool fullTapDpth, object threadDepth = null)
        {
            _holeFeature.TapInfo = _collectionRef.CreateTapInfo(rightHanded, threadType, threadDesignation, threadClass, fullTapDpth, threadDepth);
        }

        public void Dispose()
        {
            if (_holeFeature != null)
            {
                Marshal.ReleaseComObject(_holeFeature);
                _holeFeature = null;
            }
        }
    }
}