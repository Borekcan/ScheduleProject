using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Vote : IEntity
    {

        public int VoteId { get; set; }

        public int VoteOneCount { get; set; }
        
        public int VoteTwoCount { get; set; }
        
        public int VoteThreeCount { get; set; }
        
        public int VoteFourCount { get; set; }
        
        public int VoteFiveCount { get; set; }
    }
}
