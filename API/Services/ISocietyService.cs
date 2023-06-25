using API.Entities;

namespace API.Services
{
    public interface ISocietyService
    {
        public void CreateSociety(Society society);
        Society GetSociety(int id);
        void UpsertSociety(Society society);
        void DeleteSociety(int id);
        IEnumerable<Society> GetSocieties();
    }
}