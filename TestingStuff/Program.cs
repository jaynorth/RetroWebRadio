using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingStuff
{
    class Program
    {
        static void Main(string[] args)
        {

            A a = new A();

            


            B b = new B();



            foreach (var item in b.listINT)
            {
                Console.WriteLine(item);
            } 

        }
    }

    public class A
    {
        public A()
        {
            _nList = new List<int>();
            _nList.Add(2);
            _nList.Add(4);
            _nList.Add(6);

        }

        private List<int> _nList  ;

        public List<int>    NList
        {
            get { return _nList; }
            set { _nList = value; }
        }

     
    }

    public class B
    {

        public B()
        {
            A aa = new A();

            List<int> listINT = new List<int>(aa.NList);
        }

        public List<int> listINT { get; set; }


    }
}
