using System;
using System.Collections.Generic;
using System.Web.Http;
using Luxfacta.Enquete.Application.Interfaces;
using Luxfacta.Enquete.Application.ViewModels;
using System.Net;


namespace Luxfacta.Enquete.Services.REST.EnqueteAPI.Controllers
{
    public class PollController : ApiController
    {
        private readonly IEnqueteAppService _enqueteAppService;
        public PollController(IEnqueteAppService enqueteAppService)
        {
            _enqueteAppService = enqueteAppService;
        }

        // GET: api/poll/5
        [Route("api/poll/{id:int}")]
        public IHttpActionResult Get(int id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var objReturn = _enqueteAppService.ObterEnquetePorId(id);
            if (objReturn == null)
                return NotFound();
            else
                _enqueteAppService.AdicionarVisualizacao(id);
                return Ok(objReturn); 
        }

        //Post:	api/poll
        [HttpPost]
        [Route("api/poll")]
        public IHttpActionResult Post(PollOptionsViewModel pollOptionsViewModel)
        {
            if (pollOptionsViewModel == null)
            {
                return BadRequest();
            }

            var objReturn = _enqueteAppService.AdicionarPoll(pollOptionsViewModel);

            if (objReturn == null)
                return NotFound();
            else
            {
                var result = new { poll_id = objReturn.poll_id };
                return
                    Ok(result);
            }
        }

        // POST: api/poll/5/vote
        [HttpPost]
        [Route("api/poll/{id:int}/vote")]
        [ActionName("Vote")]
        public IHttpActionResult Vote(int id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var objReturn = _enqueteAppService.AdicionarVoto(id);
            if (objReturn == null)
                return NotFound();
            else
                return Ok();
        }


        // GET: api/poll/1/stats
        [Route("api/poll/{id:int}/stats")]
        [HttpGet]
        [ActionName("Stats")]
        public IHttpActionResult Stats(int id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var objReturn = _enqueteAppService.ObterStatisticas(id);
            if (objReturn == null)
                return NotFound();
            else
                return Ok(objReturn);
        }

    }
}
