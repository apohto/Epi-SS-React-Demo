using Epi_SS_React_Demo.Application.ControllerServices;
using System;
using System.Web.Http;

namespace Epi_SS_React_Demo.Controllers.Api
{
    public class SearchApiController : ApiController
    {
        private readonly SearchApiControllerService _service;

        public SearchApiController(SearchApiControllerService service)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));
        }

        [HttpGet]
        [Route("api/search/getResults")]
        public System.Web.Mvc.JsonResult GetResults([FromUri] string q)
        {
            return _service.GetResults(q);
        }
    }
}