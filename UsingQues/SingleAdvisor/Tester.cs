using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingQues.SingleAdvisor
{
    internal class Tester
    {
        static void Main(string[] args)
        {
            InterviewCenter center = new InterviewCenter();
            center.Interview("ST1000");
            center.Interview("ST1009");
            center.Interview("ST1030");
            center.Interview("ST1234");
            center.Interview("ST1033");

            while (center.Interviews.Count >0)
           
            {
                WalkinInInterview interview = center.AttendToStudent("Jessie");
                Print($"Inrerview  {interview.Id} for Student {interview.studentNumber} is attended to by {interview.Advisor} at {interview.startTime}");
                Thread.Sleep(1000);
                center.EndInterview(interview);
                Print($"Interview {interview.Id} with Student {interview.studentNumber} was ended by {interview.Advisor} at {interview.endTime}");
            }
           
            Console.Read(  );

        }

        public static void Print(string str) {
            Console.WriteLine( $"{DateTime.Now.ToString("HH:mm:ss")}  -  {str}");
        }
    }
}
