erDiagram
      
"dbo.__EFMigrationsHistory" {
    nvarchar(150) MigrationId "PK"
          nvarchar(32) ProductVersion ""
          
}
"dbo.Company" {
    int CompanyId "PK"
          int RegistryNumber ""
          nvarchar(20) Name ""
          nvarchar(100) Address ""
          nvarchar(20) ContactPerson ""
          int ContactPhoneNumber ""
          nvarchar(30) ContactEmail ""
          nvarchar(100) Comment ""
          
}
"dbo.Hint" {
    int HintId "PK"
          nvarchar(25) Topic ""
          nvarchar(1000) Description ""
          bit Anonymous ""
          nvarchar(100) Comment ""
          
}
"dbo.BranchOffice" {
    int BranchOfficeId "PK"
          int CompanyId "FK"
          int RegistryNumber ""
          nvarchar(20) Name ""
          nvarchar(100) Address ""
          nvarchar(20) ContactPerson ""
          int ContactPhoneNumber ""
          nvarchar(30) ContactEmail ""
          nvarchar(100) Comment ""
          
}
"dbo.Department" {
    int DepartmentId "PK"
          int BranchOfficeId "FK"
          nvarchar(100) Address ""
          nvarchar(20) ContactPerson ""
          int ContactPhoneNumber ""
          nvarchar(30) ContactEmail ""
          nvarchar(100) Comment ""
          
}
"dbo.AccessLevel" {
    int AccessLevelId "PK"
          int EmployeeId "FK"
          int Level ""
          nvarchar(30) Description ""
          nvarchar(30) AccessType ""
          nvarchar(100) Comment ""
          
}
"dbo.BorrowedItems" {
    int BorrowedItemId "PK"
          int EmployeeId "FK"
          nvarchar(30) ItemName ""
          datetime2 BorrowDate ""
          datetime2 ReturnDate ""
          nvarchar(100) Comment ""
          
}
"dbo.Employees" {
    int EmployeeId "PK"
          nvarchar(20) FirstName ""
          nvarchar(20) LastName ""
          int PersonalIdentificationNumber ""
          nvarchar(100) ContactAddress ""
          int ContactPhoneNumber ""
          nvarchar(30) ContactEmail ""
          datetime2 AtWorkSince ""
          datetime2 AtWorkUntil ""
          decimal Salary ""
          nvarchar(100) Comment ""
          int DepartmentId "FK"
          int JobTitleId "FK"
          
}
"dbo.EmployeesChild" {
    int EmployeesChildId "PK"
          int EmployeeId "FK"
          nvarchar(20) FirstName ""
          nvarchar(20) LastName ""
          int Age ""
          nvarchar(100) Comment ""
          
}
"dbo.HealthCheck" {
    int HealthCheckId "PK"
          int EmployeeId "FK"
          datetime2 Date ""
          nvarchar(300) Result ""
          nvarchar(100) Comment ""
          
}
"dbo.Request" {
    int RequestId "PK"
          nvarchar(30) Topic ""
          nvarchar(300) Description ""
          int EmployeeId "FK"
          nvarchar(30) State ""
          nvarchar(30) Recipient ""
          nvarchar(100) Comment ""
          
}
"dbo.SickLeave" {
    int SickLeaveId "PK"
          int EmployeeId "FK"
          datetime2 StartDate ""
          datetime2 EndDate ""
          nvarchar(100) Comment ""
          
}
"dbo.Vacation" {
    int VacationId "PK"
          int EmployeeId "FK"
          datetime2 StartDate ""
          datetime2 EndDate ""
          nvarchar(100) Comment ""
          
}
"dbo.WorkTime" {
    int WorkTimeId "PK"
          int EmployeeId "FK"
          datetime2 StartingDate ""
          datetime2 EndingDate ""
          nvarchar(100) Comment ""
          
}
"dbo.JobTitle" {
    int JobTitleId "PK"
          nvarchar(30) Title ""
          nvarchar(30) Description ""
          decimal SalaryLevel ""
          nvarchar(100) Comment ""
          int WorkTimeId "FK"
          
}
      "dbo.BranchOffice" ||--|{ "dbo.Company": "CompanyId"
"dbo.Department" ||--|{ "dbo.BranchOffice": "BranchOfficeId"
"dbo.AccessLevel" ||--|{ "dbo.Employees": "EmployeeId"
"dbo.BorrowedItems" ||--|{ "dbo.Employees": "EmployeeId"
"dbo.Employees" ||--|{ "dbo.Department": "DepartmentId"
"dbo.Employees" |o--|{ "dbo.JobTitle": "JobTitleId"
"dbo.EmployeesChild" ||--|{ "dbo.Employees": "EmployeeId"
"dbo.HealthCheck" ||--|{ "dbo.Employees": "EmployeeId"
"dbo.Request" ||--|{ "dbo.Employees": "EmployeeId"
"dbo.SickLeave" ||--|{ "dbo.Employees": "EmployeeId"
"dbo.Vacation" ||--|{ "dbo.Employees": "EmployeeId"
"dbo.WorkTime" ||--|{ "dbo.Employees": "EmployeeId"
"dbo.JobTitle" ||--|{ "dbo.WorkTime": "WorkTimeId"
