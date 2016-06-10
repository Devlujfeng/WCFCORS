using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace JSTestDecode.models
{
    [DataContract]
    public class modelTest
    {

        [DataMember]
        public string FirstName { get; set; }


    }
}