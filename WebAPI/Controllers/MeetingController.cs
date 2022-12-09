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
    }
}
