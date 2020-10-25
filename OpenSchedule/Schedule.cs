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
using System.Collections;
using System.Collections.Generic;

namespace OpenSchedule
{
    public class ExistedCourseException : Exception
    {  
    }
    public class Schedule:ICollection<Course>
    {
        private string StudentName { get; }

        private IList<Course> Courses = new List<Course>();

        public int Count => throw new System.NotImplementedException();

        public bool IsReadOnly => throw new System.NotImplementedException();

        

        public void Add(Course item)
        {
            if (Courses.Contains(item))//The course has existed in the course list
            {
                throw new ExistedCourseException();
            }
            Courses.Add(item);
        
        }

        public void Clear()
        {
            //throw new System.NotImplementedException();

        }

        

        public bool Contains(Course item)
        {
            throw new System.NotImplementedException();
        }

        

        public void CopyTo(Course[] array, int arrayIndex)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerator<Course> GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        

        public bool Remove(Course item)
        {
            throw new System.NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        IEnumerator<Course> IEnumerable<Course>.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}