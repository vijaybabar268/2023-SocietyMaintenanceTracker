using API.Data;
using API.Entities;
using API.Services;

public class SocietyService : ISocietyService
{
    private readonly DataContext _context;
    
    public SocietyService(DataContext context)
    {
        _context = context;
    }

    public void CreateSociety(Society society)
    {
        _context.Societies.Add(society);
        _context.SaveChanges();
    }

    public Society GetSociety(int id)
    {
        return _context.Societies.Find(id);
    }

    public void UpsertSociety(Society society)
    {
         var societyInDb = _context.Societies.Find(society.Id);
        societyInDb.Name = society.Name;
        _context.SaveChanges();
    }

    public void DeleteSociety(int id)
    {
        _context.Societies.Remove(_context.Societies.Find(id));
        _context.SaveChanges();
    }

    public IEnumerable<Society> GetSocieties()
    {
        return _context.Societies.ToList();
    }
}