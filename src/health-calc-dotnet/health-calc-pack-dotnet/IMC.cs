using health_calc_pack_dotnet.Interfaces;
using System;

namespace health_calc_pack_dotnet
{
    public class IMC : IIMC
    {
        public double CalcularIMC(double Altura, double Peso)
        {
            if (!ValidarDados(Altura, Peso))
                throw new Exception("Invalid Parameters!");

            var Result = Math.Round(Peso / (Math.Pow(Altura, 2)), 2);
            return Result;
        }

        public string RetornarClassificacaoIMC(double IMC)
        {
            var Result = string.Empty;

            if (IMC < 18.5)
                Result = "Abaixo do peso";
            else if (IMC >= 18.5 && IMC < 25)
                Result = "Peso normal";
            else if (IMC >= 25 && IMC < 30)
                Result = "Pré-obesidade";
            else if (IMC >= 30 && IMC < 35)
                Result = "Obesidade Grau 1";
            else if (IMC >= 35 && IMC < 40)
                Result = "Obesidade Grau 2";
            else if (IMC >= 40)
                Result = "Obesidade Grau 3";

            return Result;
        }

        public bool ValidarDados(double Altura, double Peso)
        {
            if (Altura <= 0 || Peso <= 0)
                return false;
            else
                return true;
        }
    }
}