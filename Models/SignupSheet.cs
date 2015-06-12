using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class SignupSheet
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<byte> Slot { get; set; }
        public Nullable<System.DateTime> DateSigned { get; set; }
    }
}
