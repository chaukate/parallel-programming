using Ui.Data.Model;
using Ui.Data.Persistence;
using Ui.Helpers;

namespace Ui.Services
{
    public class SynchronousOperationService
    {
        private readonly TutorContext _dbContext;
        public SynchronousOperationService()
        {
            _dbContext = FileHelper.CreateDbInstance();
        }

        public List<NationalName> ListAll()
        {
            var records = _dbContext.NationalNames.ToList();
            return records;
        }

        public List<NationalName> ListMale()
        {
            var records = _dbContext.NationalNames.Where(w => w.Gender == 'M').ToList();
            return records;
        }

        public List<NationalName> ListFemale()
        {
            var records = _dbContext.NationalNames.Where(w => w.Gender == 'F').ToList();
            return records;
        }

        public List<NationalName> ListMostCommon()
        {
            var records = _dbContext.NationalNames.OrderByDescending(o => o.Count).Take(100).ToList();
            return records;
        }
    }
}
