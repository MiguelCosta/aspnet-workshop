using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogApplication.Models
{
    public class CommentsViewModel
    {
        public CommentsViewModel(Comment c)
        {
            this.Body = c.Body;
        }

        public string Body { get; set; }

    }
}