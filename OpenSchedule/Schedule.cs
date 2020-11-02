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
    public class Schedule
    {
        private readonly ISet<Course> CourseSet = new SortedSet<Course>();

        /// <summary>
        ///     constructor
        /// </summary>
        /// <param name="name">the name of the student</param>
        public Schedule(string name)
        {
            StudentName = name;
        }

        /// <summary>
        ///     the schedule of a student, containing all the course of the student.
        ///     某个人的课程表，是他所需要上的所有课程的集合。
        /// </summary>
        private string StudentName { get; }

        /// <summary>
        ///     get the name of the student
        /// </summary>
        /// <returns>
        ///     <the name of the student/ returns>
        public string GetStudentName()
        {
            return StudentName;
        }

        /// <summary>
        ///     add a new course to the CourseSet
        /// </summary>
        /// <param name="newCourse">the Course need to be added</param>
        /// <returns></returns>
        public bool AddNewCourse(Course newCourse)
        {
            return CourseSet.Add(newCourse);
        }

        /// <summary>
        ///     delete a course in the CourseSet
        /// </summary>
        /// <param name="course">the Course need to be deleted</param>
        /// <returns></returns>
        public bool DeleteCourse(Course course)
        {
            return CourseSet.Remove(course);
        }

        /// <summary>
        ///     check if the course is already in the CourseSet
        /// </summary>
        /// <param name="course">true if it's been added;else false</param>
        /// <returns></returns>
        public bool Contains(Course course)
        {
            return CourseSet.Contains(course);
        }
    }
}