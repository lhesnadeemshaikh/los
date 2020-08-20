using System;
using System.Collections.Generic;
using System.Text;
using PHH.ReverseLOS.Localization;
using Volo.Abp.Application.Services;

namespace PHH.ReverseLOS
{
    /* Inherit your application services from this class.
     */
    public abstract class ReverseLOSAppService : ApplicationService
    {
        protected ReverseLOSAppService()
        {
            LocalizationResource = typeof(ReverseLOSResource);
        }
    }
}
