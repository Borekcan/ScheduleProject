using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{

    public class Meeting : IEntity
    {
        public int MeetingId { get; set; }
        public string MeetingName { get; set; }
        public string HostUser { get; set; }

        public DateTime FirstVote { get; set; }
        public DateTime SecondVote { get; set; }
        public DateTime ThirdVote { get; set; }
        public DateTime FourthVote { get; set; }
        public DateTime FifthVote { get; set; }
        public string MeetingDescription { get; set; }

    }
}
