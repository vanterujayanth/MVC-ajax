﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Mvc_Ajax.Entity
{
    public class Employee
    {


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public double Salary { get; set; }
    }
}
