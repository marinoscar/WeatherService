using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherService
{
    public partial class weatherParametersType : object, System.ComponentModel.INotifyPropertyChanged
    {

        private bool maxtField;

        private bool mintField;

        private bool tempField;

        private bool dewField;

        private bool pop12Field;

        private bool qpfField;

        private bool skyField;

        private bool snowField;

        private bool wspdField;

        private bool wdirField;

        private bool wxField;

        private bool wavehField;

        private bool iconsField;

        private bool rhField;

        private bool apptField;

        private bool incw34Field;

        private bool incw50Field;

        private bool incw64Field;

        private bool cumw34Field;

        private bool cumw50Field;

        private bool cumw64Field;

        private bool critfireoField;

        private bool dryfireoField;

        private bool conhazoField;

        private bool ptornadoField;

        private bool phailField;

        private bool ptstmwindsField;

        private bool pxtornadoField;

        private bool pxhailField;

        private bool pxtstmwindsField;

        private bool ptotsvrtstmField;

        private bool pxtotsvrtstmField;

        private bool tmpabv14dField;

        private bool tmpblw14dField;

        private bool tmpabv30dField;

        private bool tmpblw30dField;

        private bool tmpabv90dField;

        private bool tmpblw90dField;

        private bool prcpabv14dField;

        private bool prcpblw14dField;

        private bool prcpabv30dField;

        private bool prcpblw30dField;

        private bool prcpabv90dField;

        private bool prcpblw90dField;

        private bool precipa_rField;

        private bool sky_rField;

        private bool td_rField;

        private bool temp_rField;

        private bool wdir_rField;

        private bool wspd_rField;

        private bool wwaField;

        private bool tstmprbField;

        private bool tstmcatField;

        private bool wgustField;

        private bool iceaccumField;

        /// <remarks/>
        public bool maxt
        {
            get
            {
                return this.maxtField;
            }
            set
            {
                this.maxtField = value;
                this.RaisePropertyChanged("maxt");
            }
        }

        /// <remarks/>
        public bool mint
        {
            get
            {
                return this.mintField;
            }
            set
            {
                this.mintField = value;
                this.RaisePropertyChanged("mint");
            }
        }

        /// <remarks/>
        public bool temp
        {
            get
            {
                return this.tempField;
            }
            set
            {
                this.tempField = value;
                this.RaisePropertyChanged("temp");
            }
        }

        /// <remarks/>
        public bool dew
        {
            get
            {
                return this.dewField;
            }
            set
            {
                this.dewField = value;
                this.RaisePropertyChanged("dew");
            }
        }

        /// <remarks/>
        public bool pop12
        {
            get
            {
                return this.pop12Field;
            }
            set
            {
                this.pop12Field = value;
                this.RaisePropertyChanged("pop12");
            }
        }

        /// <remarks/>
        public bool qpf
        {
            get
            {
                return this.qpfField;
            }
            set
            {
                this.qpfField = value;
                this.RaisePropertyChanged("qpf");
            }
        }

        /// <remarks/>
        public bool sky
        {
            get
            {
                return this.skyField;
            }
            set
            {
                this.skyField = value;
                this.RaisePropertyChanged("sky");
            }
        }

        /// <remarks/>
        public bool snow
        {
            get
            {
                return this.snowField;
            }
            set
            {
                this.snowField = value;
                this.RaisePropertyChanged("snow");
            }
        }

        /// <remarks/>
        public bool wspd
        {
            get
            {
                return this.wspdField;
            }
            set
            {
                this.wspdField = value;
                this.RaisePropertyChanged("wspd");
            }
        }

        /// <remarks/>
        public bool wdir
        {
            get
            {
                return this.wdirField;
            }
            set
            {
                this.wdirField = value;
                this.RaisePropertyChanged("wdir");
            }
        }

        /// <remarks/>
        public bool wx
        {
            get
            {
                return this.wxField;
            }
            set
            {
                this.wxField = value;
                this.RaisePropertyChanged("wx");
            }
        }

        /// <remarks/>
        public bool waveh
        {
            get
            {
                return this.wavehField;
            }
            set
            {
                this.wavehField = value;
                this.RaisePropertyChanged("waveh");
            }
        }

        /// <remarks/>
        public bool icons
        {
            get
            {
                return this.iconsField;
            }
            set
            {
                this.iconsField = value;
                this.RaisePropertyChanged("icons");
            }
        }

        /// <remarks/>
        public bool rh
        {
            get
            {
                return this.rhField;
            }
            set
            {
                this.rhField = value;
                this.RaisePropertyChanged("rh");
            }
        }

        /// <remarks/>
        public bool appt
        {
            get
            {
                return this.apptField;
            }
            set
            {
                this.apptField = value;
                this.RaisePropertyChanged("appt");
            }
        }

        /// <remarks/>
        public bool incw34
        {
            get
            {
                return this.incw34Field;
            }
            set
            {
                this.incw34Field = value;
                this.RaisePropertyChanged("incw34");
            }
        }

        /// <remarks/>
        public bool incw50
        {
            get
            {
                return this.incw50Field;
            }
            set
            {
                this.incw50Field = value;
                this.RaisePropertyChanged("incw50");
            }
        }

        /// <remarks/>
        public bool incw64
        {
            get
            {
                return this.incw64Field;
            }
            set
            {
                this.incw64Field = value;
                this.RaisePropertyChanged("incw64");
            }
        }

        /// <remarks/>
        public bool cumw34
        {
            get
            {
                return this.cumw34Field;
            }
            set
            {
                this.cumw34Field = value;
                this.RaisePropertyChanged("cumw34");
            }
        }

        /// <remarks/>
        public bool cumw50
        {
            get
            {
                return this.cumw50Field;
            }
            set
            {
                this.cumw50Field = value;
                this.RaisePropertyChanged("cumw50");
            }
        }

        /// <remarks/>
        public bool cumw64
        {
            get
            {
                return this.cumw64Field;
            }
            set
            {
                this.cumw64Field = value;
                this.RaisePropertyChanged("cumw64");
            }
        }

        /// <remarks/>
        public bool critfireo
        {
            get
            {
                return this.critfireoField;
            }
            set
            {
                this.critfireoField = value;
                this.RaisePropertyChanged("critfireo");
            }
        }

        /// <remarks/>
        public bool dryfireo
        {
            get
            {
                return this.dryfireoField;
            }
            set
            {
                this.dryfireoField = value;
                this.RaisePropertyChanged("dryfireo");
            }
        }

        /// <remarks/>
        public bool conhazo
        {
            get
            {
                return this.conhazoField;
            }
            set
            {
                this.conhazoField = value;
                this.RaisePropertyChanged("conhazo");
            }
        }

        /// <remarks/>
        public bool ptornado
        {
            get
            {
                return this.ptornadoField;
            }
            set
            {
                this.ptornadoField = value;
                this.RaisePropertyChanged("ptornado");
            }
        }

        /// <remarks/>
        public bool phail
        {
            get
            {
                return this.phailField;
            }
            set
            {
                this.phailField = value;
                this.RaisePropertyChanged("phail");
            }
        }

        /// <remarks/>
        public bool ptstmwinds
        {
            get
            {
                return this.ptstmwindsField;
            }
            set
            {
                this.ptstmwindsField = value;
                this.RaisePropertyChanged("ptstmwinds");
            }
        }

        /// <remarks/>
        public bool pxtornado
        {
            get
            {
                return this.pxtornadoField;
            }
            set
            {
                this.pxtornadoField = value;
                this.RaisePropertyChanged("pxtornado");
            }
        }

        /// <remarks/>
        public bool pxhail
        {
            get
            {
                return this.pxhailField;
            }
            set
            {
                this.pxhailField = value;
                this.RaisePropertyChanged("pxhail");
            }
        }

        /// <remarks/>
        public bool pxtstmwinds
        {
            get
            {
                return this.pxtstmwindsField;
            }
            set
            {
                this.pxtstmwindsField = value;
                this.RaisePropertyChanged("pxtstmwinds");
            }
        }

        /// <remarks/>
        public bool ptotsvrtstm
        {
            get
            {
                return this.ptotsvrtstmField;
            }
            set
            {
                this.ptotsvrtstmField = value;
                this.RaisePropertyChanged("ptotsvrtstm");
            }
        }

        /// <remarks/>
        public bool pxtotsvrtstm
        {
            get
            {
                return this.pxtotsvrtstmField;
            }
            set
            {
                this.pxtotsvrtstmField = value;
                this.RaisePropertyChanged("pxtotsvrtstm");
            }
        }

        /// <remarks/>
        public bool tmpabv14d
        {
            get
            {
                return this.tmpabv14dField;
            }
            set
            {
                this.tmpabv14dField = value;
                this.RaisePropertyChanged("tmpabv14d");
            }
        }

        /// <remarks/>
        public bool tmpblw14d
        {
            get
            {
                return this.tmpblw14dField;
            }
            set
            {
                this.tmpblw14dField = value;
                this.RaisePropertyChanged("tmpblw14d");
            }
        }

        /// <remarks/>
        public bool tmpabv30d
        {
            get
            {
                return this.tmpabv30dField;
            }
            set
            {
                this.tmpabv30dField = value;
                this.RaisePropertyChanged("tmpabv30d");
            }
        }

        /// <remarks/>
        public bool tmpblw30d
        {
            get
            {
                return this.tmpblw30dField;
            }
            set
            {
                this.tmpblw30dField = value;
                this.RaisePropertyChanged("tmpblw30d");
            }
        }

        /// <remarks/>
        public bool tmpabv90d
        {
            get
            {
                return this.tmpabv90dField;
            }
            set
            {
                this.tmpabv90dField = value;
                this.RaisePropertyChanged("tmpabv90d");
            }
        }

        /// <remarks/>
        public bool tmpblw90d
        {
            get
            {
                return this.tmpblw90dField;
            }
            set
            {
                this.tmpblw90dField = value;
                this.RaisePropertyChanged("tmpblw90d");
            }
        }

        /// <remarks/>
        public bool prcpabv14d
        {
            get
            {
                return this.prcpabv14dField;
            }
            set
            {
                this.prcpabv14dField = value;
                this.RaisePropertyChanged("prcpabv14d");
            }
        }

        /// <remarks/>
        public bool prcpblw14d
        {
            get
            {
                return this.prcpblw14dField;
            }
            set
            {
                this.prcpblw14dField = value;
                this.RaisePropertyChanged("prcpblw14d");
            }
        }

        /// <remarks/>
        public bool prcpabv30d
        {
            get
            {
                return this.prcpabv30dField;
            }
            set
            {
                this.prcpabv30dField = value;
                this.RaisePropertyChanged("prcpabv30d");
            }
        }

        /// <remarks/>
        public bool prcpblw30d
        {
            get
            {
                return this.prcpblw30dField;
            }
            set
            {
                this.prcpblw30dField = value;
                this.RaisePropertyChanged("prcpblw30d");
            }
        }

        /// <remarks/>
        public bool prcpabv90d
        {
            get
            {
                return this.prcpabv90dField;
            }
            set
            {
                this.prcpabv90dField = value;
                this.RaisePropertyChanged("prcpabv90d");
            }
        }

        /// <remarks/>
        public bool prcpblw90d
        {
            get
            {
                return this.prcpblw90dField;
            }
            set
            {
                this.prcpblw90dField = value;
                this.RaisePropertyChanged("prcpblw90d");
            }
        }

        /// <remarks/>
        public bool precipa_r
        {
            get
            {
                return this.precipa_rField;
            }
            set
            {
                this.precipa_rField = value;
                this.RaisePropertyChanged("precipa_r");
            }
        }

        /// <remarks/>
        public bool sky_r
        {
            get
            {
                return this.sky_rField;
            }
            set
            {
                this.sky_rField = value;
                this.RaisePropertyChanged("sky_r");
            }
        }

        /// <remarks/>
        public bool td_r
        {
            get
            {
                return this.td_rField;
            }
            set
            {
                this.td_rField = value;
                this.RaisePropertyChanged("td_r");
            }
        }

        /// <remarks/>
        public bool temp_r
        {
            get
            {
                return this.temp_rField;
            }
            set
            {
                this.temp_rField = value;
                this.RaisePropertyChanged("temp_r");
            }
        }

        /// <remarks/>
        public bool wdir_r
        {
            get
            {
                return this.wdir_rField;
            }
            set
            {
                this.wdir_rField = value;
                this.RaisePropertyChanged("wdir_r");
            }
        }

        /// <remarks/>
        public bool wspd_r
        {
            get
            {
                return this.wspd_rField;
            }
            set
            {
                this.wspd_rField = value;
                this.RaisePropertyChanged("wspd_r");
            }
        }

        /// <remarks/>
        public bool wwa
        {
            get
            {
                return this.wwaField;
            }
            set
            {
                this.wwaField = value;
                this.RaisePropertyChanged("wwa");
            }
        }

        /// <remarks/>
        public bool tstmprb
        {
            get
            {
                return this.tstmprbField;
            }
            set
            {
                this.tstmprbField = value;
                this.RaisePropertyChanged("tstmprb");
            }
        }

        /// <remarks/>
        public bool tstmcat
        {
            get
            {
                return this.tstmcatField;
            }
            set
            {
                this.tstmcatField = value;
                this.RaisePropertyChanged("tstmcat");
            }
        }

        /// <remarks/>
        public bool wgust
        {
            get
            {
                return this.wgustField;
            }
            set
            {
                this.wgustField = value;
                this.RaisePropertyChanged("wgust");
            }
        }

        /// <remarks/>
        public bool iceaccum
        {
            get
            {
                return this.iceaccumField;
            }
            set
            {
                this.iceaccumField = value;
                this.RaisePropertyChanged("iceaccum");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
