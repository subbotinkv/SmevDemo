namespace Common
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    [XmlType(Namespace = "http://smev.gosuslugi.ru/rev120315")]
    [XmlRoot("BaseMessage", Namespace = "http://smev.gosuslugi.ru/rev120315", IsNullable = false)]
    public class BaseMessageType
    {
        [XmlElement(Order = 0)]
        public MessageType Message { get; set; }

        [XmlElement(Order = 1)]
        public MessageDataType MessageData { get; set; }
    }
}