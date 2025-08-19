using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication.Array
{

    public class  ArrayCustomer
    {
    public string Name { get; set; }    
    public int Age { get; set; }    
    }

    public class ArrayProduct
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    internal class ArrayDemo
    {

        public void GetArray()
        {
            ArrayCustomer obj = new ArrayCustomer();
            obj.Name = "John";  
            obj.Age = 30;

            ArrayCustomer obj1 = new ArrayCustomer();
            obj1.Name = "John";
            obj1.Age = 30;

            ArrayProduct objProdyct= new ArrayProduct();    
            objProdyct.Name = "Product1";  
            objProdyct.Age = 5;

            ArrayList arrayList = new ArrayList();
            arrayList.Add(obj);
            arrayList.Add(obj1);
            arrayList.Add(objProdyct);
            arrayList.Add(4343);
            arrayList.Add("test");


               

            // not type safe
            // slow in performance 

            List<ArrayCustomer> customerList = new List<ArrayCustomer>();
            customerList.Add(obj);
            customerList.Add(obj1);
         

            //Generic list are type safe.
            // fast in performance  

        }
    }
}
