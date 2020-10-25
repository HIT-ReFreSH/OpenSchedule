using System;
namespace OpenSchedule
{
    public class EventInformation
    {
        public string Classroom { get; }
        public DateTime StartTime { get; }
        public TimeSpan EventDuration { get; }
        public EventInformation(string room,DateTime start,TimeSpan duration)
        {
            Classroom = room;
            StartTime = start;
            EventDuration = duration;
        }
    }
}
