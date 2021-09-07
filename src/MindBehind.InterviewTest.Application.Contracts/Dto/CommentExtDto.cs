using System;
using System.Collections.Generic;
using System.Text;

namespace MindBehind.InterviewTest.Dto
{
    public class CommentExtDto
    {
        public CommentExtDto()
        {

        }

        public int id { get; set; }
        public int postId { get; set; }
        public string body { get; set; }
    }
}
