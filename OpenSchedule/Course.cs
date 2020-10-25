using System;
using System.Collections;
using System.Collections.Generic;

namespace OpenSchedule
{
    /// <summary>
    /// 
    /// </summary>
    public class Course : ICollection<EventInformation>
    {
        public string CourseName { get; }

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        private ICollection<EventInformation> CourseInfos = new List<EventInformation> {
        };
        private ICollection<EventInformation> ExamInfos = new List<EventInformation>();

        public Course(string courseName)
        {
            CourseName = courseName;
        }

        public void Add(EventInformation item)
        {
            //throw new NotImplementedException();

        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(EventInformation item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(EventInformation[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(EventInformation item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<EventInformation> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
