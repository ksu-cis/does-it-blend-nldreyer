using System;
using System.Collections.Generic;
using System.Text;

namespace DoesItBlend
{
    class OverripeBanana : Banana 
    {
        public new string Blend()
        {
            return "Brown and yellow mush";
        }
    }
}
