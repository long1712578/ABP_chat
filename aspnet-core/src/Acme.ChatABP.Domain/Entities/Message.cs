using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.ChatABP.Entities
{
    public class Message
    {
        public int Id { get; set; }
        public string SenderName { get; set; }
        public string Content { get; set; }
        public DateTime TimeStamp { get; set; }

    }
}
