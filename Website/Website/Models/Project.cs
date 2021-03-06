//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Project
    {
        public int ProjectID { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public int CategoryProjectID { get; set; }
        public int AuthorID { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<bool> Delete { get; set; }
    
        public virtual Author Author { get; set; }
        public virtual CategoryProject CategoryProject { get; set; }
    }
}
