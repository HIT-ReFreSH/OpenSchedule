using System;
namespace OpenSchedule
{
    public class EventInformation
    {

        /// <summary>
        /// The info of an event, including classroom(the location of a class),
        ///     the start time of the course and the duration of the course.
        /// </summary>
        public string Classroom { get; }
        public DateTime StartTime { get; }
        public TimeSpan EventDuration { get; }



        /// <summary>
        /// the consturctor of class EventInfomation
        /// </summary>
        /// <param name="room">the location of the event</param>
        /// <param name="start">the start time of the event</param>
        /// <param name="duration">the duration of the event        </param>
        public EventInformation(string room,DateTime start,TimeSpan duration)
        {
            Classroom = room;
            StartTime = start;
            EventDuration = duration;
        }
    }
}
