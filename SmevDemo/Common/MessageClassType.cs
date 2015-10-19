namespace Common
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    [XmlType(Namespace = "http://smev.gosuslugi.ru/rev120315")]
    [XmlRoot("MessageClass", Namespace = "http://smev.gosuslugi.ru/rev120315", IsNullable = false)]
    public enum MessageClassType
    {
        REQUEST,
        RESPONSE
    }
}