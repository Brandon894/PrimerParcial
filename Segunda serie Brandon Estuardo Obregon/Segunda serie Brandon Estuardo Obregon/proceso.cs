using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segunda_serie_Brandon_Estuardo_Obregon
{
    class vector
    {
        private List<int> _primercomponente;
        private List<int> _segundocomponente;

        public List<int> primercomponente { get { return _primercomponente; } }
        public List<int> segundocomponente { get { return _segundocomponente; } }

        public vector(List<int> primercomponente, List<int> segundocomponente, string signo)
        {
            _primercomponente = primercomponente;
            _segundocomponente = segundocomponente;


            for (int i = 0; i < primercomponente.Count; i++)
            {
                if (signo == "+")
                {
                    segundocomponente[i] = primercomponente[i] + segundocomponente[i];
                }
                else if (signo == "-")
                {
                    segundocomponente[i] = primercomponente[i] - segundocomponente[i];
                }
                else if (signo == "*")
                {
                    segundocomponente[i] = primercomponente[i] * segundocomponente[i];
                }
            }


        }
    }
}
