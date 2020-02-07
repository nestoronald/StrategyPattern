using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class EstrategiaInvitarCerveza : IBorracho
    {
        public void Conquistar()
        {
            Console.WriteLine("Le invito una cerveza");
        }
    }
}
