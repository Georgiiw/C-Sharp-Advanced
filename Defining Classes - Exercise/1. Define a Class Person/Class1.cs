﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
     class Person
    {
        private string name;
        private int age;

        public string Name
        { 
            get { return this.name; }
            set { name = value; } 
        }

        public int Age
        {
            get { return this.age; }
            set { age = value; }
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
          
        }
    }
}