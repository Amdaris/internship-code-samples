using System;
using System.Text.RegularExpressions;

namespace ProjectDemo
{
    public enum ScholarshipType
    {
        P1,
        P2,
        M1,
        M2
    }
    public class Student
    {
        public string Code { get; init; }
        public int YearOfStudy { get; init; }
        public float Grade { get; init; }
        public ScholarshipType ScholarshipType { get; init; }

        public override string ToString()
        {
            return $"{Code} {YearOfStudy} {Grade} {ScholarshipType}";
        }

        public static Student ParseStudent(string line)
        {
            var items = line.Split(" ")[1..];
            var code = items[0];
            var yearOfStudy = Convert.ToInt32(items[1]);
            var grade = Convert.ToSingle(items[2].Replace(",", "."));

            var perforRegex = new Regex("^[Pp]+");

            var scholarshipType = (items[3], items[4]) switch
            {
                (string x, string y) when perforRegex.IsMatch(x) && y == "1" => ScholarshipType.P1,
                (string x, string y) when perforRegex.IsMatch(x) && y == "2" => ScholarshipType.P2,
                (_, string y) when y == "1" => ScholarshipType.M1,
                _ => ScholarshipType.M2,
            };

            return new Student
            {
                Code = code,
                YearOfStudy = yearOfStudy,
                Grade = grade,
                ScholarshipType = scholarshipType,
            };
        }
    }
}
