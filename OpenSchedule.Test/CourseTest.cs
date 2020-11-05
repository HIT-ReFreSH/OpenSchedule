using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

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
