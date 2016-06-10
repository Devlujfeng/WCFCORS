using JavaScriptWebApp.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace JavaScriptWebApp.WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IinternalWCF" in both code and config file together.
    [ServiceContract]
    public interface IinternalWCF
    {
        [OperationContract]
        void DoWork();
        [OperationContract]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "getData?name={name}",
            ResponseFormat = WebMessageFormat.Json)]
        string getAllData(string name);

        [OperationContract]
        [WebInvoke(Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        string getAllData2(modelTest FirstName);

    }
}
