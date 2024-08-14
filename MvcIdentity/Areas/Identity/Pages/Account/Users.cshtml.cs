using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MvcIdentity.Areas.Identity.Pages.Account;

public class Users : PageModel
{
    public RegisterModel.InputModel Input { get; set; }
    public string ReturnUrl { get; set; }
    
    public void OnGet()
    {
        
    }
}