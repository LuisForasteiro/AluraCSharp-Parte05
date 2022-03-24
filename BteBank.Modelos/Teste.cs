using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BteBank.Modelos
{
    class ClasseTeste
    {
        public ClasseTeste()
        {
            ModificadoresTeste teste = new ModificadoresTeste();
            teste.MetodoPublico();    
            teste.MetodoInterno();

        }
    }

    class ClasseDerivada : ModificadoresTeste
    {
        public ClasseDerivada()
            {
                MetodoProtegido();
            }
            
    }



    public class ModificadoresTeste
    {
        public void MetodoPublico()
        {
            //visivel fora da classse de "Modificadores"
        }

        private void MetodoPrivado()
        {
            //visivel apenas na classe de "ModificadoresTeste"

        }

        protected void MetodoProtegido()
        {
            //Visivel apenas na classe "Modificadores Teste" e derivados
        }

        internal void MetodoInterno()
        {
            //visivel apenas para o projeto ByteBank.Modelos!
        }
    }

}
