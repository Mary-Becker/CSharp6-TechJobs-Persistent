using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using TechJobs6Persistent.Models;

namespace TechJobs6Persistent.ViewModels;

public class AddJobViewModel
{
    [Required(ErrorMessage = "Job Name Missing.")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Employer Missing.")]
    public int EmployerId { get; set; }
    public List<SelectListItem>? Employers { get; set; }

    public AddJobViewModel() { }

    public AddJobViewModel(List<Employer> employerList)
    {
        Employers = new List<SelectListItem>();

        foreach (Employer employers in employerList)
        {
            Employers.Add(
                new SelectListItem 
                { 
                    Value = employers.Id.ToString(), Text = employers.Name 
                });
        }
    }
}