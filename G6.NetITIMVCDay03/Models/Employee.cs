using System.ComponentModel.DataAnnotations.Schema;

namespace G6.NetITIMVCDay03.Models
{
    // PK
    // EmployeeId => Valid
    // Id => Valid
    // EmpId => XXXX Not Valid Must use [Key]
    public class Employee
    {
        /*-----------------------------------------------------*/
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        [Column(TypeName = "decimal(8,2)")]   // Total 8, After 2 => 123456.78
        public decimal Salary { get; set; }
        /*-----------------------------------------------------*/
        // One To Many
        // Employee Assinged to one Department
        // Department have Many  Employees
        // Valid FK => ClassNameId
        // DeptId => 
        //[ForeignKey("Department")]
        public int DepartmentId { get; set; }
        //[ForeignKey("DeptId")]
        public virtual Department? Department { get; set; }
        /*-----------------------------------------------------*/
    }
}
