using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Linq;

namespace Test01
{
    class Program
    {

        static void Main(string[] args)
        {
            var tech = new TechService();
            //565
            var misato = new Student
            {
                Name = "Misato",
                Age = 29,
                CountOfFriends = 4,
                Spezialisation = Spezialitations.EvangelionSquadTacticalOperationsCommander,
            };
            var asuna = new Student
            {
                Name = "Asuna",
                Age = 19,
                CountOfFriends = 14,
                Spezialisation = Spezialitations.SubleaderOfTheBloodKnightsGuild,
            }; 
            var violet = new Student
            {
                Name = "Violet",
                Age = 18,
                CountOfFriends = 6,
                Spezialisation = Spezialitations.AutoRecordingDoll,
            };
            var senko = new Student
            {
                Name = "Senko",
                Age = 804,
                CountOfFriends = 4,
                Spezialisation = Spezialitations.GoddessOfFertility,
            };
            var hanji = new Student
            {
                Name = "Hanji",
                Age = 31,
                CountOfFriends = 2,
                Spezialisation = Spezialitations.CommanderOfTheParadiseIslandSurveyCorps,
            };
            var jotaro = new Student
            {
                Name = "Jotaro",
                Age = 53,
                CountOfFriends = 5,
                Spezialisation = Spezialitations.StandUserStandoPawarZaWarudo,
            };
            var studentList = new List<Student>
            {
                misato,
                asuna,
                violet,
                senko,
                hanji,
                jotaro
            };
            var firstStudentWithName = studentList.FirstOrDefault(x => x.Name == "Violet");
            if (firstStudentWithName == null)
            {
                throw new Exception("Студент с выбранным именем не найден");
            }
            else
            {
                Console.WriteLine(firstStudentWithName.Name);
                Console.WriteLine(firstStudentWithName.Age);
                Console.WriteLine(firstStudentWithName.CountOfFriends);
            }
            //567
            var firstStudentWithAge = studentList.FirstOrDefault(x => x.Age > 20);
            if (firstStudentWithAge == null)
            {
                throw new Exception("Студент с искомым возрастом не найден");
            }
            else
            {
                Console.WriteLine(firstStudentWithAge.Name);
                Console.WriteLine(firstStudentWithAge.Age);
                Console.WriteLine(firstStudentWithAge.CountOfFriends);
            }
            //568
            var studentsWithAgeList = studentList.Where(x => x.Age == 19).ToList();
            if (studentsWithAgeList == null || studentsWithAgeList.Count == 0)
            {
                throw new Exception("Студенты с искомым возрастом не найдены");
            }
            else
            {
                foreach(var student in studentsWithAgeList)
                {
                    Console.WriteLine(student.Name);
                    Console.WriteLine(student.Age);
                    Console.WriteLine(student.CountOfFriends);
                }
            }
            //570
            var studentsSpecList = studentList.Where(x => x.Spezialisation == Spezialitations.AutoRecordingDoll).ToList();
            if (studentsSpecList == null || studentsSpecList.Count == 0)
            {
                throw new Exception("Студенты с искомой специализацией не найдены");
            }
            else
            {
                foreach (var student in studentsSpecList)
                {
                    Console.WriteLine(student.Name);
                    Console.WriteLine(student.Age);
                    Console.WriteLine(student.CountOfFriends);
                }
            }
            //571
            var studentsNameList = studentList.Select(x => x.Name).ToList();
            if (studentsNameList == null || studentsNameList.Count == 0)
            {
                throw new Exception("Студенты с искомым возрастом не найдены");
            }
            else
            {
                foreach (var name in studentsNameList)
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
