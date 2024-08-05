using Business.Models;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Mappers
{
    public static class MedicAreaMapper
    {
        public static MedicAreasDto MapToDto(MedicAreas medicAreas)
        {
            return new MedicAreasDto
            {
                Id = medicAreas.Id,
                Name = medicAreas.Name
            };
        }
        public static MedicAreas MapToDb(MedicAreasDto medicAreas)
        {
            return new MedicAreas
            {
                Id = medicAreas.Id ?? 0,
                Name = medicAreas.Name
            };
        }
    }
}
