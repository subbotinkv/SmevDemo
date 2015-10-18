namespace Service
{
    using System.ServiceModel;
    using System.Net.Security;

    using Common;

    [ServiceContract(Namespace = "http://smev.gosuslugi.ru/rev120315", Name = "SmevServiceDemo", ProtectionLevel = ProtectionLevel.Sign)]
    public interface IService
    {
        [OperationContract]
        Response TestMethod(Request request);
    }
}
