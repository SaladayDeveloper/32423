//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1
{
    using System;
    using System.Collections.Generic;
    
    public partial class company_of_buh
    {
        public int id { get; set; }
        public Nullable<int> buh { get; set; }
        public Nullable<int> company { get; set; }
    
        public virtual buhgalter buhgalter { get; set; }
    }
}
