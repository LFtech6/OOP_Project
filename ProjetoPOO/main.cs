#region author info
// ============================================================
// Author: Rodrigo Lopes Ferreira
// Date:    {11/09/2025}
// Project: {Gestão de Condomínios}
// File:    {main.cs}
//
// Description:
//   {Projeto sobre gestão de condomínios em C#}
//
// ============================================================
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpGestCondominios;

public class Program
{
    static void Main(string[] args)
        {
        Console.WriteLine("Enter username:");
        string userName = Console.ReadLine();
        Console.WriteLine("Username is: " + userName);
    }
}