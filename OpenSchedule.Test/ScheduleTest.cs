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
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenSchedule.Test
{
    [TestClass]
    public class ScheduleTest
    {
        [TestMethod]
        public void ContentChanging()
        {
            var cons = new Schedule("test-schedule");
            var test = new Schedule("test-schedule");

            var course = new Course("test-course",new Guid());

            Assert.AreEqual(cons, test);

            Assert.IsFalse(test.Contains(course));

            Assert.IsTrue(test.AddNewCourse(course));
            Assert.IsFalse(test.AddNewCourse(course));

            Assert.IsTrue(test.Contains(course));

            Assert.AreNotEqual(cons, test);

            Assert.IsTrue(test.DeleteCourse(course));
            Assert.IsFalse(test.DeleteCourse(course));


            Assert.AreEqual(cons, test);

            Assert.IsFalse(test.Contains(course));

            Assert.IsTrue(test.AddNewCourse(course));

            Assert.IsTrue(test.Contains(course));
        }
    }
}
