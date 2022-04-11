using MovieCatalog.DataAccess.Implementations;
using MovieCatalog.DataAccess.Interfaces;
using MovieCatalog.Domain.Models;
using MovieCatalog.Services.Interfaces;
using MovieCatalog.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieCatalog.Services.Implementations
{
    public class PersonService : IPersonService
    {
        private IRepository<Person> _personRepository;

        public PersonService(IRepository<Person> personRepository)
        {
            _personRepository=personRepository;
        }
        public Person AddPerson(Person person)
        {
            return _personRepository.Add(person);
        }

        public List<PersonViewModel> GetPeople()
        {
            List<PersonViewModel> list = new List<PersonViewModel>();
            var allPeople = _personRepository.GetAll();

            foreach (var person in allPeople)
            {
                PersonViewModel personViewModel = new PersonViewModel();
                personViewModel.Id = person.Id;
                personViewModel.FirstName = person.FirstName;
                personViewModel.LastName = person.LastName;
                personViewModel.Age = person.Age;
                personViewModel.Biography = person.Biography;
               

                list.Add(personViewModel);
            }

            return list;
        }
    }
}
