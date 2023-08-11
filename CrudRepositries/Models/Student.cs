using System.ComponentModel.DataAnnotations;

namespace CrudRepositries.Models
{
    public class Student
    {
        [Key]
        public int id { get; set; }



        [Required (ErrorMessage ="please enter the roll no")]
        public int rollno { get; set; }


        [Required(ErrorMessage = "please enter the name")]
        public string name { get; set; }


        [Required(ErrorMessage = "please enter the student standard")]
        public int standard { get; set; }




        [Required(ErrorMessage = "please enter the student DOB")]
        [RegularExpression(@"^\d{4}-\d{2}-\d{2}$" , ErrorMessage ="invalid format/ valid format is yyyy-mm-dd")]
        public string DOB { get; set; }
       
    }
}
