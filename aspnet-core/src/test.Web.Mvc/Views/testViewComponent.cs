using Abp.AspNetCore.Mvc.ViewComponents;

namespace test.Web.Views
{
    public abstract class testViewComponent : AbpViewComponent
    {
        protected testViewComponent()
        {
            LocalizationSourceName = testConsts.LocalizationSourceName;
        }
    }
}
