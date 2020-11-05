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

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace OpenSchedule.Test
{
    [TestClass]
    public class CourseTest
    {
        [TestMethod]
        public void ContentChanging()
        {
            var id = new Guid();
            var cons = new Course("test-course",id);
            var test= new Course("test-course",id);
            var course = new CourseInformation("test-room", DateTime.Now, TimeSpan.Zero, "test-teacher", id);
            var exam = new ExamInformation("test-room", DateTime.Now, TimeSpan.Zero, id);

            Assert.AreEqual(cons, test);

            Assert.IsFalse(test.Contains(course));
            Assert.IsFalse(test.Contains(exam));

            Assert.IsTrue(test.AddCourse(course));
            Assert.IsFalse(test.AddCourse(course));

            Assert.IsTrue(test.Contains(course));
            Assert.IsFalse(test.Contains(exam));

            Assert.IsTrue(test.AddExam(exam));
            Assert.IsFalse(test.AddExam(exam));

            Assert.IsTrue(test.Contains(course));
            Assert.IsTrue(test.Contains(exam));

            Assert.AreNotEqual(cons, test);

            Assert.IsTrue(test.DeleteCourse(course));
            Assert.IsFalse(test.DeleteCourse(course));

            Assert.IsTrue(test.DeleteExam(exam));
            Assert.IsFalse(test.DeleteExam(exam));

            Assert.AreEqual(cons, test);

            Assert.IsFalse(test.Contains(course));
            Assert.IsFalse(test.Contains(exam));

            Assert.IsTrue(test.AddCourse(course));
            Assert.IsTrue(test.AddExam(exam));

            Assert.IsTrue(test.Contains(course));
            Assert.IsTrue(test.Contains(exam));


        }
    }
}
