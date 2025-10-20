using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingSharp.Application.DTOs
{
    public class AppealDTO
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public string? Status { get; set; }
        public int UserId { get; set; }
        public string? UserName { get; set; }
    }

    public class AppealCreateDTO
    {
        public string? Description { get; set; }
    }


    public class UpdateAppealDTO
    {
        public string? Status { get; set; }
    }
}
