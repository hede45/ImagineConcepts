using Arch.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arch.Domain.Entities
{
    public class Architect :Person
    {
        [Key]
        public int ArchitectId { get; set; }
        public void Set(Person person)
        {
            Title = person.Title;
            FirstName = person.FirstName;
            LastName = person.LastName;
            PhoneNumber = person.PhoneNumber;
            Email = person.Email;
        }

        public Person AsPerson()
        {
            return new Person
            {
                Title = Title,
                FirstName = FirstName,
                LastName = LastName,
                PhoneNumber = PhoneNumber,
                Email = Email
            };
        }
    }
}
