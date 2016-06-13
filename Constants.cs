﻿using System.Windows;

namespace academy_project
{
    public static class Constants
    {
        public const int Height = 500;
        public const int Width = 700;
        public const int TimeSpan = 10;
        public const double PlayerSpeed = 1.0;
        public const double TimeSpeedMultiplier = 20;
        public static readonly Size PlayerSize = new Size(30, 30);
        public static readonly Size BallSize = new Size(20, 20);
        public static readonly Point StartingBallPosition = 
            new Point(Width/2 - (BallSize.Width/2)+7, Height/2 - (BallSize.Height/2)-1);
    }
}
