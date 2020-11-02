using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace OpenSchedule
{
    /// <summary>
    /// 
    /// </summary>
    public class Course
    {

        /// <summary>
        /// A course, containing a set of eventInformation(including courseInformation and examInformation)
        /// 一门课程，实际为若干课程信息和考试信息的集合
        /// </summary>
        private string CourseName { get; }
        private string CourseId { get; }

        private readonly ISet<CourseInformation> CourseSet = new SortedSet<CourseInformation>();

        private readonly ISet<ExamInformation> ExamSet = new SortedSet<ExamInformation>();

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">the name of the course</param>
        public Course(string name, string IdNum)
        {
            this.CourseName = name;
            this.CourseId = IdNum;
        }

        /// <summary>
        /// get the name of the course
        /// </summary>
        /// <returns>the name of the course</returns>
        public string GetCourseName()
        {
            return this.CourseName;
        }

        /// <summary>
        /// get the Id of the Course
        /// </summary>
        /// <returns>the Id of the Course</returns>
        public string GetCourseId()
        {
            return this.CourseId;
        }

        /// <summary>
        /// add a new course event to the course
        /// </summary>
        /// <param name="newCourse">the course need to be added</param>
        /// <returns>true if delete successfully ; else false</returns>
        public bool AddCourse(CourseInformation newCourse)
        {
            return CourseSet.Add(newCourse);
        }

        /// <summary>
        /// delete a course event from the course
        /// </summary>
        /// <param name="courseToDelete">the course need to be deleted</param>
        /// <returns>true if delete successfully; else false</returns>
        public bool DeleteCourse(CourseInformation courseToDelete)
        {
            return CourseSet.Remove(courseToDelete);
        }


        /// <summary>
        /// add a new exam event to the course
        /// </summary>
        /// <param name="newExam">the exam need to be added</param>
        /// <returns>true if add successfully; else false</returns>
        public bool AddExam(ExamInformation newExam)
        {
            return ExamSet.Add(newExam);
        }

        /// <summary>
        /// delete a exam event from the course
        /// </summary>
        /// <param name="examToDelete"></param>
        /// <returns>true if delete successfully; else flase</returns>
        public bool DeleteCourse(ExamInformation examToDelete)
        {
            return ExamSet.Remove(examToDelete);
        }

        /// <summary>
        /// check if the event has been added to the course
        /// </summary>
        /// <param name="eventInfo">the event need to be checked</param>
        /// <returns>true if it's been added already;else false</returns>
        public bool Contains(EventInformation eventInfo)
        {
            return CourseSet.Contains(eventInfo) || ExamSet.Contains(eventInfo);
        }
        
    }
}
