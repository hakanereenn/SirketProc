//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SirketProc
{
    using System;
    using System.Collections.Generic;
    
    public partial class Elemanlar
    {
        public int ElemanNo { get; set; }
        public string ElemanAdi { get; set; }
        public string ElemanPozisyon { get; set; }
        public Nullable<decimal> ElemanMaas { get; set; }
        public string ElemanStatu { get; set; }
        public Nullable<int> GorevNo { get; set; }
    
        public virtual Gorevler Gorevler { get; set; }
    }
}