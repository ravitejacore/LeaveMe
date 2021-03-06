﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class LeaveSysEntities : DbContext
    {
        public LeaveSysEntities()
            : base("name=LeaveSysEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<LeaveType> LeaveType { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UsersDocuments> UsersDocuments { get; set; }
        public virtual DbSet<UsersEducation> UsersEducation { get; set; }
        public virtual DbSet<UsersEmergencyContact> UsersEmergencyContact { get; set; }
        public virtual DbSet<UsersExperience> UsersExperience { get; set; }
        public virtual DbSet<UsersLeaveApply> UsersLeaveApply { get; set; }
        public virtual DbSet<UsersProfile> UsersProfile { get; set; }
        public virtual DbSet<UsersReporting> UsersReporting { get; set; }
        public virtual DbSet<UsersRole> UsersRole { get; set; }
        public virtual DbSet<UsersWork> UsersWork { get; set; }
        public virtual DbSet<WorkTitles> WorkTitles { get; set; }
        public virtual DbSet<vw_Users_Info> vw_Users_Info { get; set; }
        public virtual DbSet<vw_Users_ViewUsers> vw_Users_ViewUsers { get; set; }
    
        public virtual ObjectResult<ups_Roles_GetRoles_Result> ups_Roles_GetRoles()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ups_Roles_GetRoles_Result>("ups_Roles_GetRoles");
        }
    
        public virtual int ups_Users_CreateUser(string email, string password, Nullable<System.Guid> createdBy, string firstName, string middleName, string lastName, Nullable<int> workTitleID, Nullable<int> roleID)
        {
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var createdByParameter = createdBy.HasValue ?
                new ObjectParameter("CreatedBy", createdBy) :
                new ObjectParameter("CreatedBy", typeof(System.Guid));
    
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var middleNameParameter = middleName != null ?
                new ObjectParameter("MiddleName", middleName) :
                new ObjectParameter("MiddleName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var workTitleIDParameter = workTitleID.HasValue ?
                new ObjectParameter("WorkTitleID", workTitleID) :
                new ObjectParameter("WorkTitleID", typeof(int));
    
            var roleIDParameter = roleID.HasValue ?
                new ObjectParameter("RoleID", roleID) :
                new ObjectParameter("RoleID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ups_Users_CreateUser", emailParameter, passwordParameter, createdByParameter, firstNameParameter, middleNameParameter, lastNameParameter, workTitleIDParameter, roleIDParameter);
        }
    
        public virtual ObjectResult<ups_UsersProfile_GetByUserID_Result> ups_UsersProfile_GetByUserID(Nullable<System.Guid> userID)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ups_UsersProfile_GetByUserID_Result>("ups_UsersProfile_GetByUserID", userIDParameter);
        }
    
        public virtual int ups_UsersProfile_UpdateByUserID(Nullable<System.Guid> userID, string firstName, string middleName, string lastName, Nullable<int> workTitleID, Nullable<System.DateTime> dOJ, string displayID, Nullable<bool> gender, Nullable<System.DateTime> dOB, Nullable<int> martialStatus, string address, string city, string state, string zipCode, string country, string mobile, string otherEmailAddress, Nullable<System.Guid> updatedBy)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(System.Guid));
    
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var middleNameParameter = middleName != null ?
                new ObjectParameter("MiddleName", middleName) :
                new ObjectParameter("MiddleName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var workTitleIDParameter = workTitleID.HasValue ?
                new ObjectParameter("WorkTitleID", workTitleID) :
                new ObjectParameter("WorkTitleID", typeof(int));
    
            var dOJParameter = dOJ.HasValue ?
                new ObjectParameter("DOJ", dOJ) :
                new ObjectParameter("DOJ", typeof(System.DateTime));
    
            var displayIDParameter = displayID != null ?
                new ObjectParameter("DisplayID", displayID) :
                new ObjectParameter("DisplayID", typeof(string));
    
            var genderParameter = gender.HasValue ?
                new ObjectParameter("Gender", gender) :
                new ObjectParameter("Gender", typeof(bool));
    
            var dOBParameter = dOB.HasValue ?
                new ObjectParameter("DOB", dOB) :
                new ObjectParameter("DOB", typeof(System.DateTime));
    
            var martialStatusParameter = martialStatus.HasValue ?
                new ObjectParameter("MartialStatus", martialStatus) :
                new ObjectParameter("MartialStatus", typeof(int));
    
            var addressParameter = address != null ?
                new ObjectParameter("Address", address) :
                new ObjectParameter("Address", typeof(string));
    
            var cityParameter = city != null ?
                new ObjectParameter("City", city) :
                new ObjectParameter("City", typeof(string));
    
            var stateParameter = state != null ?
                new ObjectParameter("State", state) :
                new ObjectParameter("State", typeof(string));
    
            var zipCodeParameter = zipCode != null ?
                new ObjectParameter("ZipCode", zipCode) :
                new ObjectParameter("ZipCode", typeof(string));
    
            var countryParameter = country != null ?
                new ObjectParameter("Country", country) :
                new ObjectParameter("Country", typeof(string));
    
            var mobileParameter = mobile != null ?
                new ObjectParameter("Mobile", mobile) :
                new ObjectParameter("Mobile", typeof(string));
    
            var otherEmailAddressParameter = otherEmailAddress != null ?
                new ObjectParameter("OtherEmailAddress", otherEmailAddress) :
                new ObjectParameter("OtherEmailAddress", typeof(string));
    
            var updatedByParameter = updatedBy.HasValue ?
                new ObjectParameter("UpdatedBy", updatedBy) :
                new ObjectParameter("UpdatedBy", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ups_UsersProfile_UpdateByUserID", userIDParameter, firstNameParameter, middleNameParameter, lastNameParameter, workTitleIDParameter, dOJParameter, displayIDParameter, genderParameter, dOBParameter, martialStatusParameter, addressParameter, cityParameter, stateParameter, zipCodeParameter, countryParameter, mobileParameter, otherEmailAddressParameter, updatedByParameter);
        }
    
        public virtual ObjectResult<ups_WorkTitle_GetWorkTitles_Result> ups_WorkTitle_GetWorkTitles()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ups_WorkTitle_GetWorkTitles_Result>("ups_WorkTitle_GetWorkTitles");
        }
    
        public virtual ObjectResult<usp_LeaveType_GetAll_Result> usp_LeaveType_GetAll(Nullable<int> leaveTypeID)
        {
            var leaveTypeIDParameter = leaveTypeID.HasValue ?
                new ObjectParameter("LeaveTypeID", leaveTypeID) :
                new ObjectParameter("LeaveTypeID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_LeaveType_GetAll_Result>("usp_LeaveType_GetAll", leaveTypeIDParameter);
        }
    
        public virtual int usp_LeaveType_Insert(string leaveTypeName, string leaveTypeDescription, string colorCode, Nullable<int> leaveDays, Nullable<System.Guid> createdBy)
        {
            var leaveTypeNameParameter = leaveTypeName != null ?
                new ObjectParameter("LeaveTypeName", leaveTypeName) :
                new ObjectParameter("LeaveTypeName", typeof(string));
    
            var leaveTypeDescriptionParameter = leaveTypeDescription != null ?
                new ObjectParameter("LeaveTypeDescription", leaveTypeDescription) :
                new ObjectParameter("LeaveTypeDescription", typeof(string));
    
            var colorCodeParameter = colorCode != null ?
                new ObjectParameter("ColorCode", colorCode) :
                new ObjectParameter("ColorCode", typeof(string));
    
            var leaveDaysParameter = leaveDays.HasValue ?
                new ObjectParameter("LeaveDays", leaveDays) :
                new ObjectParameter("LeaveDays", typeof(int));
    
            var createdByParameter = createdBy.HasValue ?
                new ObjectParameter("CreatedBy", createdBy) :
                new ObjectParameter("CreatedBy", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_LeaveType_Insert", leaveTypeNameParameter, leaveTypeDescriptionParameter, colorCodeParameter, leaveDaysParameter, createdByParameter);
        }
    
        public virtual int usp_LeaveType_Update(Nullable<int> leaveTypeID, string leaveTypeName, string leaveTypeDescription, string colorCode, Nullable<int> leaveDays, Nullable<bool> isActive, Nullable<System.Guid> updatedBy)
        {
            var leaveTypeIDParameter = leaveTypeID.HasValue ?
                new ObjectParameter("LeaveTypeID", leaveTypeID) :
                new ObjectParameter("LeaveTypeID", typeof(int));
    
            var leaveTypeNameParameter = leaveTypeName != null ?
                new ObjectParameter("LeaveTypeName", leaveTypeName) :
                new ObjectParameter("LeaveTypeName", typeof(string));
    
            var leaveTypeDescriptionParameter = leaveTypeDescription != null ?
                new ObjectParameter("LeaveTypeDescription", leaveTypeDescription) :
                new ObjectParameter("LeaveTypeDescription", typeof(string));
    
            var colorCodeParameter = colorCode != null ?
                new ObjectParameter("ColorCode", colorCode) :
                new ObjectParameter("ColorCode", typeof(string));
    
            var leaveDaysParameter = leaveDays.HasValue ?
                new ObjectParameter("LeaveDays", leaveDays) :
                new ObjectParameter("LeaveDays", typeof(int));
    
            var isActiveParameter = isActive.HasValue ?
                new ObjectParameter("IsActive", isActive) :
                new ObjectParameter("IsActive", typeof(bool));
    
            var updatedByParameter = updatedBy.HasValue ?
                new ObjectParameter("UpdatedBy", updatedBy) :
                new ObjectParameter("UpdatedBy", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_LeaveType_Update", leaveTypeIDParameter, leaveTypeNameParameter, leaveTypeDescriptionParameter, colorCodeParameter, leaveDaysParameter, isActiveParameter, updatedByParameter);
        }
    
        public virtual ObjectResult<usp_Users_GetAllUsers_Result> usp_Users_GetAllUsers(Nullable<bool> isActive)
        {
            var isActiveParameter = isActive.HasValue ?
                new ObjectParameter("IsActive", isActive) :
                new ObjectParameter("IsActive", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_Users_GetAllUsers_Result>("usp_Users_GetAllUsers", isActiveParameter);
        }
    
        public virtual ObjectResult<usp_Users_LoginUserByEmailandPassword_Result> usp_Users_LoginUserByEmailandPassword(string email, string password)
        {
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_Users_LoginUserByEmailandPassword_Result>("usp_Users_LoginUserByEmailandPassword", emailParameter, passwordParameter);
        }
    
        public virtual ObjectResult<usp_Users_UserRoles_ByUserID_Result> usp_Users_UserRoles_ByUserID(Nullable<System.Guid> userID)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_Users_UserRoles_ByUserID_Result>("usp_Users_UserRoles_ByUserID", userIDParameter);
        }
    
        public virtual int usp_UsersEducation_Deactivate(Nullable<int> id, Nullable<System.Guid> updatedBy, Nullable<bool> isActive)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var updatedByParameter = updatedBy.HasValue ?
                new ObjectParameter("UpdatedBy", updatedBy) :
                new ObjectParameter("UpdatedBy", typeof(System.Guid));
    
            var isActiveParameter = isActive.HasValue ?
                new ObjectParameter("IsActive", isActive) :
                new ObjectParameter("IsActive", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_UsersEducation_Deactivate", idParameter, updatedByParameter, isActiveParameter);
        }
    
        public virtual ObjectResult<usp_UsersEducation_GetByID_Result> usp_UsersEducation_GetByID(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_UsersEducation_GetByID_Result>("usp_UsersEducation_GetByID", iDParameter);
        }
    
        public virtual ObjectResult<usp_UsersEducation_GetByUserID_Result> usp_UsersEducation_GetByUserID(Nullable<System.Guid> userID)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_UsersEducation_GetByUserID_Result>("usp_UsersEducation_GetByUserID", userIDParameter);
        }
    
        public virtual int usp_UsersEducation_Insert(Nullable<System.Guid> userID, string institute, string courseSpecialization, Nullable<decimal> gPA, string startPeriod, string endPeriod, string comments, Nullable<System.Guid> createdBy)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(System.Guid));
    
            var instituteParameter = institute != null ?
                new ObjectParameter("Institute", institute) :
                new ObjectParameter("Institute", typeof(string));
    
            var courseSpecializationParameter = courseSpecialization != null ?
                new ObjectParameter("CourseSpecialization", courseSpecialization) :
                new ObjectParameter("CourseSpecialization", typeof(string));
    
            var gPAParameter = gPA.HasValue ?
                new ObjectParameter("GPA", gPA) :
                new ObjectParameter("GPA", typeof(decimal));
    
            var startPeriodParameter = startPeriod != null ?
                new ObjectParameter("StartPeriod", startPeriod) :
                new ObjectParameter("StartPeriod", typeof(string));
    
            var endPeriodParameter = endPeriod != null ?
                new ObjectParameter("EndPeriod", endPeriod) :
                new ObjectParameter("EndPeriod", typeof(string));
    
            var commentsParameter = comments != null ?
                new ObjectParameter("Comments", comments) :
                new ObjectParameter("Comments", typeof(string));
    
            var createdByParameter = createdBy.HasValue ?
                new ObjectParameter("CreatedBy", createdBy) :
                new ObjectParameter("CreatedBy", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_UsersEducation_Insert", userIDParameter, instituteParameter, courseSpecializationParameter, gPAParameter, startPeriodParameter, endPeriodParameter, commentsParameter, createdByParameter);
        }
    
        public virtual int usp_UsersEducation_Update(Nullable<int> id, Nullable<System.Guid> userID, string institute, string courseSpecialization, Nullable<decimal> gPA, string startPeriod, string endPeriod, string comments, Nullable<System.Guid> updatedBy)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(System.Guid));
    
            var instituteParameter = institute != null ?
                new ObjectParameter("Institute", institute) :
                new ObjectParameter("Institute", typeof(string));
    
            var courseSpecializationParameter = courseSpecialization != null ?
                new ObjectParameter("CourseSpecialization", courseSpecialization) :
                new ObjectParameter("CourseSpecialization", typeof(string));
    
            var gPAParameter = gPA.HasValue ?
                new ObjectParameter("GPA", gPA) :
                new ObjectParameter("GPA", typeof(decimal));
    
            var startPeriodParameter = startPeriod != null ?
                new ObjectParameter("StartPeriod", startPeriod) :
                new ObjectParameter("StartPeriod", typeof(string));
    
            var endPeriodParameter = endPeriod != null ?
                new ObjectParameter("EndPeriod", endPeriod) :
                new ObjectParameter("EndPeriod", typeof(string));
    
            var commentsParameter = comments != null ?
                new ObjectParameter("Comments", comments) :
                new ObjectParameter("Comments", typeof(string));
    
            var updatedByParameter = updatedBy.HasValue ?
                new ObjectParameter("UpdatedBy", updatedBy) :
                new ObjectParameter("UpdatedBy", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_UsersEducation_Update", idParameter, userIDParameter, instituteParameter, courseSpecializationParameter, gPAParameter, startPeriodParameter, endPeriodParameter, commentsParameter, updatedByParameter);
        }
    
        public virtual int usp_UsersEmergencyContact_Deactivate(Nullable<int> id, Nullable<System.Guid> updatedBy, Nullable<bool> isActive)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var updatedByParameter = updatedBy.HasValue ?
                new ObjectParameter("UpdatedBy", updatedBy) :
                new ObjectParameter("UpdatedBy", typeof(System.Guid));
    
            var isActiveParameter = isActive.HasValue ?
                new ObjectParameter("IsActive", isActive) :
                new ObjectParameter("IsActive", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_UsersEmergencyContact_Deactivate", idParameter, updatedByParameter, isActiveParameter);
        }
    
        public virtual ObjectResult<usp_UsersEmergencyContact_GetByID_Result> usp_UsersEmergencyContact_GetByID(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_UsersEmergencyContact_GetByID_Result>("usp_UsersEmergencyContact_GetByID", iDParameter);
        }
    
        public virtual ObjectResult<usp_UsersEmergencyContact_GetByUserID_Result> usp_UsersEmergencyContact_GetByUserID(Nullable<System.Guid> userID)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_UsersEmergencyContact_GetByUserID_Result>("usp_UsersEmergencyContact_GetByUserID", userIDParameter);
        }
    
        public virtual int usp_UsersEmergencyContact_Insert(Nullable<System.Guid> userID, string name, string relationship, string mobile, string workMobile, string notes, Nullable<System.Guid> createdBy)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(System.Guid));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var relationshipParameter = relationship != null ?
                new ObjectParameter("Relationship", relationship) :
                new ObjectParameter("Relationship", typeof(string));
    
            var mobileParameter = mobile != null ?
                new ObjectParameter("Mobile", mobile) :
                new ObjectParameter("Mobile", typeof(string));
    
            var workMobileParameter = workMobile != null ?
                new ObjectParameter("WorkMobile", workMobile) :
                new ObjectParameter("WorkMobile", typeof(string));
    
            var notesParameter = notes != null ?
                new ObjectParameter("Notes", notes) :
                new ObjectParameter("Notes", typeof(string));
    
            var createdByParameter = createdBy.HasValue ?
                new ObjectParameter("CreatedBy", createdBy) :
                new ObjectParameter("CreatedBy", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_UsersEmergencyContact_Insert", userIDParameter, nameParameter, relationshipParameter, mobileParameter, workMobileParameter, notesParameter, createdByParameter);
        }
    
        public virtual int usp_UsersEmergencyContact_Update(Nullable<int> id, Nullable<System.Guid> userID, string name, string relationship, string mobile, string workMobile, string notes, Nullable<System.Guid> updatedBy)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(System.Guid));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var relationshipParameter = relationship != null ?
                new ObjectParameter("Relationship", relationship) :
                new ObjectParameter("Relationship", typeof(string));
    
            var mobileParameter = mobile != null ?
                new ObjectParameter("Mobile", mobile) :
                new ObjectParameter("Mobile", typeof(string));
    
            var workMobileParameter = workMobile != null ?
                new ObjectParameter("WorkMobile", workMobile) :
                new ObjectParameter("WorkMobile", typeof(string));
    
            var notesParameter = notes != null ?
                new ObjectParameter("Notes", notes) :
                new ObjectParameter("Notes", typeof(string));
    
            var updatedByParameter = updatedBy.HasValue ?
                new ObjectParameter("UpdatedBy", updatedBy) :
                new ObjectParameter("UpdatedBy", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_UsersEmergencyContact_Update", idParameter, userIDParameter, nameParameter, relationshipParameter, mobileParameter, workMobileParameter, notesParameter, updatedByParameter);
        }
    
        public virtual int usp_UsersExperience_Deactivate(Nullable<int> id, Nullable<System.Guid> updatedBy, Nullable<bool> isActive)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var updatedByParameter = updatedBy.HasValue ?
                new ObjectParameter("UpdatedBy", updatedBy) :
                new ObjectParameter("UpdatedBy", typeof(System.Guid));
    
            var isActiveParameter = isActive.HasValue ?
                new ObjectParameter("IsActive", isActive) :
                new ObjectParameter("IsActive", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_UsersExperience_Deactivate", idParameter, updatedByParameter, isActiveParameter);
        }
    
        public virtual ObjectResult<usp_UsersExperience_GetByID_Result> usp_UsersExperience_GetByID(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_UsersExperience_GetByID_Result>("usp_UsersExperience_GetByID", iDParameter);
        }
    
        public virtual ObjectResult<usp_UsersExperience_GetByUserID_Result> usp_UsersExperience_GetByUserID(Nullable<System.Guid> userID)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_UsersExperience_GetByUserID_Result>("usp_UsersExperience_GetByUserID", userIDParameter);
        }
    
        public virtual int usp_UsersExperience_Insert(Nullable<System.Guid> userID, string workTitle, string company, Nullable<System.DateTime> fromDate, Nullable<System.DateTime> toDate, string comments, Nullable<System.Guid> createdBy)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(System.Guid));
    
            var workTitleParameter = workTitle != null ?
                new ObjectParameter("WorkTitle", workTitle) :
                new ObjectParameter("WorkTitle", typeof(string));
    
            var companyParameter = company != null ?
                new ObjectParameter("Company", company) :
                new ObjectParameter("Company", typeof(string));
    
            var fromDateParameter = fromDate.HasValue ?
                new ObjectParameter("FromDate", fromDate) :
                new ObjectParameter("FromDate", typeof(System.DateTime));
    
            var toDateParameter = toDate.HasValue ?
                new ObjectParameter("ToDate", toDate) :
                new ObjectParameter("ToDate", typeof(System.DateTime));
    
            var commentsParameter = comments != null ?
                new ObjectParameter("Comments", comments) :
                new ObjectParameter("Comments", typeof(string));
    
            var createdByParameter = createdBy.HasValue ?
                new ObjectParameter("CreatedBy", createdBy) :
                new ObjectParameter("CreatedBy", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_UsersExperience_Insert", userIDParameter, workTitleParameter, companyParameter, fromDateParameter, toDateParameter, commentsParameter, createdByParameter);
        }
    
        public virtual int usp_UsersExperience_Update(Nullable<int> id, Nullable<System.Guid> userID, string workTitle, string company, Nullable<System.DateTime> fromDate, Nullable<System.DateTime> toDate, string comments, Nullable<System.Guid> updatedBy)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(System.Guid));
    
            var workTitleParameter = workTitle != null ?
                new ObjectParameter("WorkTitle", workTitle) :
                new ObjectParameter("WorkTitle", typeof(string));
    
            var companyParameter = company != null ?
                new ObjectParameter("Company", company) :
                new ObjectParameter("Company", typeof(string));
    
            var fromDateParameter = fromDate.HasValue ?
                new ObjectParameter("FromDate", fromDate) :
                new ObjectParameter("FromDate", typeof(System.DateTime));
    
            var toDateParameter = toDate.HasValue ?
                new ObjectParameter("ToDate", toDate) :
                new ObjectParameter("ToDate", typeof(System.DateTime));
    
            var commentsParameter = comments != null ?
                new ObjectParameter("Comments", comments) :
                new ObjectParameter("Comments", typeof(string));
    
            var updatedByParameter = updatedBy.HasValue ?
                new ObjectParameter("UpdatedBy", updatedBy) :
                new ObjectParameter("UpdatedBy", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_UsersExperience_Update", idParameter, userIDParameter, workTitleParameter, companyParameter, fromDateParameter, toDateParameter, commentsParameter, updatedByParameter);
        }
    
        public virtual int usp_UsersReporting_DeletetByUserID(Nullable<System.Guid> userID, Nullable<System.Guid> repotingToUserID)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(System.Guid));
    
            var repotingToUserIDParameter = repotingToUserID.HasValue ?
                new ObjectParameter("RepotingToUserID", repotingToUserID) :
                new ObjectParameter("RepotingToUserID", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_UsersReporting_DeletetByUserID", userIDParameter, repotingToUserIDParameter);
        }
    
        public virtual ObjectResult<usp_UsersReporting_GetByRepotingToUserID_Result> usp_UsersReporting_GetByRepotingToUserID(Nullable<System.Guid> repotingToUserID)
        {
            var repotingToUserIDParameter = repotingToUserID.HasValue ?
                new ObjectParameter("RepotingToUserID", repotingToUserID) :
                new ObjectParameter("RepotingToUserID", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_UsersReporting_GetByRepotingToUserID_Result>("usp_UsersReporting_GetByRepotingToUserID", repotingToUserIDParameter);
        }
    
        public virtual ObjectResult<usp_UsersReporting_GetByUserID_Result> usp_UsersReporting_GetByUserID(Nullable<System.Guid> userID)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_UsersReporting_GetByUserID_Result>("usp_UsersReporting_GetByUserID", userIDParameter);
        }
    
        public virtual int usp_UsersReporting_Insert(Nullable<System.Guid> userID, Nullable<System.Guid> repotingToUserID, Nullable<bool> isDirectRepoting, Nullable<System.Guid> createdBy)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(System.Guid));
    
            var repotingToUserIDParameter = repotingToUserID.HasValue ?
                new ObjectParameter("RepotingToUserID", repotingToUserID) :
                new ObjectParameter("RepotingToUserID", typeof(System.Guid));
    
            var isDirectRepotingParameter = isDirectRepoting.HasValue ?
                new ObjectParameter("IsDirectRepoting", isDirectRepoting) :
                new ObjectParameter("IsDirectRepoting", typeof(bool));
    
            var createdByParameter = createdBy.HasValue ?
                new ObjectParameter("CreatedBy", createdBy) :
                new ObjectParameter("CreatedBy", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_UsersReporting_Insert", userIDParameter, repotingToUserIDParameter, isDirectRepotingParameter, createdByParameter);
        }
    }
}
