using PHH.ReverseLOS.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace PHH.ReverseLOS.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class ReverseLOSController : AbpController
    {
        protected ReverseLOSController()
        {
            LocalizationResource = typeof(ReverseLOSResource);
        }
    }
}