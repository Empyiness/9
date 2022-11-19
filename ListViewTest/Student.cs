using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ListViewTest
{
    internal class Student
    {
        StudentStruct student = new StudentStruct();
        public string Surname
        {
            get => student.SurnameStruct;
            set => student.SurnameStruct = value;
        }
        public string Hostel
        {
            get => student.HostelStruct;
            set => student.HostelStruct = value;
        }
        public string Experience
        {
            get => student.ExperienceStruct;
            set => student.ExperienceStruct = value;
        }
        public string Work
        {
            get => student.WorkStruct;
            set => student.WorkStruct = value;
        }
        public string Education
        {
            get => student.EducationStruct;
            set => student.EducationStruct = value;
        }
        public string Language
        {
            get => student.LanguageStruct;
            set => student.LanguageStruct = value;
        }
    }
}
