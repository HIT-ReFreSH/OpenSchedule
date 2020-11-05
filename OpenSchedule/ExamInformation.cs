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
    ///     Represents an examination in a Course
    /// </summary>
    public class ExamInformation : EventInformation, IEquatable<ExamInformation>
    {
        /// <summary>
        ///     Constructor
        /// </summary>
        /// <param name="room">
        ///     Location of the exam
        /// </param>
        /// <param name="start">
        ///     Start time of the exam
        /// </param>
        /// <param name="duration">
        ///     Duration of the exam
        /// </param>
        /// <param name="id">
        ///     Id of this event
        /// </param>
        public ExamInformation(string? room, DateTime start, TimeSpan duration,Guid id) :
            base(room, start, duration,id)
        {
        }

        /// <inheritdoc/>
        public override object Clone()
            => new ExamInformation(Classroom, StartTime, EventDuration, EventId);
        /// <inheritdoc/>
        public override bool Equals(EventInformation? other)
        {
            return other is ExamInformation ei && Equals(ei);
        }
        /// <inheritdoc/>
        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
        /// <inheritdoc/>
        public bool Equals(ExamInformation? other)
        {
            return other != null && EqualsCore(other);
        }
        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((ExamInformation) obj);
        }
    }
}