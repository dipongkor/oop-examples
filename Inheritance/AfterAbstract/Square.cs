﻿namespace Inheritance.AfterAbstract
{
    public class Square : Rectangle
    {
        public Square()
            : base()
        {

        }
        public Square(float side)
            : base(side, side)
        {

        }
        public Square(float side, string color, bool filled)
            : base(side, side, color, filled)
        {

        }
        public override string ToString() => $"Color = {Color}, Filled = {Filled}, Side = {Length}";
    }
}
