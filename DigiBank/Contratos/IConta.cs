using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace DigiBank.Contratos
{
    public interface IConta
    {
        public interface IConta
        {
            void Deposita(double valor);
            bool Saca(double valor);
            double ConsultaSaldo();
            string GetCodigoDoBanco();
            string GetNumeroAgencia();
            string GetNumeroDaConta();

        }
    }
}