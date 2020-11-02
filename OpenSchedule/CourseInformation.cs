using System;
namespace OpenSchedule
{
    public class CourseInformation:EventInformation
    {
        /// <summary>
        /// The info of a course,including the teacher's name,and the info of the event(classroom,start time and the duration)
        /// </summary>
        public string Teacher { get;}
        /// <summary>
        /// constructor of class CourseInfomation
        /// </summary>
        /// <param name="room">the location of the course</param>
        /// <param name="start">the startime of the course</param>
        /// <param name="duration">the duration of the course</param>
        /// <param name="teacherName">the name of the teacher of the course</param>
        public CourseInformation(string room,DateTime start,TimeSpan duration,string teacherName):base(room,start,duration)
        {
            Teacher = teacherName;
        }
    }
}
