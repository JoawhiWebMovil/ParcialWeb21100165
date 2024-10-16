using ParcialWeb21100165.Data;

namespace ParcialWeb21100165.Interfaces
{
    public interface ICompetencyRepository
    {
        Task<bool> Delete(int id);
        Task<IEnumerable<Competency>> GetAll();
        Task<int> Insert(Competency competency);
        Task<bool> Update(Competency competency);
    }
}