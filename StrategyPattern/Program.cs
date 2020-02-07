using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Genera la instacia de la clase EstrategiaOjitos ya que esta configurada en el contructor
            EstrategiasDelBorrachoContexto oBorracho = new EstrategiasDelBorrachoContexto();
            //Llama al metodo conquistar a traves del conportamiento HacerOjitos
            oBorracho.Conquistar(EstrategiasDelBorrachoContexto.Comportamiento.HacerOjitos);
            // Llama al metodo conquistar a traves del conportamiento InvitarCerveza
            oBorracho.Conquistar(EstrategiasDelBorrachoContexto.Comportamiento.InvitarCerveza);
            //Llama al metodo conquistar a traves del conportamiento HacerCaraDeGalan
            oBorracho.Conquistar(EstrategiasDelBorrachoContexto.Comportamiento.HacerCaraDeGalan);
        }
    }
}
