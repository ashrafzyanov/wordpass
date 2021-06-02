using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASHR.Wordpass.InternalApi.Data;
using ASHR.Wordpass.InternalApi.Queries;

namespace ASHR.Wordpass.Controller.Api
{
    [Route("api/wordpass/project")]
    public class ApiWordpassController : ApiWordpassBaseController
    {
        [HttpGet]
        public async Task<ActionResult<GetAllProjectQueryResult>> getProjects()
        {
            return await Mediator.Send(new GetAllProjectQuery());
        }

        [HttpGet("{id}/object")]
        public async Task<ActionResult<GetAllProjectAccessObjectQueryResult>> getProjectObjects([FromRoute] string id)
        {
            var guid = Guid.Parse(id);
            return await Mediator.Send(new GetAllProjectAccessObjectQuery(guid));
        }

    }
}