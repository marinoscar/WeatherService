using System;
using System.Collections.Generic;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.Text;
using System.Xml;

namespace WeatherService
{
    public class IsoTextMessageBindingElement : MessageEncodingBindingElement, IWsdlExportExtension
    {
        private MessageVersion _msgVersion;
        private string _mediaType;
        private string _encoding;
        private readonly XmlDictionaryReaderQuotas _readerQuotas;

        IsoTextMessageBindingElement(IsoTextMessageBindingElement binding)
            : this(binding.Encoding, binding.MediaType, binding.MessageVersion)
        {
            this._readerQuotas = new XmlDictionaryReaderQuotas();
            binding.ReaderQuotas.CopyTo(this._readerQuotas);
        }

        public IsoTextMessageBindingElement(string encoding, string mediaType,
            MessageVersion msgVersion)
        {
            if (encoding == null)
                throw new ArgumentNullException("encoding");

            if (mediaType == null)
                throw new ArgumentNullException("mediaType");

            if (msgVersion == null)
                throw new ArgumentNullException("msgVersion");

            this._msgVersion = msgVersion;
            this._mediaType = mediaType;
            this._encoding = encoding;
            this._readerQuotas = new XmlDictionaryReaderQuotas();
        }

        public IsoTextMessageBindingElement(string encoding, string mediaType)
            : this(encoding, mediaType, MessageVersion.Soap11WSAddressing10)
        {
        }

        public IsoTextMessageBindingElement(string encoding)
            : this(encoding, "text/xml")
        {

        }

        public IsoTextMessageBindingElement()
            : this("UTF-8")
        {
        }

        public override MessageVersion MessageVersion
        {
            get
            {
                return this._msgVersion;
            }

            set
            {
                if (value == null)
                    throw new ArgumentNullException("value");
                this._msgVersion = value;
            }
        }


        public string MediaType
        {
            get
            {
                return this._mediaType;
            }

            set
            {
                if (value == null)
                    throw new ArgumentNullException("value");
                this._mediaType = value;
            }
        }

        public string Encoding
        {
            get
            {
                return this._encoding;
            }

            set
            {
                if (value == null)
                    throw new ArgumentNullException("value");
                this._encoding = value;
            }
        }

        // This encoder does not enforces any quotas for the unsecure messages. The 
        // quotas are enforced for the secure portions of messages when this encoder
        // is used in a binding that is configured with security. 
        public XmlDictionaryReaderQuotas ReaderQuotas
        {
            get
            {
                return this._readerQuotas;
            }
        }

        #region IMessageEncodingBindingElement Members

        public override MessageEncoderFactory CreateMessageEncoderFactory()
        {
            return new IsoTextMessageEncoderFactory(this.MediaType,
                this.Encoding, this.MessageVersion);
        }

        #endregion


        public override BindingElement Clone()
        {
            return new IsoTextMessageBindingElement(this);
        }

        public override IChannelFactory<TChannel> BuildChannelFactory<TChannel>(BindingContext context)
        {
            if (context == null)
                throw new ArgumentNullException("context");

            context.BindingParameters.Add(this);
            return context.BuildInnerChannelFactory<TChannel>();
        }

        public override bool CanBuildChannelFactory<TChannel>(BindingContext context)
        {
            if (context == null)
                throw new ArgumentNullException("context");

            return context.CanBuildInnerChannelFactory<TChannel>();
        }

        public override IChannelListener<TChannel> BuildChannelListener<TChannel>(BindingContext context)
        {
            if (context == null)
                throw new ArgumentNullException("context");

            context.BindingParameters.Add(this);
            return context.BuildInnerChannelListener<TChannel>();
        }

        public override bool CanBuildChannelListener<TChannel>(BindingContext context)
        {
            if (context == null)
                throw new ArgumentNullException("context");

            context.BindingParameters.Add(this);
            return context.CanBuildInnerChannelListener<TChannel>();
        }

        public override T GetProperty<T>(BindingContext context)
        {
            if (typeof(T) == typeof(XmlDictionaryReaderQuotas))
            {
                return (T)(object)this._readerQuotas;
            }
            else
            {
                return base.GetProperty<T>(context);
            }
        }

        #region IWsdlExportExtension Members

        void IWsdlExportExtension.ExportContract(WsdlExporter exporter, WsdlContractConversionContext context)
        {
        }

        void IWsdlExportExtension.ExportEndpoint(WsdlExporter exporter, WsdlEndpointConversionContext context)
        {
            // The MessageEncodingBindingElement is responsible for ensuring that the WSDL has the correct
            // SOAP version. We can delegate to the WCF implementation of TextMessageEncodingBindingElement for this.
            var mebe = new TextMessageEncodingBindingElement();
            mebe.MessageVersion = this._msgVersion;
            ((IWsdlExportExtension)mebe).ExportEndpoint(exporter, context);
        }

        #endregion
    }
}
