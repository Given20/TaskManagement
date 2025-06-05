using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TaskManagement.Models
{
    public class Task
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        [Required]
        public bool IsCompleted { get; set; }

        public DateTime CreatedDate { get; set; }

    }
}