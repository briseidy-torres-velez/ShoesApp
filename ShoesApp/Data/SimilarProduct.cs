//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class SimilarProduct
    {
        public int IdSimilarProduct { get; set; }
        public int IdProduct { get; set; }
        public int IdSimilary { get; set; }
    
        public virtual Products Products { get; set; }
    }
}
