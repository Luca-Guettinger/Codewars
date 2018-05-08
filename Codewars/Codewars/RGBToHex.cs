using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    class RGBToHex
    {
        public static string Rgb(int r, int g, int b)
        {
            return ToHex(r) + ToHex(g) + ToHex(b);
        }


        public static string ToHex(int i)
        {
            if (i > 255) i = 255;
            if (i < 0) i = 0;
            string hex = i.ToString("X");
            if (hex.ToCharArray().Length < 2) hex = "0" + hex;
            if (i == 0) hex = "00";

            return hex;
        }
    }
}
