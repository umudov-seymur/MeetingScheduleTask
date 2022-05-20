using DelegateTask.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateTask.Models
{
    internal class MeetingSchedule
    {
        private List<Meeting> Meetings { get; set; }

        public MeetingSchedule()
        {
            Meetings = new List<Meeting>();
        }

        public void SetMeeting(string name, DateTime fromDate, DateTime toDate)
        {
            bool isExist = Meetings.Exists(meeting => meeting.FromDate >= fromDate && meeting.ToDate <= toDate);
            if (isExist) throw new MeetingAlreadyExistException("Bu intervala daxil olan meeting var");

            Meeting meeting = new Meeting
            {
                Name = name,
                FromDate = fromDate,
                ToDate = toDate
            };

            Meetings.Add(meeting);
        }

        public int FindMeetingsCount(DateTime date)
        {
            return Meetings.Where(meeting => meeting.FromDate > date)
                    .ToList()
                    .Count();
        }

        public List<Meeting> FindMeetings(Predicate<Meeting> predicate)
        {
            return Meetings.FindAll(predicate).ToList();
        }
    }
}
