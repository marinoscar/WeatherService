using System;
using System.Collections.Generic;
using System.ServiceModel.Channels;
using System.Text;

namespace WeatherService
{
    public class IsoTextMessageEncoderFactory : MessageEncoderFactory
    {

        private readonly MessageEncoder _encoder;
        private readonly MessageVersion _version;
        private readonly string _mediaType;
        private readonly string _charSet;

        internal IsoTextMessageEncoderFactory(string mediaType, string charSet,
            MessageVersion version)
        {
            _version = version;
            _mediaType = mediaType;
            _charSet = charSet;
            _encoder = new IsoTextMessageEncoder(this);
        }

        public override MessageEncoder Encoder
        {
            get 
            { 
                return _encoder;
            }
        }

        public override MessageVersion MessageVersion
        {
            get 
            { 
                return _version;
            }
        }

        internal string MediaType
        {
            get
            {
                return _mediaType;
            }
        }

        internal string CharSet
        {
            get
            {
                return _charSet;
            }
        }
    }
}
