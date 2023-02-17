using Microsoft.EntityFrameworkCore;
using Ui.Data.Model;
using Ui.Data.Persistence;
using Ui.Helpers;

namespace Ui.Services
{
    public class AsynchronousOperationService
    {
        private readonly TutorContext _dbContext;
        public AsynchronousOperationService()
        {
            _dbContext = FileHelper.CreateDbInstance();
        }

        public async Task<List<NationalName>> ListAllAsync(int take = 0)
        {
            if (take > 0)
            {
                return await _dbContext.NationalNames.Take(take).ToListAsync();
            }
            var records = await _dbContext.NationalNames.ToListAsync();
            return records;
        }

        public async Task<List<NationalName>> ListMaleAsync(int take = 0)
        {
            if (take > 0)
            {
                return await _dbContext.NationalNames.Where(w => w.Gender == 'M').Take(take).ToListAsync();
            }
            var records = await _dbContext.NationalNames.Where(w => w.Gender == 'M').ToListAsync();
            return records;
        }

        public async Task<List<NationalName>> ListFemaleAsync(int take = 0)
        {
            if (take > 0)
            {
                return await _dbContext.NationalNames.Where(w => w.Gender == 'F').Take(take).ToListAsync();
            }
            var records = await _dbContext.NationalNames.Where(w => w.Gender == 'F').ToListAsync();
            return records;
        }

        public async Task<List<NationalName>> ListMostCommonAsync(int take = 0)
        {
            if (take > 0)
            {
                return await _dbContext.NationalNames.OrderByDescending(o => o.Count).Take(take).ToListAsync();
            }
            var records = await _dbContext.NationalNames.OrderByDescending(o => o.Count).Take(100).ToListAsync();
            return records;
        }
    }
}
