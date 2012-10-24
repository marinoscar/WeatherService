using System;
using System.ServiceModel;
using System.Xml.Serialization;

namespace WeatherService
{
    [ServiceContract(Namespace = "http://graphical.weather.gov/xml/DWMLgen/wsdl/ndfdXML.wsdl", ConfigurationName = "Service.IWeatherServiceClient")]
    public interface IWeatherServiceClient
    {

        [OperationContractAttribute(Action = "http://graphical.weather.gov/xml/DWMLgen/wsdl/ndfdXML.wsdl#NDFDgen", ReplyAction = "*")]
        [XmlSerializerFormatAttribute(Style = OperationFormatStyle.Rpc, SupportFaults = true, Use = OperationFormatUse.Encoded)]
        [return: MessageParameterAttribute(Name = "dwmlOut")]
        string NDFDgen(decimal latitude, decimal longitude, productType product, DateTime startTime, System.DateTime endTime, unitType Unit, weatherParametersType weatherParameters);

        [OperationContractAttribute(Action = "http://graphical.weather.gov/xml/DWMLgen/wsdl/ndfdXML.wsdl#NDFDgenByDay", ReplyAction = "*")]
        [XmlSerializerFormatAttribute(Style = OperationFormatStyle.Rpc, SupportFaults = true, Use = OperationFormatUse.Encoded)]
        [return: MessageParameterAttribute(Name = "dwmlByDayOut")]
        string NDFDgenByDay(decimal latitude, decimal longitude, [SoapElementAttribute(DataType = "date")] System.DateTime startDate, [SoapElement(DataType = "integer")] string numDays, unitType Unit, formatType format);

        [OperationContractAttribute(Action = "http://graphical.weather.gov/xml/DWMLgen/wsdl/ndfdXML.wsdl#NDFDgenLatLonList", ReplyAction = "*")]
        [XmlSerializerFormatAttribute(Style = OperationFormatStyle.Rpc, SupportFaults = true, Use = OperationFormatUse.Encoded)]
        [return: MessageParameterAttribute(Name = "dwmlOut")]
        string NDFDgenLatLonList(string listLatLon, productType product, System.DateTime startTime, System.DateTime endTime, unitType Unit, weatherParametersType weatherParameters);

        [OperationContractAttribute(Action = "http://graphical.weather.gov/xml/DWMLgen/wsdl/ndfdXML.wsdl#NDFDgenByDayLatLonList" +
            "", ReplyAction = "*")]
        [XmlSerializerFormatAttribute(Style = OperationFormatStyle.Rpc, SupportFaults = true, Use = OperationFormatUse.Encoded)]
        [return: MessageParameterAttribute(Name = "dwmlByDayOut")]
        string NDFDgenByDayLatLonList(string listLatLon, [SoapElementAttribute(DataType = "date")] System.DateTime startDate, [SoapElementAttribute(DataType = "integer")] string numDays, unitType Unit, formatType format);

        [OperationContractAttribute(Action = "http://graphical.weather.gov/xml/DWMLgen/wsdl/ndfdXML.wsdl#GmlLatLonList", ReplyAction = "*")]
        [XmlSerializerFormatAttribute(Style = OperationFormatStyle.Rpc, SupportFaults = true, Use = OperationFormatUse.Encoded)]
        [return: MessageParameterAttribute(Name = "dwGmlOut")]
        string GmlLatLonList(string listLatLon, System.DateTime requestedTime, featureTypeType featureType, unitType Unit, weatherParametersType weatherParameters);

        [OperationContractAttribute(Action = "http://graphical.weather.gov/xml/DWMLgen/wsdl/ndfdXML.wsdl#GmlTimeSeries", ReplyAction = "*")]
        [XmlSerializerFormatAttribute(Style = OperationFormatStyle.Rpc, SupportFaults = true, Use = OperationFormatUse.Encoded)]
        [return: MessageParameterAttribute(Name = "dwGmlOut")]
        string GmlTimeSeries(string listLatLon, System.DateTime startTime, System.DateTime endTime, compTypeType compType, featureTypeType featureType, unitType Unit, string propertyName);

        [OperationContractAttribute(Action = "http://graphical.weather.gov/xml/DWMLgen/wsdl/ndfdXML.wsdl#LatLonListSubgrid", ReplyAction = "*")]
        [XmlSerializerFormatAttribute(Style = OperationFormatStyle.Rpc, SupportFaults = true, Use = OperationFormatUse.Encoded)]
        [return: MessageParameterAttribute(Name = "listLatLonOut")]
        string LatLonListSubgrid(decimal lowerLeftLatitude, decimal lowerLeftLongitude, decimal upperRightLatitude, decimal upperRightLongitude, decimal resolution);

        [OperationContractAttribute(Action = "http://graphical.weather.gov/xml/DWMLgen/wsdl/ndfdXML.wsdl#LatLonListLine", ReplyAction = "*")]
        [XmlSerializerFormatAttribute(Style = OperationFormatStyle.Rpc, SupportFaults = true, Use = OperationFormatUse.Encoded)]
        [return: MessageParameterAttribute(Name = "listLatLonOut")]
        string LatLonListLine(decimal endPoint1Lat, decimal endPoint1Lon, decimal endPoint2Lat, decimal endPoint2Lon);

        [OperationContractAttribute(Action = "http://graphical.weather.gov/xml/DWMLgen/wsdl/ndfdXML.wsdl#LatLonListZipCode", ReplyAction = "*")]
        [XmlSerializerFormatAttribute(Style = OperationFormatStyle.Rpc, SupportFaults = true, Use = OperationFormatUse.Encoded)]
        [return: MessageParameterAttribute(Name = "listLatLonOut")]
        string LatLonListZipCode(string zipCodeList);

        [OperationContractAttribute(Action = "http://graphical.weather.gov/xml/DWMLgen/wsdl/ndfdXML.wsdl#LatLonListSquare", ReplyAction = "*")]
        [XmlSerializerFormatAttribute(Style = OperationFormatStyle.Rpc, SupportFaults = true, Use = OperationFormatUse.Encoded)]
        [return: MessageParameterAttribute(Name = "listLatLonOut")]
        string LatLonListSquare(decimal centerPointLat, decimal centerPointLon, decimal distanceLat, decimal distanceLon, decimal resolution);

        [OperationContractAttribute(Action = "http://graphical.weather.gov/xml/DWMLgen/wsdl/ndfdXML.wsdl#CornerPoints", ReplyAction = "*")]
        [XmlSerializerFormatAttribute(Style = OperationFormatStyle.Rpc, SupportFaults = true, Use = OperationFormatUse.Encoded)]
        [return: MessageParameterAttribute(Name = "listLatLonOut")]
        string CornerPoints(sectorType sector);

        [OperationContractAttribute(Action = "http://graphical.weather.gov/xml/DWMLgen/wsdl/ndfdXML.wsdl#LatLonListCityNames", ReplyAction = "*")]
        [XmlSerializerFormatAttribute(Style = OperationFormatStyle.Rpc, SupportFaults = true, Use = OperationFormatUse.Encoded)]
        [return: MessageParameterAttribute(Name = "listCityNamesOut")]
        string LatLonListCityNames([SoapElementAttribute(DataType = "integer")] string displayLevel);
    }
}
