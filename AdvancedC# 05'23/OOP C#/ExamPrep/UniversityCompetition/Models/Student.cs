using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityCompetition.Models.Contracts;
using UniversityCompetition.Utilities.Messages;

namespace UniversityCompetition.Models
{
    public class Student : IStudent
    {
        
        private string firstName;
        private string lastName;

        //List<int> coveredExams
        private List<int> coveredExams = new List<int>();
        private IUniversity university;
        public Student(int studentId, string firstName, string lastName)
        {
            studentId = Id;
            firstName = FirstName;
            lastName = LastName;
        }
        public int Id { get; private set; }

        public string FirstName
        {
            get => firstName;
            private set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.NameNullOrWhitespace);
                }
                firstName = value; 
            }
        }

        public string LastName
        { 
            get => lastName;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.NameNullOrWhitespace);
                }
                lastName = value;
            }
        }
        //CoveredExams – IreadOnlyCollection<int> - A collection of integer values,
        //representing the subject ids of all covered exams by the student.
        public IReadOnlyCollection<int> CoveredExams => coveredExams;

        public IUniversity University => university;

        //Takes the subject’s id and adds it to the collection of CoveredExams
        public void CoverExam(ISubject subject)
        {
            coveredExams.Add(subject.Id);
        }

        //This method sets value of the property University.
        public void JoinUniversity(IUniversity university)
        {
            this.university = university;
        }
    }
}
