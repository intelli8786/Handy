using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
   public static class Protocols
   {
        public static byte Pointer_Move = 0;
        public static byte Pointer_Scroll = 1;
        public static byte Pointer_LClick = 2;
        public static byte Pointer_LDown = 3;
        public static byte Pointer_LUp = 4;
        public static byte Pointer_RClick = 5;
        public static byte Pointer_RDown = 6;
        public static byte Pointer_RUp = 7;

        public static byte Key_Down = 8;
        public static byte Key_Up = 9;

        public static byte Message = 10;

        public static byte Device_Activated = 11;
        public static byte Device_Deactivated = 12;
    }
}
