using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Vote : IEntity
    {

        public int VoteId { get; set; }
        public bool VoteOne { get; set; }
        public int VoteOneCount { get; set; }
        public bool VoteTwo { get; set; }
        public int VoteTwoCount { get; set; }
        public bool VoteThree { get; set; }
        public int VoteThreeCount { get; set; }
        public bool VoteFour { get; set; }
        public int VoteFourCount { get; set; }
        public bool VoteFive { get; set; }
        public int VoteFiveCount { get; set; }
    }
}
