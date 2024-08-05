using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public interface IMedicAreaService
    {
        public Task<List<MedicAreasDto>> GetMedicAreas();
        public Task CreateMedicArea(MedicAreasDto medicArea);

        public Task EditMedicArea(MedicAreasDto medicArea);
    }
}
