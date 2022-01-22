using System.Collections.Generic;
using test.Roles.Dto;

namespace test.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
