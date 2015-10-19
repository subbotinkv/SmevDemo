namespace Common
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    [XmlType(Namespace = "http://smev.gosuslugi.ru/rev120315")]
    [XmlRoot("SubMessages", Namespace = "http://smev.gosuslugi.ru/rev120315", IsNullable = false)]
    public class SubMessagesType
    {

        private SubMessageType[] subMessageField;


        [XmlElement("SubMessage", Order = 0)]
        public SubMessageType[] SubMessage { get; set; }
    }
}