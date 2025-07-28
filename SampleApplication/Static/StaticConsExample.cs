using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication.Static
{
    //  Constroct call in TOPS to Down

    //static cons call in down to TOP
    // static cons calls only one time not every time when we create object of class
    public class StaticConsExample
    {
        public string connextion { get; set; } 
        static StaticConsExample()
        {
            //db call
           

            Console.WriteLine("Inside static StaticConsExample");
        }

        public StaticConsExample()
        {
           
            //DB call  Loading some configurtions 
            Console.WriteLine("Inside StaticConsExample");
        }


    }
    public class StaticConsExampleChild_1 : StaticConsExample
    {
        static StaticConsExampleChild_1()
        {
            Console.WriteLine("Inside static StaticConsExampleChild_1");
        }
        public StaticConsExampleChild_1()
        {
            Console.WriteLine("Inside StaticConsExampleChild_1");
        }


    }
    public class StaticConsExampleChild_2 : StaticConsExampleChild_1
    {

        static StaticConsExampleChild_2()
        {
            Console.WriteLine("Inside static StaticConsExampleChild_2");
        }
        public StaticConsExampleChild_2()
        {
            Console.WriteLine("Inside StaticConsExampleChild_2");
        }


    }

    /* 
 StaticConsExampleChild_2 obj = new StaticConsExampleChild_2();

Inside static StaticConsExampleChild_2
Inside static StaticConsExampleChild_1
Inside static StaticConsExample
Inside StaticConsExample
Inside StaticConsExampleChild_1
Inside StaticConsExampleChild_2


    ========================================

    // static cons calls only one time not every time when we create object of class

 StaticConsExample staticObj = new  StaticConsExample();
StaticConsExample staticObj1 = new StaticConsExample();
StaticConsExample staticObj2 = new StaticConsExample();
StaticConsExample staticObj3 = new StaticConsExample();

    OUT
Inside static StaticConsExample
Inside StaticConsExample
Inside StaticConsExample
Inside StaticConsExample
Inside StaticConsExample


     */
}
