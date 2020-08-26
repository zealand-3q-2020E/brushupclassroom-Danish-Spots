using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class ClassRoom
    {
        public ClassRoom()
        {
            ClassName = "";
            ClassList = new List<Student>();
            SemesterStart = new DateTime();
        }

        public string ClassName { get; set; }
        public List<Student> ClassList { get; set; }
        public DateTime SemesterStart { get; set; }

        public void GetAllStudentsBirthSeason()
        {
            Dictionary<string, int> countPerSeason = new Dictionary<string, int>();
            countPerSeason.Add("Winter", ClassList.Where(s => s.GetSeasonStudentBirthDay() == "Winter").ToList().Count());
            countPerSeason.Add("Spring", ClassList.Where(s => s.GetSeasonStudentBirthDay() == "Spring").ToList().Count());
            countPerSeason.Add("Summer", ClassList.Where(s => s.GetSeasonStudentBirthDay() == "Summer").ToList().Count());
            countPerSeason.Add("Autumn", ClassList.Where(s => s.GetSeasonStudentBirthDay() == "Autumn").ToList().Count());

            foreach (KeyValuePair<string, int> pair in countPerSeason)
            {
                Console.WriteLine($"{pair.Value} students have birthdays in {pair.Key}");
            }
        }
    }
}
