﻿using System;
using System.Collections.Generic;

namespace Classes.shared
{
    public partial class Person
    {

        public string Name;
        public DateTime DateOfBirth;

        public Wonders wonders;

        public List<Person> Children = new List<Person>();

        public static (string,int) GetCheck(){
            return("adrian",5);
        }
    }
}
