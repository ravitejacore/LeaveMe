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
    
    public partial class LeaveType
    {
        public LeaveType()
        {
            this.UsersLeaveApply = new HashSet<UsersLeaveApply>();
        }
    
        public int LeaveTypeID { get; set; }
        public string LeaveTypeName { get; set; }
        public string LeaveTypeDescription { get; set; }
        public string ColorCode { get; set; }
        public int LeaveDays { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public System.Guid CreatedBy { get; set; }
        public Nullable<System.Guid> UpdatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        public virtual ICollection<UsersLeaveApply> UsersLeaveApply { get; set; }
    }
}
