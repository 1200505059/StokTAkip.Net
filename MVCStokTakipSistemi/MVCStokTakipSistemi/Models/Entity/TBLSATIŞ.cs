//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCStokTakipSistemi.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLSATIŞ
    {
        public int SATIŞID { get; set; }
        public Nullable<int> URUN { get; set; }
        public Nullable<int> MUSTERI { get; set; }
        public Nullable<int> ADET { get; set; }
        public Nullable<int> FİYAT { get; set; }
    
        public virtual TBLMUSTERI TBLMUSTERI { get; set; }
        public virtual TBLURUN TBLURUN { get; set; }
    }
}
