using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class MeetingForGetDto : IDto
    {
        public int MeetingId { get; set; }
        public string MeetingName { get; set; }
        public string HostUser { get; set; }

    }
}
