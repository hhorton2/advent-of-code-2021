using System;

namespace AdventOfCode2021.Day08.Models
{
    public class SevenSegmentDisplay
    {
        public bool TopRight { get; set; }
        public bool TopLeft { get; set; }
        public bool BottomRight { get; set; }
        public bool BottomLeft { get; set; }
        public bool Middle { get; set; }
        public bool Top { get; set; }
        public bool Bottom { get; set; }

        public bool isValid()
        {
            return One || Two || Three || Four || Five || Six || Seven || Eight || Nine || Zero;
        }

        public string GetNumericValue()
        {
            if (One)
            {
                return "1";
            }

            if (Two)
            {
                return "2";
            }

            if (Three)
            {
                return "3";
            }

            if (Four)
            {
                return "4";
            }

            if (Five)
            {
                return "5";
            }

            if (Six)
            {
                return "6";
            }

            if (Seven)
            {
                return "7";
            }

            if (Eight)
            {
                return "8";
            }

            if (Nine)
            {
                return "9";
            }

            if (Zero)
            {
                return "0";
            }

            return "OMG ERROR AHHHHHH";
        }

        private int TotalLit()
        {
            return Convert.ToInt32(TopRight) +
                   Convert.ToInt32(BottomRight) +
                   Convert.ToInt32(TopLeft) +
                   Convert.ToInt32(BottomLeft) +
                   Convert.ToInt32(Middle) +
                   Convert.ToInt32(Bottom) +
                   Convert.ToInt32(Top);
        }

        private bool One => TopRight && BottomRight && TotalLit() == 2;
        private bool Two => Top && TopRight && Middle && BottomLeft && Bottom && TotalLit() == 5;
        private bool Three => Top && TopRight && Middle && BottomRight && Bottom && TotalLit() == 5;
        private bool Four => TopRight && TopLeft && Middle && BottomRight && TotalLit() == 4;
        private bool Five => Top && TopLeft && Middle && BottomRight && Bottom && TotalLit() == 5;
        private bool Six => Top && TopLeft && Middle && BottomLeft && Bottom && BottomRight && TotalLit() == 6;
        private bool Seven => TopRight && BottomRight && Top && TotalLit() == 3;
        private bool Eight => TotalLit() == 7;
        private bool Nine => TopRight && BottomRight && TopLeft && Middle && Bottom && Top && TotalLit() == 6;
        private bool Zero => TopRight && BottomRight && TopLeft && BottomLeft && Bottom && Top && TotalLit() == 6;
    }
}