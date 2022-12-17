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
    public class VoteController : ControllerBase
    {
        IVoteService _voteService;

        public VoteController(IVoteService voteService)
        {
            _voteService = voteService;
        }

        [HttpPost("vote-create")]
        public ActionResult VoteCreate(Vote vote)
        {
            var result = _voteService.Add(vote);
            if (result.Success)
            {
                return Ok(result);

            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpPost("vote-delete")]
        public ActionResult VoteDelete(Vote vote)
        {
            var result = _voteService.Delete(vote);
            if (result.Success)
            {
                return Ok(result);

            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpPost("vote-update")]
        public ActionResult VoteUpdate(Vote vote)
        {
            var result = _voteService.Delete(vote);
            if (result.Success)
            {
                return Ok(result);

            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpPost("vote-getbyid")]
        public ActionResult VoteGetByID(int id)
        {
            var result = _voteService.GetByID(id);
            if (result.Success)
            {
                return Ok(result);

            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpPost("vote-OK")]
        public ActionResult VoteOK(Vote vote)
        {
            var result = _voteService.VoteOK(vote);
            if (result.Success)
            {
                return Ok(result);

            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpPost("vote-deny")]
        public ActionResult VoteDeny(Vote vote)
        {
            var result = _voteService.VoteDeny(vote);
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
