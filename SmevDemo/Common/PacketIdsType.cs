namespace Common
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    [XmlType(Namespace = "http://smev.gosuslugi.ru/rev120315")]
    [XmlRoot("PacketIds", Namespace = "http://smev.gosuslugi.ru/rev120315", IsNullable = false)]
    public class PacketIdsType
    {
        [XmlElement("Id", Order = 0)]
        public PacketIdType[] Id { get; set; }
    }
}