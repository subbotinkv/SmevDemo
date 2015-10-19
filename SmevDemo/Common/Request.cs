namespace Common
{
    using System.ServiceModel;

    [MessageContract(IsWrapped = true, WrapperName = "SmevSampleRequest")]
    public class Request
    {
        [MessageBodyMember]
        public MessageType Message { get; set; }

        [MessageBodyMember]
        public MessageDataType MessageData { get; set; }
    }
}
