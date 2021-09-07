using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MindBehind.InterviewTest.Dto;
using MindBehind.InterviewTest.Localization;
using Volo.Abp.Application.Services;

namespace MindBehind.InterviewTest.Application.Contracts
{
    public interface ICommentAppService : IApplicationService
    {
        Task<List<CommentDto>> GetListAsync();

        Task DeleteAsync(int id);
    }
}
