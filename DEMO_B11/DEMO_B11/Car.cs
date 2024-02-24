using System;
using System.Collections.Generic;
using System.Text;
using DEMO_B11;

namespace DEMO_B11
{
    class Car
    {

        

        // DATA
        // Accessmodifier
        private int height;
        private string color;

        public int Height
        {
            get { return height; }

            set
            {
                if (value >= 2000)
                {
                    height = 2000;
                }
                else
                {
                    height = value;

                }

            }
        }

        public string Color
        {
            get { return color; }

            set { color = value; }
        }


        //public int Height;
        //public string Color;

        int Length;
        int Width;



        // Behaviour
        //Key, PushButton

        public void Start(int key)
        {

            Console.WriteLine("Car => Height- {0}, Color- {1}", height, color);
            Console.WriteLine("Car Start..!!");
        }

        public int Start(int abc, int k1)
        {
            Console.WriteLine("Car => Height- {0}, Color- {1}", abc, color);
            Console.WriteLine("Car Start..!!");
            return 1;
        }

        public void Stop()
        {
            Console.WriteLine("Car => Height- {0}, Color- {1}", height, color);
            Console.WriteLine("Car Stop..!!");
        }
    }

    class TataCar : Car
    {
        public void EngineStart() { }
    }

    class MarutiCar : Car
    {
        public void EngineStart() { }
    }

    class TATAEVCar : TataCar { 
    }
}
