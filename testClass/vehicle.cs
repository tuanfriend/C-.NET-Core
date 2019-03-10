using System;

namespace testClass
{
    class Vehicle
    {

        private int MaxnumPass;
        private string color;
		
        public Vehicle(int maxnum, string col)
        {
            MaxnumPass = maxnum;
            color = col;
        }

        public void fixcar(int maxnum, string col)
        {
            MaxnumPass = maxnum;
            color = col;
        }
        public int maxNumpass
        {
            get { return MaxnumPass; }
        }
        public string COLOR
        {
            get { return color; }
        }

    }
}