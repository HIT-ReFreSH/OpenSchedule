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
    ///     Represents a set of information of a course, including the teacher's
    ///     name, and the info of the event (classroom, start time and the
    ///     duration)
    /// </summary>
    public class CourseInformation : EventInformation, IEquatable<CourseInformation>
    {
        /// <summary>
        ///     Constructor of class CourseInformation
        /// </summary>
        /// <param name="room">
        ///     Location of the course
        /// </param>
        /// <param name="start">
        ///     Start time of the course（including date and time)
        /// </param>
        /// <param name="duration">
        ///     Duration of the course
        /// </param>
        /// <param name="teacherName">
        ///     Name of the teacher in the course
        /// </param>
        /// <param name="id">
        ///     Id of this event
        /// </param>
        public CourseInformation(string? room, DateTime start, TimeSpan duration,
            string teacherName, Guid id) : base(room, start,
            duration, id)
        {
            Teacher = teacherName;
        }

        /// <summary>
        ///     Teacher in this course
        /// </summary>
        public string Teacher { get; }

        /// <inheritdoc />
        public bool Equals(CourseInformation? other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;
            return Teacher == other.Teacher && EqualsCore(other);
        }

        /// <inheritdoc />
        public override object Clone()
        {
            return new CourseInformation(Classroom, StartTime, EventDuration, Teacher, EventId);
        }

        /// <inheritdoc />
        public override bool Equals(EventInformation? other)
        {
            if (other is CourseInformation ci) return Equals(ci);
            return false;
        }

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((CourseInformation) obj);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return HashCode.Combine(Teacher, EventId, Classroom, StartTime, EventDuration);
        }
    }
}