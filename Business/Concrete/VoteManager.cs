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
            voteUpdate.OK = vote.OK;
            voteUpdate.Deny = vote.Deny;
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

        public IResult VoteOK(Vote vote)
        {
            var voteOK = _voteDal.Get(u => u.VoteId == vote.VoteId);
            voteOK.OK = vote.OK++;
            voteOK.Deny = vote.Deny;
            _voteDal.Update(voteOK);
            return new SuccessResult(Messages.SuccessMessage);
        }

        public IResult VoteDeny(Vote vote)
        {
            var voteDeny = _voteDal.Get(u => u.VoteId == vote.VoteId);
            voteDeny.Deny = vote.Deny++;
            voteDeny.OK = vote.OK;
            _voteDal.Update(voteDeny);
            return new SuccessResult(Messages.SuccessMessage);
        }
    }
}
