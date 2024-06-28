using System.ComponentModel.DataAnnotations;
namespace TechJobs6Persistent.ViewModels
{
    public class AddEmployerViewModel
    {
        [Required(ErrorMessage = "Missing Name.")]
        public string Name { get; set;  }


        [Required(ErrorMessage = "Missing Location.")]
        public string Location { get; set; }
    }
}
