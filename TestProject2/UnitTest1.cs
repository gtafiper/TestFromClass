using System;
using System.Data;
using NUnit.Framework;
using Test_techniqes;

namespace Tests
{
    public class Tests
    {
        public Cal Cal = new Cal();
        
        
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test1()
        {
            int procent = 5;
            var grade = -3;
            Assert.AreEqual(grade, Cal.ToGrade(procent));
        }
        [Test]
        public void Test2()
        {
            int procent = 0;
            var grade = -3;
            Assert.AreEqual(grade, Cal.ToGrade(procent));
        }
        [Test]
        public void Test3()
        {
            int procent = 6;
            var grade = 0;
            Assert.AreEqual(grade, Cal.ToGrade(procent));
        }
        [Test]
        public void Test4()
        {
            int procent = 49;
            var grade = 0;
            Assert.AreEqual(grade, Cal.ToGrade(procent));
        }
        [Test]
        public void Test5()
        {
            int procent = 50;
            var grade = 2;
            Assert.AreEqual(grade, Cal.ToGrade(procent));
        }
        [Test]
        public void Test6()
        {
            int procent = 59;
            var grade = 2;
            Assert.AreEqual(grade, Cal.ToGrade(procent));
        }
        [Test]
        public void Test7()
        {
            int procent = 60;
            var grade = 4;
            Assert.AreEqual(grade, Cal.ToGrade(procent));
        }
        [Test]
        public void Test8()
        {
            int procent = 79;
            var grade = 4;
            Assert.AreEqual(grade, Cal.ToGrade(procent));
        }
        [Test]
        public void Test9()
        {
            int procent = 80;
            var grade = 7;
            Assert.AreEqual(grade, Cal.ToGrade(procent));
        }
        [Test]
        public void Test10()
        {
            int procent = 84;
            var grade = 7;
            Assert.AreEqual(grade, Cal.ToGrade(procent));
        }
        [Test]
        public void Test11()
        {
            int procent = 85;
            var grade = 10;
            Assert.AreEqual(grade, Cal.ToGrade(procent));
        }
        [Test]
        public void Test12()
        {
            int procent = 94;
            var grade = 10;
            Assert.AreEqual(grade, Cal.ToGrade(procent));
        }
        
        [Test]
        public void Test13()
        {
            int procent = 95;
            var grade = 12;
            Assert.AreEqual(grade, Cal.ToGrade(procent));
        }
        [Test]
        public void Test14()
        {
            int procent = 100;
            var grade = 12;
            Assert.AreEqual(grade, Cal.ToGrade(procent));
        }
        
        [Test]
        public void Test15()
        {
            int procent = 1000;
            Assert.Throws<DataException>(() => Cal.ToGrade(procent));

        }

        [Test]
        public void TestAge19()
        {
            DateTime Bday= new DateTime(2001, 09, 1);
            
            Assert.True(Cal.IsTeenager(Bday));
        }
        
        [Test]
        public void TestAge12()
        {
            DateTime Bday= new DateTime(2007, 1, 1);
            
            Assert.False(Cal.IsTeenager(Bday));
        }
        
        [Test]
        public void TestAge13()
        {
            DateTime Bday= new DateTime(2006, 01, 1);
            
            Assert.True(Cal.IsTeenager(Bday));
        }
        
        [Test]
        public void TestAge20()
        {
            DateTime Bday= new DateTime(1999, 1, 1);
            
            Assert.False(Cal.IsTeenager(Bday));
        }
        
        
    }
}