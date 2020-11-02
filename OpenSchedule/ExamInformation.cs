using System;

namespace OpenSchedule
{
    public class ExamInformation : EventInformation
    {
        /// <summary>
        ///     the constructor
        /// </summary>
        /// <param name="room"></param>
        /// <param name="start"></param>
        /// <param name="duration"></param>
        public ExamInformation(string room, DateTime start, TimeSpan duration) : base(room, start, duration)
        {
        }
    }
}