using MindBehind.InterviewTest.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MindBehind.InterviewTest.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class InterviewTestController : AbpController
    {
        protected InterviewTestController()
        {
            LocalizationResource = typeof(InterviewTestResource);
        }
    }
}