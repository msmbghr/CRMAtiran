//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APPCRMAtiran
{
    using System;
    using System.Collections.Generic;
    
    public partial class taskComment
    {
        public int commentID { get; set; }
        public string date { get; set; }
        public string time { get; set; }
        public string comment { get; set; }
    
        public virtual task task { get; set; }
        public virtual user user { get; set; }
    }
}
