using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CategoryManager.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string  Description{ get; set; }
        public DateTime CreateDate { get; set; }
        public bool Status{ get; set; }
    }
}
