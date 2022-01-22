using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace test.Web.Views
{
    public abstract class testRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected testRazorPage()
        {
            LocalizationSourceName = testConsts.LocalizationSourceName;
        }
    }
}
