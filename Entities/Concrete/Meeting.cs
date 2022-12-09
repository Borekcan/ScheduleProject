using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{

    public class Meeting : IEntity
    {

        public int MeetingId { get; set; }
        public DateTime MeetingTime { get; set; }
        public string HostUser { get; set; }
        public string MeetingPlace { get; set; }

    }
}
