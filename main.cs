using System;

class MainClass {
  public static void Main (string[] args) {
    
     double celsius, fahreinheit;
     Console.WriteLine("\n Exercício B");
      Console.WriteLine("Temperatura em graus Fahreinheit, convertida em Celsius ");

     Console.WriteLine("Digite a temperatura em graus Fahreinheit");
      fahreinheit = double.Parse(Console.ReadLine());
      //C←((F - 32) * 5) / 9
      celsius = ((fahreinheit - 32) * 5) / 9;
      Console.WriteLine("A temperatura convertida em Celsius é:" + celsius);

 
 
 
 
 
  }
}