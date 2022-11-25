using health_calc_pack_dotnet;
using health_calc_pack_dotnet.Interfaces;

Console.WriteLine("Entre com sua altura e peso para calcular seu IMC");

Console.Write("Altura: ");
var Altura = Console.ReadLine();

Console.Write("Peso: ");
var Peso = Console.ReadLine();

Console.Write("Sexo: ");
var Sexo = Console.ReadLine();

IMC objIMC = new IMC();
IMacronutriente objMacronutriente = new Macronutriente();

double Result = objIMC.CalcularIMC(double.Parse(Altura), double.Parse(Peso));
String Category = objIMC.RetornarClassificacaoIMC(Result);

Console.WriteLine("O resultado do seu IMC foi : " + Category);

var SexoEnum = (Sexo == "F") ? health_calc_pack_dotnet.Enums.SexoEnum.Feminino : health_calc_pack_dotnet.Enums.SexoEnum.Masculino;


Console.ReadKey();
