using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Employeeskillmanagment.Models
{
    public class EmployeeSkill
    {
        public int Id { get; set; }

        public int SkillId { get; set; }
         [ForeignKey("SkillId")]
         [ValidateNever]
        public Skill? Skill { get; set; }

        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        [ValidateNever]
        public Employee? Employee { get; set; }
 
        public string? ExpertLevel { get; set; }

        [Range(1, 50)]
        public int Experience { get; set; }
        public string PrimarySkill { get; set; } = "No";




    }
}