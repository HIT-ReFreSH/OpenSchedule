using System;
using System.Collections.Generic;
using System.Text;
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
