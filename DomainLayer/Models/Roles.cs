using Microsoft.AspNetCore.Identity;
namespace DomainLayer.Models;

public partial class Roles : IdentityRole
{ 
    public string Description { get; set; }
}
