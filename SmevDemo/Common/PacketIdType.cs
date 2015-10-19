namespace Common
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    [XmlType(Namespace = "http://smev.gosuslugi.ru/rev120315")]
    [XmlRoot("Id", Namespace = "http://smev.gosuslugi.ru/rev120315", IsNullable = false)]
    public class PacketIdType
    {
        [XmlElement(Order = 0)]
        public string MessageId { get; set; }
        
        [XmlElement(Order = 1)]
        public string SubRequestNumber { get; set; }
    }
}