using Business.Constants;
using Core.Entity.Concrete;
using Core.Utilities.Abstract;
using Core.Utilities.Concrete;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class MeetingManager
    {

        IMeetingDal _meetingDal;

        public MeetingManager(IMeetingDal meetingDal)
        {
            _meetingDal = meetingDal;
        }


        public IResult Add(Meeting meeting)
        {

            _meetingDal.Add(meeting);
            return new SuccessResult(Messages.SuccessMessage);
        }

        public IResult Update(Meeting meeting)
        {
            var meetingUpdate = _meetingDal.Get(u => u.MeetingId == meeting.MeetingId);
            meetingUpdate.MeetingTime = meeting.MeetingTime;
            meetingUpdate.HostUser = meeting.HostUser;
            meetingUpdate.MeetingPlace = meeting.MeetingPlace;
            _meetingDal.Update(meetingUpdate);
            return new SuccessResult(Messages.SuccessMessage);
        }

        public IResult Delete(Meeting meeting)
        {
            _meetingDal.Delete(meeting);
            return new SuccessResult(Messages.SuccessMessage);
        }

        public IDataResult<List<Meeting>> GetAll()
        {
            return new SuccessDataResult<List<Meeting>>(_meetingDal.GetAll(), Messages.SuccessDataMessage);
        }

        public IDataResult <Meeting> GetByID(int meetingID)
        {
            return new SuccessDataResult<Meeting>(_meetingDal.Get(m => m.MeetingId == meetingID), Messages.SuccessDataMessage);
        }

        public IDataResult <Meeting> GetByHostUser(string hostUser)
        {
            return new SuccessDataResult<Meeting>(_meetingDal.Get(h => h.HostUser == hostUser), Messages.SuccessDataMessage);
        }

        
        
    }
}

