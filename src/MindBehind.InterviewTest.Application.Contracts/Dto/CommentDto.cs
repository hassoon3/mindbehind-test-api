using System;
using System.Collections.Generic;
using System.Text;

namespace MindBehind.InterviewTest.Dto
{
    public class CommentDto
    {
        public CommentDto()
        {

        }
        public int Id { get; set; }
        public int PostId { get; set; }
        public string Body { get; set; }
    }
}
