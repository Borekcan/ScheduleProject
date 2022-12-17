using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Vote
    {

        public int VoteId { get; set; }
        public int Deny { get; set; }
        public int OK { get; set; }

    }
}
