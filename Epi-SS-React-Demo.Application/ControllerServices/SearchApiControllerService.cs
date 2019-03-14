using Epi_SS_React_Demo.Application.Interfaces;
using System;
using System.Web.Mvc;

namespace Epi_SS_React_Demo.Application.ControllerServices
{
    public class SearchApiControllerService
    {
        private readonly ISearchService _service;

        public SearchApiControllerService(ISearchService service)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));
        }

        public JsonResult GetResults(string query)
        {
            var data = _service.GetResults(query);

            return new JsonResult { Data = data, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
    }
}
