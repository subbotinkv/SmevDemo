namespace Common
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    [XmlType(Namespace = "http://smev.gosuslugi.ru/rev120315", IncludeInSchema = false)]
    public enum ItemsChoiceType
    {
        BinaryData,
        DigestValue,
        Reference
    }
}