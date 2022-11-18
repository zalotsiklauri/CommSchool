using System;
namespace lecture_11
{
    public class MyJsonObject
    {
        public DateTime currentdate { get; set; }
        public DateTime birthDay { get; set; }
        public void Calculate()
        {
            TimeSpan LastTime = currentdate - birthDay;
            Console.WriteLine(LastTime.Days);
        }
        
    }
       
}
   