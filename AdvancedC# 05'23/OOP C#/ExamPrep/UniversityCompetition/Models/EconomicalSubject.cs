﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityCompetition.Models
{
    public class EconomicalSubject : Subject
    {
        private const double economicalSubjectRate = 1;

        public EconomicalSubject(int subjectId, string subjectName) : base(subjectId, subjectName, economicalSubjectRate)
        {
        }
    }
}
