using Core.Entity.Concrete;
using Core.Utilities.Abstract;
using Core.Utilities;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IMeetingService
    {

        IResult Add(Meeting meeting);
        //IResult Update(Meeting meeting);
        IResult Delete(Meeting meeting);
        IDataResult <List<Meeting>> GetAll();
        IDataResult <Meeting> GetByID(int meetingID);
        IDataResult <Meeting> GetByHostUser(string hostUser);
        IDataResult<List<MeetingForGetDto>> GetMeetingDTO(string hostUser);

    }
}
