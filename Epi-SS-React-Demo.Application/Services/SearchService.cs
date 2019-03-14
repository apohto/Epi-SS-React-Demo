using Epi_SS_React_Demo.Application.Interfaces;
using Epi_SS_React_Demo.Models.Models.Data;
using EPiServer.Find;
using EPiServer.Find.Cms;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Epi_SS_React_Demo.Application.Services
{
    public class SearchService : ISearchService
    {
        private readonly IClient _client;

        public SearchService(IClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public IEnumerable<SearchResult> GetResults(string query)
        {
            var results = _client.UnifiedSearchFor(query)
                .GetResult();

            return results.Select(x => new SearchResult
            {
                Title = x.Title,
                Description = x.Excerpt,
                LinkUrl = x.Url
            });
        }
    }
}
