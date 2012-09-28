using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WeatherService
{
    public enum productType
    {
        [SoapEnum("time-series")]
        timeseries,glance,
    }
    public enum unitType { e, m }
    public enum sectorType { conus, nhemi, alaska, guam, hawaii, puertori, npacocn }
    public enum compTypeType { IsEqual, Between, GreaterThan, GreaterThanEqualTo, LessThan, LessThanEqualTo }
    public enum featureTypeType { Forecast_Gml2Point, Forecast_Gml2AllWx, Forecast_GmlsfPoint, Forecast_GmlObs, NdfdMultiPointCoverage, Ndfd_KmlPoint }
    public enum formatType
    {

        [SoapEnumAttribute("24 hourly")]
        Item24hourly,
        [SoapEnumAttribute("12 hourly")]
        Item12hourly,
    }

    public enum temperatureItem
    {
        Temperature,
        RelativeHumidity
    }

}
