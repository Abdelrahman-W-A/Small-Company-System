﻿ using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.DAL.Models.Shared;

namespace Demo.BLL.Data_Transfer_Objects__DTOs_.EmployeeDTOs
{
    public class UpdatedmployeeDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Address { get; set; }
        public bool IsActive { get; set; }
        public decimal Salary { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateOnly HiringDate { get; set; }
        public EmployeeGender gender { get; set; }
        public EmployeeType EmployeeType { get; set; }
        public int CreatedBy { get; set; }
        public int LastModifiedBy { get; set; }
        public int? DepartmentID { get; set; }
    }
}
