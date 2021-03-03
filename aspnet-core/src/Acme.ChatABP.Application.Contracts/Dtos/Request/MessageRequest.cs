using System;
using System.Collections.Generic;
using System.Text;

namespace Acme.ChatABP.Dtos.Request
{
    public class MessageRequest
    {
        public string SenderName { get; set; }
        public string Content { get; set; }
    }
}
