using DelegateTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DelegateTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MeetingSchedule meetingSchedule = new MeetingSchedule();

            var today = DateTime.Now;

            meetingSchedule.SetMeeting("P324 Online Ders", today, DateTime.Now.AddHours(1));
            meetingSchedule.SetMeeting("P325 Online Ders", today.AddHours(2), DateTime.Now.AddHours(4));

            var meetings = meetingSchedule.FindMeetings(meeting => meeting.ToDate >= DateTime.Now);

            var meetingsCount = meetingSchedule.FindMeetingsCount(today);

            Console.WriteLine(meetingsCount);

            //meetings.ForEach(meeting =>
            //{
            //    Console.WriteLine(meeting.Name);
            //});
        }
    }
}
