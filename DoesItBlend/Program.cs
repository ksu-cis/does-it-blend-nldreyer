using System;
using System.Collections.Generic;
using System.Text;

namespace DoesItBlend
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IBlendable> blendables = new List<IBlendable>();
            blendables.Add(new Strawberry());
            blendables.Add(new Banana());
            blendables.Add(new CellPhone());
            blendables.Add(new IceCubes());
            for (int i = 0; i < 10; i++)
            {
                blendables.Add(new Mango());
            }

            StringBuilder mess = new StringBuilder();

            foreach (IBlendable blendable in blendables)
            {
                mess.AppendLine(blendable.Blend());
            }

            Console.WriteLine(mess);
        }
    }
}
