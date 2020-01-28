using Calculadora.Model;
using System.Collections.Generic;

namespace Calculadora.Services
{
    interface IPersonService
    {
        Person Create(Person person);
        Person FindById(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);
    }
}
