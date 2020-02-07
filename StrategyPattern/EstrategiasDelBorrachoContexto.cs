using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class EstrategiasDelBorrachoContexto
    {
        private IBorracho oBorracho;
        public EstrategiasDelBorrachoContexto()
        {
            //Estratetegia por defecto
            this.oBorracho = new EstrategiaOjitos();
        }
        public void EstablecerConquistaOjitos()
        {
            this.oBorracho = new EstrategiaOjitos();
        }
        public void EstablecerConquistaInvitarCerveza()
        {
            this.oBorracho = new EstrategiaInvitarCerveza();
        }
        //Hace referencia al constructor de este contexto
        public void Conquistar()
        {
            this.oBorracho.Conquistar();
        }
    }
}
