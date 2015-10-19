namespace Common
{
    using System.Runtime.Serialization;

    [DataContract]
    public class MessageDataType
    {
        [DataMember(Order = 0)]
        public AppDataType AppData { get; set; }

        [DataMember(Order = 1)]
        public AppDocumentType AppDocument { get; set; }
    }
}