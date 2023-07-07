using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst
{
    internal class Student
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)] 
        public Int32 Student_Id { get; set; }
        public string Student_Name { get; set; }
        public Int16 Student_Age { get; set; }

    }
}
