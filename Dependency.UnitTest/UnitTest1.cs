using NUnit.Framework;

namespace Dependency.UnitTest
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestWothDemmy()
        {
            var dependency = new DemmyDependency();
            var dependent = new Dependent(dependency);
            const string param = "abc";
            const int expectedResultOne = 1;
            var resultOne = dependent.GetValue(param);
            Assert.AreEqual(expectedResultOne, resultOne);
        }
    }
    [TestFixture]
    public class StubTest
    {
        [Test]
        public void TestWithAStub()
        {
            var dependency = new StubDependency();
            var dependent = new Dependent(dependency);
            const string param1 = "abc";
            const string param2 = "xyz";
            const int expectedResultOne = 1;
            const int expectedResultTwo = 2;
            var resultOne = dependent.GetValue(param1);
            var resultTwo = dependent.GetValue(param2);
            Assert.AreEqual(expectedResultOne, resultOne);
            Assert.AreEqual(expectedResultTwo, resultTwo);
        }
    }
    public class MockDependency : IDependency
    {
        private int _callMeTwiceCalled;
        private bool _callMeFirstCalled;
        private bool _callMeLastCalled;
        public void CallMeFirst()
        {
            if (_callMeTwiceCalled > 0 || _callMeFirstCalled)
                throw new AssertionException("CallMeFirst not first menthod called");
            _callMeFirstCalled = true;
        }

        public int CallMeTwice(string param)
        {
            if (!_callMeFirstCalled)
                throw new AssertionException("CallMeTwice before CallMeFirst Called");
            if (_callMeLastCalled)
                throw new AssertionException("CallMeTwice after CallMeLast Called");
            if (_callMeTwiceCalled > 2)
                throw new AssertionException("CallMeTwice called more than Twice");
            _callMeTwiceCalled++;
            return GetValue(param);
        }

        public void ClassMeLast()
        {
            if (!_callMeFirstCalled)
                throw new AssertionException("CallMeLast called before CallMeFirst");
            if (_callMeTwiceCalled != 2)
                throw new AssertionException(
                string.Format("CallMeTwice not called {0} times", _callMeTwiceCalled));
            _callMeLastCalled = true;
        }
        public int GetValue(string param)
        {
            if (param == "abc")
                return 1;
            if (param == "xyz")
                return 2;
            return 0;
        }
    }




    public class StubDependency : IDependency
    {
        public void CallMeFirst()
        {
            throw new System.NotImplementedException();
        }

        public int CallMeTwice(string param)
        {
            throw new System.NotImplementedException();
        }

        public void ClassMeLast()
        {
            throw new System.NotImplementedException();
        }

        public int GetValue(string param)
        {
            if (param == "abc")
            {
                return 1;
            }
            else if (param == "xyz")
            {
                return 2;
            }
            return 0;
        }
    }

    internal class Dependent
    {
        private readonly IDependency _dependency;
        public Dependent(IDependency dependency)
        {
            _dependency = dependency;
        }
        public int GetValue(string s)
        {
            return _dependency.GetValue(s);
        }
        public void CallMeFirst()
        {
            _dependency.CallMeFirst();
        }
        public int CallMeTwice(string param)
        {
            return _dependency.CallMeTwice(param);
        }
        public void CallMeLast()
        {
            _dependency.ClassMeLast();
        }
    }
    internal interface IDependency
    {
        int GetValue(string param);
        void CallMeFirst();
        int CallMeTwice(string param);
        void ClassMeLast();
    }
    public class DemmyDependency : IDependency
    {
        public void CallMeFirst()
        {
            throw new System.NotImplementedException();
        }

        public int CallMeTwice(string param)
        {
            throw new System.NotImplementedException();
        }

        public void ClassMeLast()
        {
            throw new System.NotImplementedException();
        }

        public int GetValue(string param)
        {
            return 1;
        }
    }

}