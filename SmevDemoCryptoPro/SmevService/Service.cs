[assembly: System.Runtime.Serialization.ContractNamespaceAttribute("http://smev.gosuslugi.ru/rev120315", ClrNamespace = "SmevService")]

namespace SmevService
{
    using System;
    using System.Text;

    public class Service : IService
    {
        public Response SampleMethod(Request request)
        {
            if (request == null || request.Message == null || request.MessageData == null)
            {
                throw new ArgumentException("Неверный запрос.");
            }

            Response response = new Response();

            response.Message = request.Message;
            response.Message.Date = DateTime.Now;
            response.Message.Status = StatusType.ACCEPT;

            response.MessageData = request.MessageData;

            string clientDocument = Encoding.UTF8.GetString(request.MessageData.AppDocument.Items);
            clientDocument = string.Format("Processed [{0}]: {1}", DateTime.Now, clientDocument);

            response.MessageData.AppDocument.Items = Encoding.UTF8.GetBytes(clientDocument);

            return response;
        }
    }
}
