using System;
using System.Collections.Generic;

namespace datanet.ef
{
    public partial class phone
    {
        public int PhoneId { get; set; }
        public int? ContactId { get; set; }
        public string Phonenumber { get; set; }
        public bool? ActiveFlag { get; set; }
    }
}
