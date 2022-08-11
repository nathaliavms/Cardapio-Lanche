using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio
{
    class Cardapio
    {
        public int Codigo;
        public int Quantidade;

        public double MultiplicarDoisValores()
        {
            if (Codigo == 1)

                return Quantidade * 4.00;

            else if (Codigo == 2)

                return Quantidade * 4.50;

            else if (Codigo == 3)

                return Quantidade * 5.00;

            else if (Codigo == 4)

                return Quantidade * 2.00;

            else

                return Quantidade * 1.50;

        }
    }
}
