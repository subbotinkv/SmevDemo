namespace SmevService
{
    using System.ServiceModel;

    [MessageContract(IsWrapped = true, WrapperName = "SmevDemoRequest")]
    public class Request
    {
        [MessageBodyMember]
        public MessageType Message { get; set; }

        [MessageBodyMember]
        public MessageDataType MessageData { get; set; }
    }
}