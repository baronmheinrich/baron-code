using System;
using System.Collections.Generic;

namespace datanet.ef
{
    public partial class email
    {
        public int EmailId { get; set; }
        public int ContactId { get; set; }
        public string Address { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ChangedDate { get; set; }
        public bool? ActiveFlag { get; set; }
    }
}
