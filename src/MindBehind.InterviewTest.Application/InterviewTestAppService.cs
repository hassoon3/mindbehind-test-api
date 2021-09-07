using System;
using System.Collections.Generic;
using System.Text;
using MindBehind.InterviewTest.Localization;
using Volo.Abp.Application.Services;

namespace MindBehind.InterviewTest
{
    /* Inherit your application services from this class.
     */
    public abstract class InterviewTestAppService : ApplicationService
    {
        protected InterviewTestAppService()
        {
            LocalizationResource = typeof(InterviewTestResource);
        }
    }
}
