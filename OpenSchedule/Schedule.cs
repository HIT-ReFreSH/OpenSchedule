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
using System.Collections.Generic;

namespace OpenSchedule
{
    /// <summary>
    ///     A complete schedule , containing all the course the owner has chosen
    /// </summary>
    public class Schedule
        : IEquatable<Schedule>
    {
        private readonly SortedSet<Course> _courseSet = new SortedSet<Course>();

        /// <summary>
        ///     Initialize a new instance of Schedule
        /// </summary>
        /// <param name="name">
        ///     Name of the owner's name of the schedule
        /// </param>
        public Schedule(string name)
        {
            UserName = name;
        }

        /// <summary>
        ///     Name of the user of the schedule
        /// </summary>
        public string UserName { get; }

        /// <inheritdoc />
        public bool Equals(Schedule? other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;
            return _courseSet.SetEquals(other._courseSet) && UserName == other.UserName;
        }


        /// <summary>
        ///     Add a new course to the CourseSet
        /// </summary>
        /// <param name="newCourse">
        ///     Course need to be added
        /// </param>
        /// <returns>
        ///     True if add successfully
        /// </returns>
        public bool AddNewCourse(Course newCourse)
        {
            return _courseSet.Add(newCourse);
        }

        /// <summary>
        ///     Delete a course in the CourseSet
        /// </summary>
        /// <param name="course">
        ///     Course need to be deleted
        /// </param>
        /// <returns>
        ///     True if delete successfully
        /// </returns>
        public bool DeleteCourse(Course course)
        {
            return _courseSet.Remove(course);
        }

        /// <summary>
        ///     Check if the course is already in the CourseSet
        /// </summary>
        /// <param name="course">
        ///     Course need to be checked
        /// </param>
        /// <returns>
        ///     True if it's been added
        /// </returns>
        public bool Contains(Course course)
        {
            return _courseSet.Contains(course);
        }

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((Schedule) obj);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return HashCode.Combine(_courseSet, UserName);
        }

        /// <summary>
        ///     Check if two schedules are having the same username, course-set.
        /// </summary>
        /// <returns>True if they have.</returns>
        public static bool operator ==(Schedule? first, Schedule? second)
        {
            return Equals(first, second);
        }

        /// <summary>
        ///     Check if two courses are not having the same username, course-set.
        /// </summary>
        /// <returns>True if they don't have.</returns>
        public static bool operator !=(Schedule? first, Schedule? second)
        {
            return !Equals(first, second);
        }
    }
}