using System.Linq;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using Project2.Models;

namespace Project2.Services
{
    public class PersonService
    {
        private readonly IMongoCollection<Person> persons;

        public PersonService(IConfiguration config)
        {
            MongoClient client = new MongoClient(config.GetConnectionString("Country"));
            IMongoDatabase database = client.GetDatabase("Country");
            persons = database.GetCollection<Person>("Persons");
        }

        public List<Person> Get()
        {
            return persons.Find(person => true).ToList();
        }

        public Person Get(string id)
        {
            return persons.Find(person => person.Id == id).FirstOrDefault();
        }

        public Person Create(Person person)
        {
            persons.InsertOne(person);
            return person;
        }

        public void Update(string id, Person personIn)
        {
            persons.ReplaceOne(person => person.Id == id, personIn);
        }

        public void Remove(Person personIn)
        {
            persons.DeleteOne(person => person.Id == personIn.Id);
        }

        public void Remove(string id)
        {
            persons.DeleteOne(person => person.Id == id);
        }
    }
}


