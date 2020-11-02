using System;

namespace OpenSchedule
{
    public class EventInformation : IComparable, ICloneable
    {
        /// <summary>
        ///     the constructor of class EventInformation
        /// </summary>
        /// <param name="room">the location of the event</param>
        /// <param name="start">the start time of the event</param>
        /// <param name="duration">
        ///     the duration of the event
        ///     <param name="EventId">
        ///         the hash of the event
        ///     </param>
        public EventInformation(string room, DateTime start, TimeSpan duration)
        {
            Classroom = room;
            StartTime = start;
            EventDuration = duration;
            EventId = Guid.NewGuid();
        }

        /// <summary>
        ///     a new constructor of class EventInformation, only used in method clone()
        /// </summary>
        /// <param name="room"></param>
        /// <param name="start"></param>
        /// <param name="duration"></param>
        /// <param name="Id"></param>
        public EventInformation(string room, DateTime start, TimeSpan duration, Guid Id)
        {
            Classroom = room;
            StartTime = start;
            EventDuration = duration;
            EventId = Id;
        }

        /// <summary>
        ///     The info of an event, including classroom(the location of a class),
        ///     the start time of the course and the duration of the course.
        ///     表示一个事件的信息（可以是课程，也可以是考试），内容包含:地点 classroom，开始时间 StartTime，时长 EventDuration
        ///     注意，这里的一个信息，只能表示某一天的某一个具体的事件，而不是一个学期的同一个事件的集合。
        /// </summary>
        public Guid EventId { get; }

        public string Classroom { get; }
        public DateTime StartTime { get; }
        public TimeSpan EventDuration { get; }

        /// <summary>
        ///     get a new Event same with this event
        /// </summary>
        /// <returns>an object same with the current event</returns>
        public object Clone()
        {
            return new EventInformation(Classroom, StartTime, EventDuration, EventId);
        }

        /// <summary>
        ///     compare the input obj and this event by time
        /// </summary>
        /// <param name="obj">the object compared with the current event</param>
        /// <returns>
        ///     1 if the obj is null
        ///     positive if the obj is earlier than the current event
        ///     negative if the obj is later than the current event
        ///     0 if the times are the same
        /// </returns>
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            if (obj is EventInformation otherEventInformation)
                return StartTime.CompareTo(otherEventInformation.StartTime);
            throw new ArgumentException("Object is not a EventInformation");
        }
    }
}