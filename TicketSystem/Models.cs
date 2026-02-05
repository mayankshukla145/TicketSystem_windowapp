using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystem
{
    internal class Models
    {
        public class AssignUser
        {
            public string Username { get; set; }
        }

        public class LoginRequest
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }

        public class LoginResponse
        {
            public string UserId { get; set; }
            public string Username { get; set; }
            public string Role { get; set; }
        }

        public class TicketCreateModel
        {
            public string Subject { get; set; }
            public string Description { get; set; }
            public string Priority { get; set; }
            public string CreatedBy { get; set; }
        }
        public class TicketHistory
        {
            public string Action { get; set; }
            public string Comment { get; set; }
            public string UpdatedBy { get; set; }
            public string UpdatedOn { get; set; }
        }

        public class TicketDetailsResponse
        {
            public string TicketNumber { get; set; }
            public string Subject { get; set; }
            public string Description { get; set; }
            public string Priority { get; set; }
            public string Status { get; set; }
            public string Createdat { get; set; }
            public string AssignedTo { get; set; }
            public List<TicketHistory> History { get; set; }
        }
        public class TicketListModel
        {
            public int TicketId { get; set; }
            public string TicketNumber { get; set; }
            public string Subject { get; set; }
            public string Priority { get; set; }
            public string Status { get; set; }
            public string CreatedDate { get; set; }
            public string AssignedTo { get; set; }
        }


    }
}
