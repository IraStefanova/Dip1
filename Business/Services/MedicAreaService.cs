using Business.Mappers;
using Business.Models;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class MedicAreaService(PatientDbContext context) : IMedicAreaService
    {
        public async Task<List<MedicAreasDto>> GetMedicAreas()
        {
            return await context.MedicAreas.Select(x => MedicAreaMapper.MapToDto(x)).ToListAsync();
        }

        public async Task CreateMedicArea(MedicAreasDto medicArea)
        {
            if (string.IsNullOrEmpty(medicArea.Name))
                throw new Exception("Name is required");
            

            var medicAreaEntity = MedicAreaMapper.MapToDb(medicArea);
            context.MedicAreas.Add(medicAreaEntity);
            await context.SaveChangesAsync();

        }
        public async Task EditMedicArea(MedicAreasDto medicArea)
        {
            var oldValue = await context.MedicAreas.FirstOrDefaultAsync(t => t.Id == medicArea.Id);

            if (oldValue == null)
            {
                throw new Exception("MedicArea not found");
            }

            var newValues = MedicAreaMapper.MapToDb(medicArea);
            context.Entry(oldValue).CurrentValues.SetValues(newValues);

            oldValue.Name = medicArea.Name;

            await context.SaveChangesAsync();
        }
    }
}
