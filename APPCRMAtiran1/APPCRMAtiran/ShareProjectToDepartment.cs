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
    
    public partial class ShareProjectToDepartment
    {
        public int ID { get; set; }
    
        public virtual department department { get; set; }
        public virtual project project { get; set; }
    }
}
