using Business.Models;
using Business.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class MedicAreasController (IMedicAreaService medicAreaService) : ControllerBase

    {
        [HttpGet("GetMedicAreas")]
        public async Task<List<MedicAreasDto>> GetMedicAreas() => await medicAreaService.GetMedicAreas();
        [HttpPost("CreateMedicArea")]
        public async Task CreateMedicArea(MedicAreasDto medicArea) => await medicAreaService.CreateMedicArea(medicArea);

        [HttpPut("EditMedicArea")]
        public async Task EditMedicArea(MedicAreasDto medicArea) => await medicAreaService.EditMedicArea(medicArea);
    }
}
