using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Day12.Models
{
    public class Information
    {
        //    [Key]
        //    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //    public int Id { get; set; }
        //    public string AddressDetail { get; set; }
        //    [ForeignKey("EmployeeId")]
        //    public Employee Employee { get; set; }

        //    public int EmployeeId { get; set; }
        //}
        public int Id { get; set; }

        public string Name { get; set; }

        public string License { get; set; }

        public DateTime Establshied { get; set; }

        public decimal Revenue { get; set; }
    }
    }
