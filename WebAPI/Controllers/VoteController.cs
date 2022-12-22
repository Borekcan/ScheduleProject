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

       /* [HttpPost("vote-update")]
        public ActionResult VoteUpdate(Vote vote)
        {
            var result = _voteService.Update(vote);
            if (result.Success)
            {
                return Ok(result);

            }
            else
            {
                return BadRequest(result);
            }
        }*/

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

        [HttpPost("vote-one")]
        public ActionResult VoteOne(Vote vote)
        {
            var result = _voteService.VoteOne(vote);
            if (result.Success)
            {
                return Ok(result);

            }
            else
            {
                return BadRequest(result);
            }
        }
        
        [HttpPost("vote-two")]
        public ActionResult VoteTwo(Vote vote)
        {
            var result = _voteService.VoteTwo(vote);
            if (result.Success)
            {
                return Ok(result);

            }
            else
            {
                return BadRequest(result);
            }
        }
        
        [HttpPost("vote-three")]
        public ActionResult VoteThree(Vote vote)
        {
            var result = _voteService.VoteThree(vote);
            if (result.Success)
            {
                return Ok(result);

            }
            else
            {
                return BadRequest(result);
            }
        }
        
        [HttpPost("vote-four")]
        public ActionResult VoteFour(Vote vote)
        {
            var result = _voteService.VoteFour(vote);
            if (result.Success)
            {
                return Ok(result);

            }
            else
            {
                return BadRequest(result);
            }
        }
        
        [HttpPost("vote-five")]
        public ActionResult VoteFive(Vote vote)
        {
            var result = _voteService.VoteFive(vote);
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
