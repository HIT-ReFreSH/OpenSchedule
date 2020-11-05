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
    public class EqualityTest
    {
        [TestMethod]
        public void Course()
        {
            var id = new Guid();
            var cons = new Course("test-course", id);
            var test = new Course("test-course", id);

            Assert.IsTrue(cons.Equals(test));
            Assert.IsTrue((cons == test)==cons.Equals(test));
            Assert.IsTrue((cons != test) == !cons.Equals(test));

            cons = new Course("cons-course", id);
            Assert.IsFalse(cons.Equals(test));
            Assert.IsTrue((cons == test) == cons.Equals(test));
            Assert.IsTrue((cons != test) == !cons.Equals(test));

            
        }

        [TestMethod]
        public void Schedule()
        {
            var cons = new Schedule("test-schedule");
            var test = new Schedule("test-schedule");

            Assert.IsTrue(cons.Equals(test));
            Assert.IsTrue((cons == test) == cons.Equals(test));
            Assert.IsTrue((cons != test) == !cons.Equals(test));

            cons = new Schedule("cons-schedule");
            Assert.IsFalse(cons.Equals(test));
            Assert.IsTrue((cons == test) == cons.Equals(test));
            Assert.IsTrue((cons != test) == !cons.Equals(test));


        }

        [TestMethod]
        public void EventInfo()
        {
            var id = new Guid();
            var dt = DateTime.Now;
            EventInformation cons = new CourseInformation("test-room", dt, TimeSpan.Zero, "test-teacher", id);
            EventInformation test = new CourseInformation("test-room", dt, TimeSpan.Zero, "test-teacher", id);

            Assert.IsTrue(cons.Equals(test));
            Assert.IsTrue((cons == test) == cons.Equals(test));
            Assert.IsTrue((cons != test) == !cons.Equals(test));

            cons = new CourseInformation("cons-room", dt, TimeSpan.Zero, "test-teacher", id);
            Assert.IsFalse(cons.Equals(test));
            Assert.IsTrue((cons == test) == cons.Equals(test));
            Assert.IsTrue((cons != test) == !cons.Equals(test));

            cons = new ExamInformation("test-room", dt, TimeSpan.Zero, id);
            Assert.IsFalse(cons.Equals(test));
            Assert.IsTrue((cons == test) == cons.Equals(test));
            Assert.IsTrue((cons != test) == !cons.Equals(test));

            test = new ExamInformation("test-room", dt, TimeSpan.Zero, id);
            Assert.IsTrue(cons.Equals(test));
            Assert.IsTrue((cons == test) == cons.Equals(test));
            Assert.IsTrue((cons != test) == !cons.Equals(test));

            cons = new ExamInformation("cons-room", dt, TimeSpan.Zero, id);
            Assert.IsFalse(cons.Equals(test));
            Assert.IsTrue((cons == test) == cons.Equals(test));
            Assert.IsTrue((cons != test) == !cons.Equals(test));
        }
    }
}