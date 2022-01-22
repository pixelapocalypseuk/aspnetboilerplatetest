using System.Collections.Generic;
using test.Roles.Dto;

namespace test.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
