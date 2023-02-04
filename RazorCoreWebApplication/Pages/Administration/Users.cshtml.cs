using DomainLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorCoreWebApplication.ViewModels;

namespace RazorCoreWebApplication.Pages.Administration
{
    public class UsersModel : PageModel
    {
        private readonly UserManager<Users> userManager;
        private readonly RoleManager<Roles> roleManager;

        public UsersModel(UserManager<Users> userManager, RoleManager<Roles> roleManager)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

        [BindProperty(SupportsGet =true)]
        public AdministrationViewModel UserDetails { get; set; }

        public void OnGet()
        {
            var User = userManager.Users.ToList();
            //UserDetails.Users = userManager.Users.Select(u => new UsersDto
            //{
            //    Id = u.Id,
            //    Name = u.Name,
            //    Email = u.Email
            //}).ToList();
        }
    }
}
