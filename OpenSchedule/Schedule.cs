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

using System.Collections.Generic;

namespace OpenSchedule
{
    /// <summary>
    ///     A complete schedule , containing all the course the owner has chosen
    /// </summary>
    public class Schedule
    {
        private readonly SortedSet<Course> _CourseSet = new SortedSet<Course>();

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
            return _CourseSet.Add(newCourse);
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
            return _CourseSet.Remove(course);
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
            return _CourseSet.Contains(course);
        }
    }
}