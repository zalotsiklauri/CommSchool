using System;
namespace lecture9

{
    internal class Employee
    {
        public string name { get; set; }
        public int age { get; set; }
        public Position position { get; set; }
        public int workHoursPerWeek { get; set; }
        public int salaryNormaldays { get; set; }
        public int salaryPerDay { get; set; }
        public int salaryWeekend { get; set; }
        public int salaryOverTime = 5;
        public int totalOverTime { get; set; }
        public int salaryBonus { get; set; }
        public int employSelary { get; set; }
        public int totalSalary { get; set; }
        public int totalWorkHours { get; set; }
        private string positionString { get; set; }





        public int salary { get; set; }
        private Dictionary<Weekdays, int> workHours = new Dictionary<Weekdays, int>()
        {
            {Weekdays.Friday, 0},
            {Weekdays.Monday, 0},
            {Weekdays.Tuesday, 0},
            {Weekdays.Wednesday, 0},
            {Weekdays.Thursday, 0},
            {Weekdays.Saturday, 0},
            {Weekdays.Sunday, 0}
        };

        private Dictionary<Position, int> salarys = new Dictionary<Position, int>()
        {
            {Position.Manager, 40},
            {Position.Developer, 30},
            {Position.Tester, 20},
            {Position.Designer, 10},

        };

        public enum Position
        {
            Manager,
            Developer,
            Tester,
            Designer,

        }
        public enum Weekdays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}