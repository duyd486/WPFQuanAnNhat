using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MyWPFTest.Models;

[Table("employees")]
public partial class Employee
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("information_id")]
    public int? InformationId { get; set; }

    [Column("role")]
    public int? Role { get; set; }

    [Column("salary")]
    public int? Salary { get; set; }

    //public string? ten { get; set; }
    //public DateOnly? birth { get; set; }
    //public string? gender { get; set; }
    //public string? phone { get; set; }
    //public string? address { get; set; }
    //public int? citizenId { get; set; }

    [ForeignKey("InformationId")]
    [InverseProperty("Employees")]
    public virtual Information? Information { get; set; }

    [InverseProperty("Employee")]
    public virtual ICollection<SalaryBill> SalaryBills { get; set; } = new List<SalaryBill>();
}
