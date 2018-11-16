using System;
using System.Collections.Generic;
using System.Text;

namespace D2KRMG
{
    /*
    
        tile location prepresented in hexadecimal (both types), int, etc

    */

    public enum Endianness { big, little };

    public class TileLocation
    {
        UInt32 location;

        public UInt32 Location
        {
            get
            {
                return location;
            }
        }

        public TileLocation(string hex)
        {
            //reverse
            string reversedString = "0x" + hex[2] + hex[3] + hex[0] + hex[1];
            location = Convert.ToUInt32(reversedString, 16);
        }

        public TileLocation(UInt32 num)
        {
            location = num;
        }

        //public TileLocation(string hex, Endianness endianness)
        //{
        //    if (endianness == Endianness.little)
        //    {

        //    }
        //}

        //public void SetLocation(string hex, Endianness endianness)
        //{
        //    if(endianness == Endianness.little)
        //    {

        //    }

        //}

        //public void SetLocation(int loc)
        //{


        //}
    }
}
