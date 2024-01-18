using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Razor;
namespace Employeeskillmanagment.Models

{
    public class Employee
    {

        public int Id{get; set;}
        public string? FirstName { get; set; }
        public string LastName{get; set;}= " ";
         public string Designation{get; set;}= " ";
         public string Email{get; set;}= " ";
         public DateOnly DOJ{get; set;}

        public  List<EmployeeSkill> ?EmployeeSkills { get; set; }
    }
}