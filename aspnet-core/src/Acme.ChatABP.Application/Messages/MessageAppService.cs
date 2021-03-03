using Acme.ChatABP.Books;
using Acme.ChatABP.Dtos.Request;
using Acme.ChatABP.Dtos.Response;
using Acme.ChatABP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Acme.ChatABP.Messages
{
    public class MessageAppService : CrudAppService<Message, MessageRequest, MessageDto>, IMessageAppServices
    {
       
    }
}
