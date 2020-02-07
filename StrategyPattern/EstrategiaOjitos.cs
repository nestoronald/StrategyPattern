using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class EstrategiaOjitos : IBorracho
    {
        public void Conquistar()
        {
            Console.WriteLine("Le hago ojitos a la chica");
        }
    }
}
