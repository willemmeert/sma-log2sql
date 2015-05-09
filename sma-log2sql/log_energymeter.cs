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
    
    public partial class log_energymeter
    {
        public int device { get; set; }
        public int logtime { get; set; }
        public Nullable<int> p_in_l1_act { get; set; }
        public Nullable<int> p_in_l2_act { get; set; }
        public Nullable<int> p_in_l3_act { get; set; }
        public Nullable<int> p_in_all_act { get; set; }
        public Nullable<int> q_in_l1_act1 { get; set; }
        public Nullable<int> q_in_l2_act1 { get; set; }
        public Nullable<int> q_in_l3_act1 { get; set; }
        public Nullable<int> q_in_all_act1 { get; set; }
        public Nullable<int> s_in_l1_act1 { get; set; }
        public Nullable<int> s_in_l2_act1 { get; set; }
        public Nullable<int> s_in_l3_act1 { get; set; }
        public Nullable<int> s_in_all_act1 { get; set; }
        public Nullable<int> p_out_l1_act1 { get; set; }
        public Nullable<int> p_out_l2_act1 { get; set; }
        public Nullable<int> p_out_l3_act1 { get; set; }
        public Nullable<int> p_out_all_act1 { get; set; }
        public Nullable<int> q_out_l1_act1 { get; set; }
        public Nullable<int> q_out_l2_act1 { get; set; }
        public Nullable<int> q_out_l3_act1 { get; set; }
        public Nullable<int> q_out_all_act1 { get; set; }
        public Nullable<int> s_out_l1_act1 { get; set; }
        public Nullable<int> s_out_l2_act1 { get; set; }
        public Nullable<int> s_out_l3_act1 { get; set; }
        public Nullable<int> s_out_all_act1 { get; set; }
        public Nullable<int> cosphi_l1 { get; set; }
        public Nullable<int> cosphi_l2 { get; set; }
        public Nullable<int> cosphi_l3 { get; set; }
        public Nullable<int> thd_l1 { get; set; }
        public Nullable<int> thd_l2 { get; set; }
        public Nullable<int> thd_l3 { get; set; }
        public Nullable<int> v_l1 { get; set; }
        public Nullable<int> v_l2 { get; set; }
        public Nullable<int> v_l3 { get; set; }
        public Nullable<long> p_in_l1_sum { get; set; }
        public Nullable<long> p_in_l2_sum { get; set; }
        public Nullable<long> p_in_l3_sum { get; set; }
        public Nullable<long> p_in_all_sum { get; set; }
        public Nullable<long> q_in_l1_sum { get; set; }
        public Nullable<long> q_in_l2_sum { get; set; }
        public Nullable<long> q_in_l3_sum { get; set; }
        public Nullable<long> q_in_all_sum { get; set; }
        public Nullable<long> s_in_l1_sum { get; set; }
        public Nullable<long> s_in_l2_sum { get; set; }
        public Nullable<long> s_in_l3_sum { get; set; }
        public Nullable<long> s_in_all_sum { get; set; }
        public Nullable<long> p_out_l1_sum { get; set; }
        public Nullable<long> p_out_l2_sum { get; set; }
        public Nullable<long> p_out_l3_sum { get; set; }
        public Nullable<long> p_out_all_sum { get; set; }
        public Nullable<long> q_out_l1_sum { get; set; }
        public Nullable<long> q_out_l2_sum { get; set; }
        public Nullable<long> q_out_l3_sum { get; set; }
        public Nullable<long> q_out_all_sum { get; set; }
    
        public virtual smadevice smadevice { get; set; }
    }
}
