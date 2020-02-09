using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    public class Class1
    {
        // Class is collection of Objects,Variable,Method
        iClassA a = new ClassA();
        ClassB ab = new ClassB();

        public Class1()
        {
            a.data();
        }
        public int test()
        {
            int a = ab.data();
          return  ab.datanew();
        }
    }
    public class ClassA : iClassA
    {
        //public ClassA()
        //{

        //}
        public int a()
        {
            return 1;
        }
        public int data()
        {
            int sum;
            int a = 10;
            int b = 10;
            sum = a + b;
            return sum;
        }
    }
    interface iClassA
    {
        int a();
        int data();
    }
    public class ClassB : ClassA, iClassA
    {
        public int abc()
        {
            return 0;
        }
        public int datanew()
        {
            int a =1;
            return a;
        }


    }

}
