namespace Common
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    [XmlType(Namespace = "http://smev.gosuslugi.ru/rev120315")]
    [XmlRoot("Reference", Namespace = "http://smev.gosuslugi.ru/rev120315", IsNullable = false)]
    public class ReferenceType
    {
        [XmlElement(Namespace = "http://www.w3.org/2004/08/xop/include", Order = 0)]
        public Include Include { get; set; }
        
        [XmlText]
        public string[] Text { get; set; }
    }
}