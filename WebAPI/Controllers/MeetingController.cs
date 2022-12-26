using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeetingController :ControllerBase
    {

        IMeetingService _meetingService;

        public MeetingController(IMeetingService meetingService)
        {
            _meetingService = meetingService;
        }

        [HttpPost("meeting-create")]
        public ActionResult MeetingCreate(Meeting meeting)
        {
            var result = _meetingService.Add(meeting);
            if (result.Success)
            {
                return Ok(result);
             
            }
            else
            {
                return BadRequest(result);
            }
        }
        
        [HttpPost("meeting-delete")]
        public ActionResult MeetingDelete(Meeting meeting)
        {
            var result = _meetingService.Delete(meeting);
            if (result.Success)
            {
                return Ok(result);

            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpPost("meeting-update")]
        public ActionResult MeetingUpdate(Meeting meeting)
        {
            var result = _meetingService.Delete(meeting);
            if (result.Success)
            {
                return Ok(result);

            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpGet("meeting-getbyid")]
        public ActionResult MeetingGetByID(int id)
        {
            var result = _meetingService.GetByID(id);
            if (result.Success)
            {
                return Ok(result);

            }
            else
            {
                return BadRequest(result);
            }
        }
        
        [HttpGet("meeting-getbyhostuser")]
        public ActionResult MeetingGetByHostUser(string name)
        {
            var result = _meetingService.GetByHostUser(name);
            if (result.Success)
            {
                return Ok(result);

            }
            else
            {
                return BadRequest(result);
            }
        }
        [HttpGet("meeting-getalldto")]
        public ActionResult GetMeetingDto()
        {
            var result = _meetingService.GetAllMeetingDTO();
            if (result.Success)
            {
                return Ok(result);

            }
            else
            {
                return BadRequest(result);
            }
        }
    }
}
