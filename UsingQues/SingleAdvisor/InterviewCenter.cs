using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingQues.SingleAdvisor
{
    internal class InterviewCenter
    {
        private int _count = 0;
        public Queue<WalkinInInterview>? Interviews { get; set; }

        public InterviewCenter()
        {
            Interviews = new Queue<WalkinInInterview>();
        }

        public void Interview(string stNumber) { 

            WalkinInInterview walkinInInterview = new WalkinInInterview() { 
                interviewTime = DateTime.Now,
                studentNumber = stNumber,
                Id = ++_count
            };
            Interviews.Enqueue(walkinInInterview);
        }

        public WalkinInInterview AttendToStudent(string advisor) {

            if (Interviews.Count > 0)
            {
                WalkinInInterview interview = Interviews.Dequeue();
                interview.Advisor  = advisor;
                interview.startTime = DateTime.Now;
                return interview;
            }
            return null;
        }

        public void EndInterview(WalkinInInterview interview) {

            interview.endTime = DateTime.Now;
        }
    }
}
