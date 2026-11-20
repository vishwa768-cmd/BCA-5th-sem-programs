using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace ASP.Pages;
public class IndexModel : PageModel
{
 [BindProperty]
 public string? StudentName { get; set; }
 [BindProperty]
 public int Age { get; set; }
 public void OnPost()
 {
 }
}
