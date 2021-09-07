using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MindBehind.InterviewTest.Application.Contracts;
using MindBehind.InterviewTest.Dto;
using MindBehind.InterviewTest.Localization;
using Volo.Abp;
using RestSharp;
using System.Linq;
using Microsoft.Extensions.Logging;

namespace MindBehind.InterviewTest
{
    [RemoteService(IsEnabled = false, IsMetadataEnabled = false)]
    public class ExternalAPIAppService : InterviewTestAppService, IExternalAPIAppService
    {
        public ExternalAPIAppService() : base()
        {

        }

        public async Task<T> FetchJson<T>(string baseUrl, string resourcePath)
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest(resourcePath, DataFormat.Json);
            var result = await client.GetAsync<T>(request);

            return result;
        }
    }
}
