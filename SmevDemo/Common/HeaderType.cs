namespace Common
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    [XmlType(Namespace = "http://smev.gosuslugi.ru/rev120315")]
    [XmlRoot("Header", Namespace = "http://smev.gosuslugi.ru/rev120315", IsNullable = false)]
    public class HeaderType
    {
        [XmlElement(Order = 0)]
        public string NodeId { get; set; }
        
        [XmlElement(Order = 1)]
        public string MessageId { get; set; }
        
        [XmlElement(Order = 2)]
        public DateTime TimeStamp { get; set; }
        
        [XmlElement(Order = 3)]
        public MessageClassType MessageClass { get; set; }
        
        [XmlArray(Order = 4)]
        [XmlArrayItem("Id", IsNullable = false)]
        public PacketIdType[] PacketIds { get; set; }
        
        [XmlAttribute("actor")]
        public string Actor { get; set; }
    }
}