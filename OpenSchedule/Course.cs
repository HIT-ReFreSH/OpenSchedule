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
using System.Linq;

namespace OpenSchedule
{
    /// <summary>
    ///     Represents a course selected by the schedule user in the educational
    ///     administration system, contains a number of course information and
    ///     examination information
    /// </summary>
    public class Course
    {
        private readonly SortedSet<CourseInformation> _CourseSet = new SortedSet<CourseInformation>();

        private readonly SortedSet<ExamInformation> _ExamSet = new SortedSet<ExamInformation>();

        /// <summary>
        ///     Initialize a new instance of Course.
        /// </summary>
        /// <param name="name">
        ///     Name of the course
        /// </param>
        public Course(string name)
        {
            CourseName = name;
            CourseId = Guid.NewGuid();
        }

        /// <summary>
        ///     Name of this course
        /// </summary>
        public string CourseName { get; }

        /// <summary>
        ///     Id of this course
        /// </summary>
        public Guid CourseId { get; }


        /// <summary>
        ///     Add a new course event to the course
        /// </summary>
        /// <param name="newCourse">
        ///     Course need to be added
        /// </param>
        /// <returns>
        ///     True if delete successfully
        /// </returns>
        public bool AddCourse(CourseInformation newCourse)
        {
            return _CourseSet.Add(newCourse);
        }

        /// <summary>
        ///     Delete a course event from the course
        /// </summary>
        /// <param name="courseToDelete">
        ///     Course need to be deleted
        /// </param>
        /// <returns>
        ///     True if delete successfully
        /// </returns>
        public bool DeleteCourse(CourseInformation courseToDelete)
        {
            return _CourseSet.Remove(courseToDelete);
        }


        /// <summary>
        ///     Add a new exam event to the course
        /// </summary>
        /// <param name="newExam">
        ///     Exam need to be added
        /// </param>
        /// <returns>
        ///     True if add successfully
        /// </returns>
        public bool AddExam(ExamInformation newExam)
        {
            return _ExamSet.Add(newExam);
        }

        /// <summary>
        ///     Delete a exam event from the course
        /// </summary>
        /// <param name="examToDelete">
        ///     Exam need to be deleted
        /// </param>
        /// <returns>
        ///     True if delete successfully
        /// </returns>
        public bool DeleteCourse(ExamInformation examToDelete)
        {
            return _ExamSet.Remove(examToDelete);
        }

        /// <summary>
        ///     Check if the event has been added to the course
        /// </summary>
        /// <param name="eventInfo">
        ///     Event need to be checked
        /// </param>
        /// <returns>
        ///     True if it's been added already
        /// </returns>
        public bool Contains(EventInformation eventInfo)
        {
            return _CourseSet.Contains(eventInfo) || _ExamSet.Contains(eventInfo);
        }
    }
}