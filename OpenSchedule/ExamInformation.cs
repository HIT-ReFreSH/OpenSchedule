using System;
namespace OpenSchedule
{
    public class ExamInformation:EventInformation
    {
        public ExamInformation(string room, DateTime start, TimeSpan duration) :base(room,start,duration)
        {
        }
    }
}
