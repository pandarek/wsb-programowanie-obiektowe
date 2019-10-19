using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Cars
{
    class Car
    {
        private string _brand;
        private string _model;
        private Engine _engine;

        public static int distance;
        
        public void go(int distance)
        {
            Console.WriteLine("Jadę");
            
            Thread.Sleep(distance*100);
            Console.WriteLine("Jestem");

        }


    }


}
