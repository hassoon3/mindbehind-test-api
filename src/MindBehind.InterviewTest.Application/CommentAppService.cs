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
    /* Inherit your application services from this class.
     */
    public class CommentAppService : InterviewTestAppService, ICommentAppService
    {
        public CommentAppService() : base()
        {

        }

        public async Task<List<CommentDto>> GetListAsync()
        {
            try
            {
                var client = new RestClient("https://my-json-server.typicode.com");
                var request = new RestRequest("typicode/demo/comments", DataFormat.Json);
                var data = await client.GetAsync<List<CommentExtDto>>(request);

                var result = ObjectMapper.Map<List<CommentExtDto>, List<CommentDto>>(data);

                return result;
            }
            catch (Exception ex)
            {
                throw new BusinessException("CommentAppService.GetListAsync", "Error fetching comments", innerException : ex, logLevel : LogLevel.Error);
            }
            

            //return await Task.FromResult(new List<CommentDto> { 
            //    new CommentDto { Id = 1, PostId = 1, Body = "hasan" }
            //});
        }

        public Task DeleteAsync(int id)
        {
            throw new BusinessException("CommentAppService.DeleteAsync", "DELETE method is not yet implemented");
        }
    }
}
