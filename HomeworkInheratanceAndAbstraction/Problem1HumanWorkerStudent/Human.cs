﻿using System;

namespace Problem1HumanWorkerStudent
{
    abstract class Human
    {
        private string firstName;
        private string lastNAme;

        protected Human(string firstName,string lastName )
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString()
        {
           return String.Format( "-First Name:{0}   -Last Name:{1}",this.FirstName,this.LastName);
        }
    }
}
