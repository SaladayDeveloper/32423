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
    
    public partial class service_bugh
    {
        public int id { get; set; }
        public Nullable<int> buhgalter { get; set; }
        public Nullable<int> service { get; set; }
    
        public virtual buhgalter buhgalter1 { get; set; }
        public virtual service service1 { get; set; }
    }
}
