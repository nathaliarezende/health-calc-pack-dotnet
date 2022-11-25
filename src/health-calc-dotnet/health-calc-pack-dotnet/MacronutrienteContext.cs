﻿using health_calc_pack_dotnet.Interfaces;
using health_calc_pack_dotnet.Models;

namespace health_calc_pack_dotnet
{
    public class MacronutrienteContext
    {
        private IMacronutrienteStrategy MacronutrienteStrategy;

        public MacronutrienteContext(IMacronutrienteStrategy Strategy)
        {
            MacronutrienteStrategy = Strategy;
        }
        public void SetStrategy(IMacronutrienteStrategy Strategy)
        {
            MacronutrienteStrategy = Strategy;
        }
        public MacroNutrienteModel Execute(double Peso)
        {
            return MacronutrienteStrategy.CalculoMacronutrientes(Peso);
        }
    }
}
