//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace giadinhthoxinh.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblMaterSize
    {
        public int PK_iMaterSizeID { get; set; }
        public int FK_iMaterialID { get; set; }
        public string sMaterSize { get; set; }
    
        public virtual tblMaterial tblMaterial { get; set; }
    }
}
