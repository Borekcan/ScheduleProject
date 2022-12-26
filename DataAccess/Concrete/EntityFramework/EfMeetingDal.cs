using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfMeetingDal : IEfEntityRepositoryBase<Meeting, ReCapProjectDBContext>, IMeetingDal
    {

        public List<MeetingForGetDto> GetMeetingDTO(Expression<Func<MeetingForGetDto, bool>> filter = null)
        {
            using (ReCapProjectDBContext context = new ReCapProjectDBContext())
            {
                var resultList = from meeting in context.Meetings

                                 select new MeetingForGetDto { 
                                     MeetingName = meeting.MeetingName ,
                                     MeetingId = meeting.MeetingId ,
                                     HostUser = meeting.HostUser};

                return filter == null ? resultList.ToList() : resultList.Where(filter).ToList();


            }
        }
    }
}

