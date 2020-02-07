using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Genera la instacia de la clase EstrategiaOjitos ya que esta configurada en el contructor
            EstrategiasDelBorrachoContexto oBorracho = new EstrategiasDelBorrachoContexto();
            //Llama al metodo conquistar de la instancia creada en la sentencia anterior
            oBorracho.Conquistar();
            //Genera la instancia de la Clase EstrategiaInvitarCerveza
            oBorracho.EstablecerConquistaInvitarCerveza();
            // Llama al metodo conquistar de la instancia estabelcida en la anterior sentencia
            oBorracho.Conquistar();
        }
    }
}
