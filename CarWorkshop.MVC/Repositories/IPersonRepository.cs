using CarWorkshop.MVC.Models;

namespace CarWorkshop.MVC.Repositories
{
    public interface IPersonRepository
    {
        Person Get(int id);
        IQueryable<Person> GetAllActive();
        void Add(Person person);
        void Update(int Id, Person person);
        void Delete(int Id);
    }
}
