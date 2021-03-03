using System;
using System.Collections.Generic;
using System.Text;

namespace Acme.ChatABP.Dtos.Response
{
    public class MessageDto
    {
        public string SenderName { get; set; }
        public string Content { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
