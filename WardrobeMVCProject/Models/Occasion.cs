//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WardrobeMVCProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Occasion
    {
        public Occasion()
        {
            this.Articles = new HashSet<Article>();
        }
    
        public int OccasionID { get; set; }
        [Display(Name = "Occasion")]
        public string Occasion1 { get; set; }
    
        public virtual ICollection<Article> Articles { get; set; }
    }
}
