using System.Collections.Generic;
using ASPNET_API_proj.Model;

namespace ASPNET_API_proj.Services
{
    public interface IPersonService
    {
         Person Create(Person person);
         Person FindById(long Id);
         List<Person> FindAll();
         Person Update(Person person);
         void Delete(long Id);

    }
}