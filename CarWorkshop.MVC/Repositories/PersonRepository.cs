using CarWorkshop.MVC.Models;

namespace CarWorkshop.MVC.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        public Person Get(int id)
        {
            throw new NotImplementedException();
        }
        public IQueryable<Person> GetAllActive()
        {
            throw new NotImplementedException();
        }
        public void Add(Person person)
        {
            throw new NotImplementedException();
        }

        public void Update(int Id, Person person)
        {
            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
