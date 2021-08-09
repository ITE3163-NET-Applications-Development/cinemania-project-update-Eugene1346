using System.ComponentModel.DataAnnotations;

namespace CineMania.Models
{
    public class Message
    {
      [Key]
              public int Id { get; set; }
              [Required(ErrorMessage = "Your Name Is Required"), MaxLength(60,
                   ErrorMessage = "Your Name Can't Go Beyond 60 Characters")]
              public string Name { get; set; }
              [Required(ErrorMessage = "Please Provide Your Email")]
              public string Email { get; set; }
              [Required(ErrorMessage = "Please Select Subject From Dropdown")]
              public string Subject { get; set; }
              [Required(ErrorMessage = "Please Provide The Body Of Message"), 
               MaxLength(500, ErrorMessage = "Check Your Message You Can't Exceed 500 Characters")]
              public string Body { get; set; }
          }
}