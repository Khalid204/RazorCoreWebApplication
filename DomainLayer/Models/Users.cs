using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace DomainLayer.Models;

public class Users : IdentityUser
{
    public string Name { get; set; }
}
