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
    
    public partial class smadevicetype
    {
        public smadevicetype()
        {
            this.smadevice = new HashSet<smadevice>();
        }
    
        public int devicetypeID { get; set; }
        public string devicetypeName { get; set; }
        public string devicetypeClass { get; set; }
    
        public virtual ICollection<smadevice> smadevice { get; set; }
    }
}
