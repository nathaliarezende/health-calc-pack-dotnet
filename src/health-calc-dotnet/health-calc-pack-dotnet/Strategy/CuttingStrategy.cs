using health_calc_pack_dotnet.Interfaces;
using health_calc_pack_dotnet.Models;

namespace health_calc_pack_dotnet.Strategy
{
    public class CuttingStrategy : IMacronutrienteStrategy
    {
        const int PROTEINA = 2;
        const int GORDURA = 1;
        const int CARBOIDRATO = 2;



        public MacroNutrienteModel CalculoMacronutrientes(double Peso)
        {

            var Result = new MacroNutrienteModel()
            {
                Proteinas = PROTEINA * (int)Peso,
                Carboidratos = CARBOIDRATO * (int)Peso,
                Gorduras = GORDURA * (int)Peso
            };

            return Result;
        }
    }   
}
