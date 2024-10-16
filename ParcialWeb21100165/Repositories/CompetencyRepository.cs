using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ParcialWeb21100165.Data;
using ParcialWeb21100165.Interfaces;

namespace ParcialWeb21100165.Repositories
{
    public class CompetencyRepository : ICompetencyRepository
    {
        private readonly Parcial20240221100165DbContext _dbContext;

        public CompetencyRepository(Parcial20240221100165DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // Select Competency
        public async Task<IEnumerable<Competency>> GetAll()
        {
            var competency = await _dbContext.Competency.ToListAsync();
            return competency;
        }

        //Create Competency
        public async Task<int> Insert(Competency competency)
        {
            await _dbContext.Competency.AddAsync(competency);
            int rows = await _dbContext.SaveChangesAsync();

            return rows > 0 ? competency.Id : -1;
        }

        //Update Competency
        public async Task<bool> Update(Competency competency)
        {
            _dbContext.Competency.Update(competency);
            int rows = await _dbContext.SaveChangesAsync();

            return rows > 0;
        }


        //Delete Competency
        public async Task<bool> Delete(int id)
        {
            var competency = await _dbContext
                            .Competency
                            .FirstOrDefaultAsync(a => a.Id == id);

            if (competency == null) return false;

            _dbContext.Competency.Remove(competency);
            int rows = await _dbContext.SaveChangesAsync();
            return (rows > 0);
        }
    }
}
