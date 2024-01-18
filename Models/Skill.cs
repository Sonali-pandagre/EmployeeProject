using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Employeeskillmanagment.Models
{
    public class Skill
    {
        [Key]
        public int Id { get; set; }

        public string? SkillName { get; set; }

    }
}