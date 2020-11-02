using System;

namespace OpenSchedule
{
    public class CourseInformation : EventInformation
    {
        /// <summary>
        ///     The info of a course,including the teacher's name,and the info of the event(classroom,start time and the duration)
        ///     继承自类EventInformation，表示一个课程。内容包括：教师名称 Teacher，以及父类的变量Classroom, StartTime, Duration
        ///     注意，这里的CourseInformation仅表示某一天的某一节课，而不是某一门课的全部信息。
        ///     如果要实现某一门课的信息集合，请移步类Course。
        /// </summary>
        public string Teacher { get; }


        /// <summary>
        ///     constructor of class CourseInfomation
        /// </summary>
        /// <param name="room">the location of the course</param>
        /// <param name="start">the startime of the course（including date and time)</param>
        /// <param name="duration">the duration of the course</param>
        /// <param name="teacherName">the name of the teacher of the course</param>
        public CourseInformation(string room, DateTime start, TimeSpan duration, string teacherName) : base(room, start,
            duration)
        {
            Teacher = teacherName;
        }

        
    }
}