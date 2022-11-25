namespace health_calc_pack_dotnet.Interfaces
{
    public interface IIMC
    {
        double CalcularIMC(double Altura, double Peso);
        string RetornarClassificacaoIMC(double IMC);
        bool ValidarDados(double Altura, double Peso);
    }
}
