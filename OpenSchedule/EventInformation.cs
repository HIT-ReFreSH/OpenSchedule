/*
Copyright 2020 ReFreSH

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using System;

namespace OpenSchedule
{
    public class EventInformation : IComparable, ICloneable
    {
        /// <summary>
        ///     Constructor of class EventInformation
        /// </summary>
        /// <param name="room">
        ///     Location of the event
        /// </param>
        /// <param name="start">
        ///     Start time of the event
        /// </param>
        /// <param name="duration">
        ///     Duration of the event
        /// </param>
        public EventInformation(string room, DateTime start, TimeSpan duration)
        {
            Classroom = room;
            StartTime = start;
            EventDuration = duration;
            EventId = Guid.NewGuid();
        }

        /// <summary>
        ///     Constructor of class EventInformation, only used in method clone()
        /// </summary>
        /// <param name="room">
        ///     Location of this event
        /// </param>
        /// <param name="start">
        ///     Start time of this event
        /// </param>
        /// <param name="duration">
        ///     Duration of this event
        /// </param>
        /// <param name="Id">
        ///     Id of this event
        /// </param>
        private EventInformation(string room, DateTime start, TimeSpan duration, Guid Id)
        {
            Classroom = room;
            StartTime = start;
            EventDuration = duration;
            EventId = Id;
        }


        /// <summary>
        ///     The info of an event, including classroom(the location of a class),
        ///     the start time of the course and the duration of the course.
        /// </summary>
        public Guid EventId { get; }

        public string Classroom { get; }
        public DateTime StartTime { get; }
        public TimeSpan EventDuration { get; }

        /// <summary>
        ///     Get a new Event same with this event
        /// </summary>
        /// <returns>
        ///     An object same with the current event
        /// </returns>
        public object Clone()
        {
            return new EventInformation(Classroom, StartTime, EventDuration, EventId);
        }

        /// <summary>
        ///     Compare the input obj and this event by time
        /// </summary>
        /// <param name="obj">
        ///     Object compared with the current event
        /// </param>
        /// <returns>
        ///     Throw a NullReferenceException if obj is null
        ///     Positive if the obj is earlier than the current event
        ///     Negative if the obj is later than the current event
        ///     0 if the two times are the same
        /// </returns>
        public int CompareTo(object obj)
        {
            if (obj == null) throw new NullReferenceException();

            if (obj is EventInformation otherEventInformation)
                return StartTime.CompareTo(otherEventInformation.StartTime);

            throw new ArgumentException("Object is not a EventInformation");
        }
    }
}