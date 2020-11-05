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
    /// <summary>
    ///     Represents a set of information of an event,
    ///     including classroom(the location of a class),
    ///     the start time of the course and the duration of the course.
    /// </summary>
    public abstract class EventInformation : IComparable, IComparable<EventInformation>, ICloneable,
        IEquatable<EventInformation>
    {
        /// <summary>
        ///     Initialize a new instance of EventInformation with the
        ///     specified EventId, only used in method Clone()
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
        /// <param name="id">
        ///     Id of this event
        /// </param>
        protected EventInformation(string? room, DateTime start, TimeSpan duration, Guid id)
        {
            Classroom = room;
            StartTime = start;
            EventDuration = duration;
            EventId = id;
        }

        /// <summary>
        ///     Id of this event
        /// </summary>
        public Guid EventId { get; }

        /// <summary>
        ///     Location of this event, NULL if no such information provided.
        /// </summary>
        public string? Classroom { get; }

        /// <summary>
        ///     Start time of this event
        /// </summary>
        public DateTime StartTime { get; }

        /// <summary>
        ///     Duration of this event
        /// </summary>
        public TimeSpan EventDuration { get; }


        /// <summary>
        ///     Get a new Event typed object same with this event
        /// </summary>
        /// <returns>
        ///     An object same with the current event
        /// </returns>
        public abstract object Clone();


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
        public int CompareTo(object? obj)
        {
            if (obj == null) throw new NullReferenceException();

            if (obj is EventInformation otherEventInformation)
                return CompareTo(otherEventInformation);

            throw new ArgumentException("Object is not a EventInformation", nameof(obj));
        }

        /// <inheritdoc />
        public int CompareTo(EventInformation? other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (other is null) return 1;
            var classroomComparison = string.Compare(Classroom, other.Classroom, StringComparison.Ordinal);
            if (classroomComparison != 0) return classroomComparison;
            var startTimeComparison = StartTime.CompareTo(other.StartTime);
            return startTimeComparison != 0 ? startTimeComparison : EventDuration.CompareTo(other.EventDuration);
        }

        /// <inheritdoc />
        public abstract bool Equals(EventInformation? other);

        /// <summary>
        ///     Check if this and the other event are having same time, teacher, duration.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        protected bool EqualsCore(EventInformation other)
        {
            return Equals(Classroom, other.Classroom)
                   && Equals(StartTime, other.StartTime)
                   && Equals(EventDuration, other.EventDuration)
                   && Equals(EventId, other.EventId);
        }

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((EventInformation) obj);
        }

        /// <inheritdoc />
        public abstract override int GetHashCode();

        /// <summary>
        ///     Check if two events are having same type(class or exam), time, teacher, etc.
        /// </summary>
        /// <returns>True if they have.</returns>
        public static bool operator ==(EventInformation? first, EventInformation? second)
        {
            return Equals(first, second);
        }

        /// <summary>
        ///     Check if two events are not having same type(class or exam), time, teacher, etc.
        /// </summary>
        /// <returns>True if they don't have.</returns>
        public static bool operator !=(EventInformation? first, EventInformation? second)
        {
            return !Equals(first, second);
        }
    }
}