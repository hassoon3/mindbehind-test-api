using MindBehind.InterviewTest.Application.Contracts;
using MindBehind.InterviewTest.Dto;
using NSubstitute;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Volo.Abp.Settings;
using MindBehind.InterviewTest.Settings;
using Microsoft.Extensions.DependencyInjection;

namespace MindBehind.InterviewTest
{
    public class CommentAppServiceTests : InterviewTestApplicationTestBase
    {
        private string baseUrl;
        private string resPath;
        private string testBody;

        private readonly ICommentAppService _commentAppService;
        private IExternalAPIAppService _externalAPIAppService;

        public CommentAppServiceTests()
        {

            _commentAppService = GetRequiredService<CommentAppService>();
        }

        protected override void AfterAddApplication(IServiceCollection services)
        {
            baseUrl = "https://my-json-server.typicode.com";
            resPath = "typicode/demo/comments";
            testBody = Guid.NewGuid().ToString();

            _externalAPIAppService = Substitute.For<IExternalAPIAppService>();
            _externalAPIAppService.FetchJson<List<CommentExtDto>>(baseUrl, resPath)
                .Returns(Task.FromResult(new List<CommentExtDto>
                {
                    new CommentExtDto{ id = 1, postId = 1, body = testBody }
                }));

            services.AddSingleton(_externalAPIAppService);

            base.AfterAddApplication(services);
        }

        [Fact]
        public async Task Comment_Service_must_call_correct_external_webapi()
        {
            //Act
            var result = await _commentAppService.GetListAsync();

            //Assert
            result.ShouldNotBeNull().ShouldNotBeEmpty();
            var first = result.First();
            first.ShouldNotBeNull();
            first.Body.ShouldBe(testBody);
        }
    }
}
