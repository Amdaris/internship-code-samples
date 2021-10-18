using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace JoinDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>
            {
                new Person("Jackson", "John"),
                new Person("Smith", "Andrew"),
                new Person("Gates", "Bill"),
            };

            var pets = new List<Pet>
            {
                new Pet("Tim", "cat", "Jackson"),
                new Pet("Louis", "cat", "Smith"),
                new Pet("Jordan", "dog", "Smith"),
                new Pet("Holland", "dog", null),
            };

            var joined = people.Join(
                pets,
                person => person.LastName,
                pet => pet.OwnerName,
                (person, pet) => $"{person.FullName} - {pet.Name}"
            );

            foreach(var j in joined) 
            {
                Console.WriteLine(j);
            }
        }
    }
}
