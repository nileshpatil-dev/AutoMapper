using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.FirstName = "Nilesh";
            p.LastName = "Patil";
            p.CityName = "Pune";

            Mapper.Initialize(cfg => cfg.CreateMap<Person, Employee>()
            .ForMember(d => d.City, s => s.MapFrom("CityName")));
            Employee e = Mapper.Map<Employee>(p);
            Console.ReadKey(true);
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CityName { get; set; }
    }


    class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string DeptId { get; set; }
    }

}
