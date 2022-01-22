using System.Collections.Generic;
using test.Roles.Dto;

namespace test.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}