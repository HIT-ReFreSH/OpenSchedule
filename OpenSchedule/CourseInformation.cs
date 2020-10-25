using System;
namespace OpenSchedule
{
    public class CourseInformation:EventInformation
    {
        public string Teacher { get;}
        public CourseInformation(string room,DateTime start,TimeSpan duration,string teacherName):base(room,start,duration)
        {
            Teacher = teacherName;
        }
    }
}
