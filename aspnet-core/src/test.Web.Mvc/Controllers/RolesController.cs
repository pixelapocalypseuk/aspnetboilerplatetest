using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abp.Application.Services.Dto;
using Abp.AspNetCore.Mvc.Authorization;
using test.Authorization;
using test.Controllers;
using test.Roles;
using test.Web.Models.Roles;

namespace test.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Roles)]
    public class RolesController : testControllerBase
    {
        private readonly IRoleAppService _roleAppService;

        public RolesController(IRoleAppService roleAppService)
        {
            _roleAppService = roleAppService;
        }

        public async Task<IActionResult> Index()
        {
            var permissions = (await _roleAppService.GetAllPermissions()).Items;
            var model = new RoleListViewModel
            {
                Permissions = permissions
            };

            return View(model);
        }

        public async Task<ActionResult> EditModal(int roleId)
        {
            var output = await _roleAppService.GetRoleForEdit(new EntityDto(roleId));
            var model = ObjectMapper.Map<EditRoleModalViewModel>(output);

            return PartialView("_EditModal", model);
        }
    }
}
