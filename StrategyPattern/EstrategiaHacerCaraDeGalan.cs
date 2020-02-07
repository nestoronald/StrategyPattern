using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class EstrategiaHacerCaraDeGalan : IBorracho
    {
        public void Conquistar()
        {
            Console.WriteLine("Le hago cara de galán");
        }
    }
}
