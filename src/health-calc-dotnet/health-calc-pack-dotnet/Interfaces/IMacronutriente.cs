using health_calc_pack_dotnet.Enums;
using health_calc_pack_dotnet.Models;

namespace health_calc_pack_dotnet.Interfaces
{
    public interface IMacronutriente
    {
        MacroNutrienteModel CalculoMacronutrientes(
            SexoEnum sexo,
            double Altura,
            double Peso,
            ObjetivoFisicoEnum Objetivo,
            NivelAtividadeFisicaEnum Nivel);
        object CalculoMacronutrientes(SexoEnum sexoEnum, double v1, double v2, NivelAtividadeFisicaEnum sedentario, ObjetivoFisicoEnum cutting);
        bool ValidarDados(double Peso);
    }
}
