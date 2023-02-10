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

        public async Task<List<NationalName>> ListAllAsync()
        {
            var records = await _dbContext.NationalNames.ToListAsync();
            return records;
        }

        public async Task<List<NationalName>> ListMaleAsync()
        {
            var records = await _dbContext.NationalNames.Where(w => w.Gender == 'M').ToListAsync();
            return records;
        }

        public async Task<List<NationalName>> ListFemaleAsync()
        {
            var records = await _dbContext.NationalNames.Where(w => w.Gender == 'F').ToListAsync();
            return records;
        }

        public async Task<List<NationalName>> ListMostCommonAsync()
        {
            var records = await _dbContext.NationalNames.OrderByDescending(o => o.Count).Take(100).ToListAsync();
            return records;
        }
    }
}
