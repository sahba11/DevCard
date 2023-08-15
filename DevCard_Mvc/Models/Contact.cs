using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevCard_Mvc.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "این فیلد اجباری است")]
        [MinLength(3,ErrorMessage = "حداقل طول نام 3 کاراکتر است")]
       [MaxLength(100,ErrorMessage = "حداکثر طول نام 100 کاراکتر است")]
        public string Name { get; set; }
        [Required(ErrorMessage = "این فیلد اجباری است")]
        [EmailAddress(ErrorMessage = "مفدار وارد شده صحیح نمی باشد")]
        public string Email { get; set; }
        public string Message { get; set; }  
        public  int Service { get; set; }
        public SelectList Services  { get; set; }      
    }
}
