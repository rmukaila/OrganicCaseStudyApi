using Microsoft.AspNetCore.Mvc;
using OrganicCaseStudyApi;
using OrganicBlazorApp1.Services;

namespace OrganicBlazorApp1.Services
{

    
    public class DemirbasService:IDemirbasService
    {
        private readonly HttpClient httpClient;

        public DemirbasService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<ActionResult<List<OrganicApi>>> Get(string searchString)
        {
        return await httpClient.GetFromJsonAsync<List<OrganicApi>>("api/OrganicApi");   
        }

        }
}
