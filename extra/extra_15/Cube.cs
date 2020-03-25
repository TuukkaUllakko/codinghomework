using System;
using System.Collections.Generic;
namespace extra_15
{
    public class Cube
    {
        private int edgeLength; //Variables
        private int volume;
        public Cube (int edgeLength) //Constructor
        {
            this.edgeLength = edgeLength;
        }
        public int Volume() //Methods
        {
            this.volume = this.edgeLength * this.edgeLength * this.edgeLength;
            return this.volume;
        }
        public override string ToString() //String representation for object
        {
            return "The length of the edge is " + this.edgeLength + " and the volume " + Volume();
        }
    }
}