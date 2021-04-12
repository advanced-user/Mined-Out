﻿namespace Engine.Models
{
    public struct Coordinates
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Coordinates(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}