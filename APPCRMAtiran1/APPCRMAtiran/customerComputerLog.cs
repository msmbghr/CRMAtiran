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
    
    public partial class customerComputerLog
    {
        public int customerComputerLogID { get; set; }
    
        public virtual convention convention { get; set; }
        public virtual convention convention1 { get; set; }
        public virtual customerComputers customerComputers { get; set; }
    }
}
