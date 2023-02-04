using RazorCoreWebApplication.Models.GeneralDto;

namespace RazorCoreWebApplication.ViewModels
{
    public class AdministrationViewModel
    {
        public AdministrationViewModel()
        {
            Users = new List<UsersDto>();
            Roles = new List<RolesDto>();
        }
        public UsersDto User { get; set; }
        public List<UsersDto> Users { get; set; }
        public RolesDto Role { get; set; }
        public List<RolesDto> Roles { get; set; }
    }
}
