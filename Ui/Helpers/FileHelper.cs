using Microsoft.EntityFrameworkCore;
using Ui.Data.Model;
using Ui.Data.Persistence;

namespace Ui.Helpers
{
    public static class FileHelper
    {
        public static TutorContext CreateDbInstance()
        {
            var dbContextBuilder = new DbContextOptionsBuilder<TutorContext>()
                                            .UseInMemoryDatabase("Tutor");
            var dbContext = new TutorContext(dbContextBuilder.Options);
            return dbContext;
        }

        public static async Task<List<NationalName>> ReadRecordsAsync()
        {
            var records = new List<NationalName>();
            using (var sReader = new StreamReader("data\\nationalnames.csv"))
            {
                while (!sReader.EndOfStream)
                {
                    var line = await sReader.ReadLineAsync();
                    if (!string.IsNullOrEmpty(line) && line != "Id,Name,Year,Gender,Count")
                    {
                        var values = line.Split(',');
                        var nationalName = new NationalName
                        {
                            Id = int.Parse(values[0]),
                            Name = values[1],
                            Year = int.Parse(values[2]),
                            Gender = char.Parse(values[3]),
                            Count = int.Parse(values[4])
                        };
                        records.Add(nationalName);
                    }
                }
            }
            return records;
        }

        public static async Task<int> WriteRecordsAsync(List<NationalName> nationalNames)
        {
            var dbContext = CreateDbInstance();
            dbContext.NationalNames.AddRange(nationalNames);
            var result = await dbContext.SaveChangesAsync();
            return result;
        }
    }
}
