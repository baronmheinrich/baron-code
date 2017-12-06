using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SoapService
{
    [DataContract]
    public class PersonSoap
    {
        [DataMember]
        public static FName{get; set }

         [DataMember]
         public static FLast{get; set;}
    }
}