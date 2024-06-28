using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using TechJobs6Persistent.Models;

namespace TechJobs6Persistent.ViewModels;

public class AddJobViewModel
{
    [Required(ErrorMessage = "Name is Missing.")]
    public string Name { get; set; }
    [Required(ErrorMessage = "Employer is Missing.")]
    public int EmployerId { get; set; }
    public List<SelectListItem> Employers { get; set; }

    public AddJobViewModel()
    {
        Employers = new List<SelectListItem>();
    }

}