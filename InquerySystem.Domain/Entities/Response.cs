using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InquerySystem.Domain.Entities
{
    public class Response
    {
        public int Id { get; set; }
        public int InquiryId { get; set; }
        public required Inquery Inquery { get; set; }
        //public int ResponderId { get; set; }
        //public User Responder { get; set; }
        public string ResponseContent { get; set; } = string.Empty;
        public DateTime ResponseDate { get; set; }
    }
}
