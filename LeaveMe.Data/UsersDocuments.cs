//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LeaveMe.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class UsersDocuments
    {
        public System.Guid DocumentID { get; set; }
        public System.Guid UserID { get; set; }
        public string DocumentName { get; set; }
        public int DocumentTypeID { get; set; }
        public string StorePath { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public System.Guid CreatedBy { get; set; }
        public Nullable<System.Guid> UpdatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        public virtual Users Users { get; set; }
    }
}
