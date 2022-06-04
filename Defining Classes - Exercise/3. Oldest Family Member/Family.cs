using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
     public class Family
     {

        public Family()
        {
            Members = new List<Person>();
        }
        private List<Person> Members; 

        public void AddMember(Person member)
        {
           Members.Add(member);
        }
        public Person GetOldestMember()
        {
            Person person = Members
                .OrderByDescending(x => x.Age)
                .FirstOrDefault();
            return person;
        }

    }
}
