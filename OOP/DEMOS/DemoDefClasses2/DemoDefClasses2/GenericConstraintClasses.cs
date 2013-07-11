using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDefClasses2
{
    class TestClass1:BaseClass,IInterface
    {
    }
    class TestClass2 : BaseClass
    { 
    }
    class TestClass3 : BaseClass, IInterface
    {
        public TestClass3(int param)
        { }
    }

    class BaseClass 
    {}
    interface IInterface
    {}

    class GenericConstraintClass<T>
        where T:BaseClass,IInterface,new()
    {
        public T method1(T param)
        {
            return param;
        }
    }
}
