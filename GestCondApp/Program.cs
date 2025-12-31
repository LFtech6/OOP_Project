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

using BO;
using Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GestCondApp;

public class Program
{
    static void Main(string[] args)
    {
        // carregar do ficheiro
        Moradores.LoadMoradores("moradores.bin");

        // obter lista
        var moradores = Moradores.ObterTodos();

        Console.WriteLine("=== MORADORES ===");
        Console.WriteLine("Total: " + moradores.Count);
        Console.WriteLine();

        foreach (var m in moradores)
        {
            Console.WriteLine("Nome: " + m.Nome);
            Console.WriteLine("NIF: " + m.Nif);
            Console.WriteLine("Contacto: " + m.Contacto);
            Console.WriteLine("Condomínio: " + m.IdCondominio);

            if (m is Proprietario p)
            {
                Console.WriteLine("Tipo: Proprietário");
                Console.WriteLine("Fração: " + p.IdFraccao);
                Console.WriteLine("Piso: " + p.Piso);
                Console.WriteLine("Permilagem: " + p.Permilagem);
            }
            else if (m is Inquilino i)
            {
                Console.WriteLine("Tipo: Inquilino");
                Console.WriteLine("Fração: " + i.IdFraccao);
                Console.WriteLine("Início contrato: " + i.DataInicioContrato);
                Console.WriteLine("Duração: " + i.DuracaoMeses + " meses");
            }

            Console.WriteLine("----------------------");
        }

        Console.ReadKey();
    }
}