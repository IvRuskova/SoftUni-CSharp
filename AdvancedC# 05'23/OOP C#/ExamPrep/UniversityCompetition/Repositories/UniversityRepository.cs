﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityCompetition.Models;
using UniversityCompetition.Models.Contracts;
using UniversityCompetition.Repositories.Contracts;

namespace UniversityCompetition.Repositories
{
    public class UniversityRepository : IRepository<IUniversity>
    {
        private List<IUniversity> universities = new List<IUniversity>();
        public IReadOnlyCollection<IUniversity> Models => universities.AsReadOnly();

        public void AddModel(IUniversity model)
        {
            universities.Add(model);
        }

        public IUniversity FindById(int id)
        {
            return universities.FirstOrDefault(u => u.Id == id);
        }

        public IUniversity FindByName(string name)
        {
            return universities.FirstOrDefault(u => u.Name == name);
        }
    }
}
