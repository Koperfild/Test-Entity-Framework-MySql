//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entity_Framework_Test___MySql
{
    using System;
    using System.Collections.Generic;
    
    public partial class address
    {
        public address()
        {
            this.customer = new HashSet<customer>();
            this.staff = new HashSet<staff>();
            this.store = new HashSet<store>();
        }
    
        public int address_id { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string district { get; set; }
        public int city_id { get; set; }
        public string postal_code { get; set; }
        public string phone { get; set; }
        public System.DateTime last_update { get; set; }
    
        public virtual city city { get; set; }
        public virtual ICollection<customer> customer { get; set; }
        public virtual ICollection<staff> staff { get; set; }
        public virtual ICollection<store> store { get; set; }
    }
}
