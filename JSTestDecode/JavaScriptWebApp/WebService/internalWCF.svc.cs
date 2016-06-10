using JavaScriptWebApp.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;

namespace JavaScriptWebApp.WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "internalWCF" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select internalWCF.svc or internalWCF.svc.cs at the Solution Explorer and start debugging.
     [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class internalWCF : IinternalWCF
    {
        public void DoWork()
        {
        }
        public string getAllData(string name)
        {
            return name+"lujianfeng get Method";
        }
        public string getAllData2(modelTest data)
        {
            return data.FirstName + "post Method";
        }
    }
}
