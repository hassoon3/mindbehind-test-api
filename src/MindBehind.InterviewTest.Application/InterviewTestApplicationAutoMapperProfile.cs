using AutoMapper;
using MindBehind.InterviewTest.Dto;

namespace MindBehind.InterviewTest
{
    public class InterviewTestApplicationAutoMapperProfile : Profile
    {
        public InterviewTestApplicationAutoMapperProfile()
        {
            CreateMap<CommentExtDto, CommentDto>();
        }
    }
}
