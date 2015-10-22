namespace SmevService
{
    using System.Net.Security;
    using System.ServiceModel;

    [ServiceContract(Namespace = "http://smev.gosuslugi.ru/rev120315", Name = "SmevDemoService",
        ProtectionLevel = ProtectionLevel.Sign)]
    public interface IService
    {
        [OperationContract]
        Response SampleMethod(Request request);
    }
}
