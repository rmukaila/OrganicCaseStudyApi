using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OrganicCaseStudyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganicApiController : ControllerBase
    {
        private readonly DataContext context;

        public OrganicApiController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet(Name ="GetAllPaints"), Authorize]
        public async Task<ActionResult<List<OrganicApi>>> Get(string searchString)
        {
            var paints = await context.Paints.Where(n => n.FirstName.Contains(searchString)).ToListAsync();

            return Ok(paints);
    }
    }
}
