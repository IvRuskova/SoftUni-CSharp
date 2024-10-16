﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityCompetition.Models.Contracts;
using UniversityCompetition.Utilities.Messages;

namespace UniversityCompetition.Models
{
    public abstract class Subject : ISubject
    {
        private int id;
        private string name;
        private double rate;

        public Subject(int subjectId, string subjectName, double subjectRate)
        {
            Id=subjectId;
            Name = subjectName;
            Rate = subjectRate;
        }
        public int Id 
        { 
            get;
            private set;  
        }

        public string Name 
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new AggregateException(ExceptionMessages.NameNullOrWhitespace);
                }
                name = value;
            } 
        }

        public double Rate 
        { 
            get => rate; 
            private set => rate = value; 
        }
    }
}
