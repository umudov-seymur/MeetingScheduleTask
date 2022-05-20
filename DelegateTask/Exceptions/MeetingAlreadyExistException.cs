using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateTask.Exceptions
{
    internal class MeetingAlreadyExistException : Exception
    {
        public MeetingAlreadyExistException()
        {
        }

        public MeetingAlreadyExistException(string message)
            : base(message)
        {
        }
    }
}
