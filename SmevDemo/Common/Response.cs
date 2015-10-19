namespace Common
{
    using System.ServiceModel;

    [MessageContract(IsWrapped = true, WrapperName = "SmevSampleResponse")]
    public class Response
    {
        [MessageBodyMember]
        public MessageType Message { get; set; }

        [MessageBodyMember]
        public MessageDataType MessageData { get; set; }
    }
}