//Console.WriteLine("agathinhas");

//https://code.dcoder.tech/files/code/6698e8cd3a53b7a624f98302/classificador-de-nivel-de-heroi---dio

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
 // Compiler version 4.0, .NET Framework 4.5


 namespace Dcoder
 {
   public class Program
   {
     public static void Main(string[] args)
     {
       Console.WriteLine($"Olá bravíssimo herói!\n Diga-me seu nome:\n");
       string nomeJogador = Console.ReadLine();
       
       Console.WriteLine($"\n Agora me responda, {nomeJogador}: quanto de experiência (XP) tens?\n");
       int.TryParse(Console.ReadLine(), out int xpJogador);
       
       Console.WriteLine($"\n Perfeito!! Vou verificar seu nível...\n");
       
      
             
      if (xpJogador <= 1000)
      {
        Console.WriteLine ($"Hmmmm... {xpJogador}XP... O herói de nome {nomeJogador} está no nível de Ferro!");  
      }
      
      else if ((xpJogador >= 1001) && (xpJogador <= 2000))
      {
        Console.WriteLine ($"Hmmmm... {xpJogador}XP... O herói de nome {nomeJogador} está no nível de Bronze!");
      }
      
      else if ((xpJogador >= 2001) && (xpJogador <= 5000))
      {
        Console.WriteLine ($"Hmmmm... {xpJogador}XP... O herói de nome {nomeJogador} está no nível de Prata!");
      }
      
      else if ((xpJogador >= 5001) && (xpJogador <= 7000))
      {
        Console.WriteLine ($"Hmmmm... {xpJogador}XP... O herói de nome {nomeJogador} está no nível de Ouro!");
      }
      
      else if ((xpJogador >= 7001) && (xpJogador <= 8000))
      {
        Console.WriteLine ($"Hmmmm... {xpJogador}XP... O herói de nome {nomeJogador} está no nível de Platina!");
      }
      
      else if ((xpJogador >= 8001) && (xpJogador <= 9000))
      {
        Console.WriteLine ($"Hmmmm... {xpJogador}XP... O herói de nome {nomeJogador} está no nível de Ascendente!");
      }
      
      else if ((xpJogador >= 9001) && (xpJogador <= 10000))
      {
        Console.WriteLine ($"Hmmmm... {xpJogador}XP... O herói de nome {nomeJogador} está no nível de Imortal!");
      }
      
      else if (xpJogador >= 10001)
      {
        Console.WriteLine ($"Hmmmm... {xpJogador}XP... O herói de nome {nomeJogador} está no nível de Radiante!");
      }
    
    
      
     }
   }
 }