using Business.Abstract;
using Business.Constants;
using Core.Utilities.Abstract;
using Core.Utilities.Concrete;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class VoteManager : IVoteService
    {
        IVoteDal _voteDal;

        public VoteManager(IVoteDal voteDal)
        {
            _voteDal = voteDal;
        }

        public IResult Add(Vote vote)
        {
            _voteDal.Add(vote);
            return new SuccessResult(Messages.SuccessMessage);
        }

        public IResult Update(Vote vote)
        {
            var voteUpdate = _voteDal.Get(u => u.VoteId == vote.VoteId);
            vote.VoteOneCount = voteUpdate.VoteOneCount;
            vote.VoteTwoCount = voteUpdate.VoteTwoCount;
            vote.VoteThreeCount = voteUpdate.VoteThreeCount;
            vote.VoteFourCount = voteUpdate.VoteFourCount;
            vote.VoteFiveCount = voteUpdate.VoteFiveCount;
            _voteDal.Update(voteUpdate);
            return new SuccessResult(Messages.SuccessMessage);
        }

        public IResult Delete(Vote vote)
        {
            _voteDal.Delete(vote);
            return new SuccessResult(Messages.SuccessMessage);
        }

        public IDataResult<List<Vote>> GetAll()
        {
            return new SuccessDataResult<List<Vote>>(_voteDal.GetAll(), Messages.SuccessDataMessage);
        }

        public IDataResult<Vote> GetByID(int voteId)
        {
            return new SuccessDataResult<Vote>(_voteDal.Get(m => m.VoteId == voteId), Messages.SuccessDataMessage);
        }

        public IResult VoteOne(Vote vote)
        {
            var voteOne = _voteDal.Get(u => u.VoteId == vote.VoteId);
            voteOne.VoteOneCount++;
            _voteDal.Update(voteOne);
            return new SuccessResult(Messages.SuccessMessage);
        }
        public IResult VoteTwo(Vote vote)
        {
            var voteTwo = _voteDal.Get(u => u.VoteId == vote.VoteId);
            voteTwo.VoteTwoCount++;
            _voteDal.Update(voteTwo);
            return new SuccessResult(Messages.SuccessMessage);
        }
        public IResult VoteThree(Vote vote)
        {
            var voteThree = _voteDal.Get(u => u.VoteId == vote.VoteId);
            voteThree.VoteThreeCount++;
            _voteDal.Update(voteThree);
            return new SuccessResult(Messages.SuccessMessage);
        }
        public IResult VoteFour(Vote vote)
        {
            var voteFour = _voteDal.Get(u => u.VoteId == vote.VoteId);
            voteFour.VoteFourCount++;
            _voteDal.Update(voteFour);
            return new SuccessResult(Messages.SuccessMessage);
        }
        public IResult VoteFive(Vote vote)
        {
            var voteFive = _voteDal.Get(u => u.VoteId == vote.VoteId);
            voteFive.VoteFiveCount++;
            _voteDal.Update(voteFive);
            return new SuccessResult(Messages.SuccessMessage);
        }
    }
}
