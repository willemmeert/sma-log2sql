//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sma_log2sql
{
    using System;
    using System.Collections.Generic;
    
    public partial class smadevice
    {
        public smadevice()
        {
            this.log_energymeter = new HashSet<log_energymeter>();
        }
    
        public int deviceID { get; set; }
        public int devicetype { get; set; }
        public Nullable<decimal> serialnumber { get; set; }
        public string hostname { get; set; }
        public string ipaddress { get; set; }
        public string targetaddress { get; set; }
        public string firmware { get; set; }
    
        public virtual ICollection<log_energymeter> log_energymeter { get; set; }
        public virtual smadevicetype smadevicetype { get; set; }
    }
}