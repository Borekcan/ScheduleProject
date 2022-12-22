using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{

    public class Meeting : IEntity
    {
        public string MeetingName { get; set; }
        public int MeetingId { get; set; }
        public string MeetingName { get; set; }
        public string HostUser { get; set; }

        public string FirstVoteTime { get; set; }
        public string FirstVotePlace { get; set; }

        public string SecondVoteTime { get; set; }
        public string SecondVotePlace { get; set; }

        public string ThirdVoteTime { get; set; }
        public string ThirdVotePlace { get; set; }

        public string FourthVoteTime { get; set; }
        public string FourthVotePlace { get; set; }

        public string FifthVoteTime { get; set; }
        public string FifthVotePlace { get; set; }

    }
}
