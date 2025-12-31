#region author info
// ============================================================
// Author: Rodrigo Lopes Ferreira
// Date:    {31/12/2025}
// Project: {Gestão de Condomínios}
// File:    {MoradoresTests.cs}
//
// Description:
//   Testes unitários manuais para a camada de dados Moradores.
//   Os testes são realizados com Debug.Assert.
// ============================================================
#endregion

using System;
using System.Diagnostics;
using System.IO;
using BO;
using Dados;

namespace Tests
{
    public static class MoradoresTests
    {
        static string file = "moradores_test.bin";

        /// <summary>
        /// Executa todos os testes relacionados com Moradores.
        /// </summary>
        public static void RunAll()
        {
            TestAdicionarMorador();
            TestAdicionarNull();
            TestLimpar();
            TestSaveLoad();

            Console.WriteLine("✔ Todos os testes de Moradores passaram com sucesso.");
        }

        /// <summary>
        /// Testa a adição de um morador válido.
        /// </summary>
        static void TestAdicionarMorador()
        {
            Moradores.Limpar();

            Proprietario p = new Proprietario(
                "João Silva",
                123456789,
                "912345678",
                1,
                "Rua X",
                "A1",
                2,
                120.5f
            );

            bool added = Moradores.AdicionarMorador(p);

            Debug.Assert(added == true, "O morador deveria ser adicionado.");
            Debug.Assert(Moradores.ObterTodos().Count == 1, "Deveria existir 1 morador.");
        }

        /// <summary>
        /// Testa a tentativa de adicionar um morador nulo.
        /// </summary>
        static void TestAdicionarNull()
        {
            Moradores.Limpar();

            bool added = Moradores.AdicionarMorador(null);

            Debug.Assert(added == false, "Não deve ser possível adicionar null.");
            Debug.Assert(Moradores.ObterTodos().Count == 0, "A lista deve continuar vazia.");
        }

        /// <summary>
        /// Testa o método Limpar.
        /// </summary>
        static void TestLimpar()
        {
            Moradores.Limpar();

            Moradores.AdicionarMorador(new Inquilino(
                "Ana Costa",
                987654321,
                "934567890",
                1,
                DateTime.Now,
                12,
                "B2"
            ));

            Debug.Assert(Moradores.ObterTodos().Count == 1, "Deveria existir 1 morador.");

            Moradores.Limpar();

            Debug.Assert(Moradores.ObterTodos().Count == 0, "A lista deveria estar vazia após Limpar.");
        }

        /// <summary>
        /// Testa a gravação e leitura em ficheiro.
        /// </summary>
        static void TestSaveLoad()
        {
            Moradores.Limpar();
            try { File.Delete(file); } catch { }

            Moradores.AdicionarMorador(new Proprietario(
                "Carlos Mendes",
                111222333,
                "910000000",
                1,
                "Rua Y",
                "C3",
                3,
                90.0f
            ));

            bool saved = Moradores.SaveMoradores(file);
            Debug.Assert(saved == true, "O ficheiro deveria ser guardado.");

            Moradores.Limpar();
            Debug.Assert(Moradores.ObterTodos().Count == 0, "Lista devia estar vazia antes do load.");

            bool loaded = Moradores.LoadMoradores(file);
            Debug.Assert(loaded == true, "O ficheiro deveria ser carregado.");
            Debug.Assert(Moradores.ObterTodos().Count == 1, "A lista deveria ter 1 morador após load.");
        }
    }
}
