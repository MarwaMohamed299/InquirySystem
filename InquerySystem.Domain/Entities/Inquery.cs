using InquerySystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InquerySystem.Domain.Entities
{
    public class Inquery
    {
        public int Id { get; set; }
        //public int UserId { get; set; }
        //public User User { get; set; }
        public string Subject { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public InqueryStatus InqueryStatus { get; set; }
    }
}
