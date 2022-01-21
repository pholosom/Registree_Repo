using System.ComponentModel.DataAnnotations;
namespace Registree.Models
{
    public class Student
    {
        [Key]
        public string student_id{get;set;}
        
        [Required]
        public string university{get;set;}

        public string name{get;set;}

         public int mark{get;set;}
    }
}