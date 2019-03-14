using System.Collections.Generic;
using Epi_SS_React_Demo.Models.Models.Data;

namespace Epi_SS_React_Demo.Application.Interfaces
{
    public interface ISearchService
    {
        IEnumerable<SearchResult> GetResults(string query);
    }
}
