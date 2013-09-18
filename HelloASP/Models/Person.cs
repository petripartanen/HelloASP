using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HelloASP.Models
{
    public class Person
    {
        public int ID { get; set; }
        public string name { get; set; }
        public int age { get; set; }
    }

    public class PersonDBContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
    }
}