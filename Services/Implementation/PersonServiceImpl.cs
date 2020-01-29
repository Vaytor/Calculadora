using Calculadora.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Calculadora.Services.Implementation
{
    public class PersonServiceImpl : IPersonService
    {
        private volatile int count;

        //Método responsavel por Criar uma pessoa
        //Recebe por parametro o objeto pessoa
        public Person Create(Person person)
        {
            return person;
        }

        //Método responsavel por deletar uma pessoa
        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        //Método responsavel por Retornar todas as pessoas
        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();

            for (int i = 0; i < 8; i++) 
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }

            return persons;
        }

        //Método responsavel por gerar pessoas, por agora, antes de ir para o banco
        private Person MockPerson(int i)
        {
            long idPerson = gerarNovoId();
            return new Person
            {
                Id = idPerson,
                FirstName = "Person " + i,
                LastName = "Souza" + i,
                Address = "Rua teste 1213" + i,
                Gender = "Masculino" + i
            };
        }

        //Método que gera um novo Id
        private long gerarNovoId()
        {
            return Interlocked.Increment(ref count);
        }

        //Método responsavel por encontrar uma pessoa pelo id
        public Person FindById(long id)
        {
            return new Person
            {
                Id = gerarNovoId(),
                FirstName = "Victor",
                LastName = "Souza",
                Address = "Rua teste 1213",
                Gender = "Masculino"
            };
        }
        //Método que atualiza uma pessoa
        public Person Update(Person person)
        {
            return person;
        }
    }
}
