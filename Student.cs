using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLab12
{
    public class Student
    {
        public string Name {  get; set; }
        public string Surname {  get; set; }
        public string University {  get; set; }
        public int Age {  get; set; }
        public double Semester {  get; set; }
        public double Scholarship {  get; set; }
        public bool HasHostel {  get; set; }
        public bool HasScholarship { get; set; }
        public double GeneralScholarship()
        {
            return Scholarship * Semester * 6;
        }
        public Student()
        {
        }
        public Student(string name, string surname, string university, int age, double semester, double scholarship, bool hasHostel, bool hasScholarship)
        {
            Name = name;
            Surname = surname;
            University = university;
            Age = age;
            Semester = semester;
            Scholarship = scholarship;
            HasHostel = hasHostel;
            HasScholarship = hasScholarship;
        }
    }
}
