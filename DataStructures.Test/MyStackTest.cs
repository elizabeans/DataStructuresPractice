using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructures.Test
{
    [TestClass]
    public class MyStackTest
    {
        [TestMethod]
        public void NewStackIsEmpty()
        {
            var testStack = new MyStack<string>();

            Assert.IsTrue(testStack.IsEmpty());
        }

        [TestMethod]
        public void StackIsFull()
        {
            var testStack = new MyStack<string>(5);

            testStack.Push("I");
            testStack.Push("am");
            testStack.Push("testing");
            testStack.Push("this");
            testStack.Push("stack");

            Assert.IsTrue(testStack.IsFull());
        }
    }
}
