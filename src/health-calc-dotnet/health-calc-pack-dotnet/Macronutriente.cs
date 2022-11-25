using health_calc_pack_dotnet.Enums;
using health_calc_pack_dotnet.Interfaces;
using health_calc_pack_dotnet.Models;
using health_calc_pack_dotnet.Strategy;

namespace health_calc_pack_dotnet
{
    public class Macronutriente : IMacronutriente
    {

        const int MIN_WEIGHT = 35;

        public MacroNutrienteModel CalculoMacronutrientes(
            SexoEnum sexo, 
            double Altura, 
            double Peso, 
            ObjetivoFisicoEnum Objetivo, 
            NivelAtividadeFisicaEnum Nivel)
        {
            if (!IsValidData(Peso))
                throw new Exception("Parametros invalidos");


            IMacronutrienteStrategy macronutrienteStrategy = new CuttingStrategy();

            if (Objetivo == ObjetivoFisicoEnum.Cutting)
                macronutrienteStrategy = new CuttingStrategy();
            else if (Objetivo == ObjetivoFisicoEnum.Bulking)
            {
                if (Nivel == NivelAtividadeFisicaEnum.BastanteAtivo ||
                    Nivel == NivelAtividadeFisicaEnum.ExtremamenteAtivo)
                    macronutrienteStrategy = new BulkingNivelAtividadeAtivoStrategy(sexo);
                else
                    macronutrienteStrategy = new BulkingStrategy();
            }
            else if (Objetivo == ObjetivoFisicoEnum.Maintenance)
                macronutrienteStrategy = new MaintenanceStrategy();


            var context = new MacronutrienteContext(macronutrienteStrategy);

            var Result = context.Execute(Peso);

            return Result;
        }

        public bool IsValidData(double Weight)
        {
            if (Weight <= MIN_WEIGHT)
                return false;


            return true;
        }

        public bool ValidarDados(double Peso)
        {
            throw new NotImplementedException();
        }

        object IMacronutriente.CalculoMacronutrientes(SexoEnum sexoEnum, double v1, double v2, NivelAtividadeFisicaEnum sedentario, ObjetivoFisicoEnum cutting)
        {
            throw new NotImplementedException();
        }
    }
}