using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    /*Esta clase funge de contexto por el cual se va crear los objetos */ 
    class EstrategiasDelBorrachoContexto
    {
        private IBorracho oBorracho;
        //Los enum sirven para hacer la coleccion de constantes
        public enum Comportamiento
        {
            HacerOjitos,InvitarCerveza,HacerCaraDeGalan
        }

        public EstrategiasDelBorrachoContexto()
        {
            //Estratetegia por defecto
            this.oBorracho = new EstrategiaOjitos();
        }
        
        //Hace referencia al constructor de este contexto
        public void Conquistar(Comportamiento opcion)
        {
            switch (opcion)
            {
                case Comportamiento.HacerOjitos:
                    {
                        this.oBorracho = new EstrategiaOjitos();
                    }
                    break;
                case Comportamiento.InvitarCerveza:
                    {
                        this.oBorracho = new EstrategiaInvitarCerveza();
                    }
                    break;
                case Comportamiento.HacerCaraDeGalan:
                    {
                        this.oBorracho = new EstrategiaHacerCaraDeGalan();

                    }
                    break;
                default:
                    break;
            }
            this.oBorracho.Conquistar();
        }
    }
}
