using Core.Utilities.Abstract;
using Core.Utilities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IVoteService
    {
        IResult Add(Vote vote);
        IResult Update(Vote vote);
        IResult Delete(Vote vote);
        IDataResult<List<Vote>> GetAll();
        IDataResult<Vote> GetByID(int voteID);
        IResult VoteOK(Vote vote);
        IResult VoteDeny(Vote vote);
    }
}
