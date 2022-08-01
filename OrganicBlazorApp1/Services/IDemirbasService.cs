using Microsoft.AspNetCore.Mvc;
using OrganicCaseStudyApi;

namespace OrganicBlazorApp1.Services
{
    public interface IDemirbasService
    {

        Task<ActionResult<List<OrganicApi>>> Get(string searchString);

    }
}
