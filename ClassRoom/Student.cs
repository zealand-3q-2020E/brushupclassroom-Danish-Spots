using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class Student
    {
        public Student(string name, int birthMonth, int birthday)
        {
            Name = name;
            BirthMonth = birthMonth;
            Birthday = birthday;
        }

        public string Name { get; private set; }
        public int BirthMonth { get; private set; }
        public int Birthday { get; private set; }

        public string GetSeasonStudentBirthDay()
        {

            switch (BirthMonth)
            {
                case 12:
                    return "Winter";
                case 1:
                    return "Winter";
                case 2:
                    return "Winter";
                case 3:
                    return "Spring";
                case 4:
                    return "Spring";
                case 5:
                    return "Spring";
                case 6:
                    return "Summer";
                case 7:
                    return "Summer";
                case 8:
                    return "Summer";
                case 9:
                    return "Autumn";
                case 10:
                    return "Autumn";
                case 11:
                    return "Autumn";
                default:
                    return "";
            }
        }
    }
}
