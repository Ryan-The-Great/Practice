using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class VarScope
    {
        public static void Test()
        {
            MyClass m = new MyClass(111);
            MyObj o = null;
            MyObj o2 = new MyObj(999);
            trySet(m);
            Console.WriteLine("result=" + m.val);
            m.setClassVar(o);
            m.setClassVar2(o2);
            Console.WriteLine(o);

            int[] a = null;
            trySet2(a);
            Console.WriteLine(String.Join(",", a));

            int[] a2 = new int[] { 1, 2, 3, 4 };
            trySet3(a2);
            Console.WriteLine(String.Join(",", a2));
        }

        public static void trySet(MyClass c)
        {
            if (c == null)
            {
                c = new MyClass(4);
                Console.WriteLine("trySet result=" + c.val);
            }
        }

        public static void trySet2(int[] ary)
        {
            ary = new int[] { 2, 3, 4, 5 };
            Console.WriteLine(String.Join(",", ary));
        }

        public static void trySet3(int[] ary)
        {
            ary[1] = 999;
        }
    }

    public class MyClass
    {
        public int val;
        public MyObj obj;

        public void setClassVar(MyObj obj)
        {
            if (obj == null)
                obj = new MyObj(777);
        }

        public void setClassVar2(MyObj obj)
        {
            this.obj = obj;
        }


        public MyClass(int val)
        {
            this.val = val;
        }
    }

    public class MyObj
    {
        public int val;

        public MyObj(int val)
        {
            this.val = val;
        }
    }
}
