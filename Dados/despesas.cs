#region author info
// ============================================================
// Author: Rodrigo Lopes Ferreira
// Date:    {13/11/2025}
// Project: {Gestão de Condomínios}
// File:    {despesas.cs}
// Description: Camada de Dados (DL) para gestão de despesas.
// ============================================================
#endregion

using BO;
using static Exceptions.FicheiroExcecoes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Dados
{
    /// <summary>
    /// Classe responsável pela manipulação e persistência de dados referentes às Despesas.
    /// </summary>
    [Serializable]
    public class Despesas
    {
        #region Atributos
        /// <summary>
        /// Lista estática que armazena as despesas em memória.
        /// </summary>
        static List<Despesa> listaDespesas = new List<Despesa>();
        #endregion

        #region CRUD

        /// <summary>
        /// Obtém uma despesa específica pelo seu ID.
        /// </summary>
        public static Despesa ObterDespesa(int idDespesa)
        {
            return listaDespesas.Find(d => d.IdDespesa == idDespesa);
        }

        /// <summary>
        /// Adiciona uma nova despesa à lista, se não existir duplicado.
        /// </summary>
        public static bool AdicionarDespesa(Despesa d)
        {
            if (d == null) return false;

            if (ObterDespesa(d.IdDespesa) != null) return false; // evitar duplicados

            listaDespesas.Add(d);
            return true;
        }

        /// <summary>
        /// Devolve uma cópia da lista de todas as despesas.
        /// </summary>
        public static List<Despesa> ObterTodos()
        {
            return new List<Despesa>(listaDespesas);
        }

        /// <summary>
        /// Retorna as despesas associadas a um determinado condomínio.
        /// </summary>
        public static List<Despesa> ObterPorCondominio(int idCondominio)
        {
            return listaDespesas.FindAll(d => d.IdCondominio == idCondominio);
        }

        /// <summary>
        /// Limpa todos os dados de despesas em memória.
        /// </summary>
        public static bool Limpar()
        {
            listaDespesas.Clear();
            return true;
        }

        #endregion

        #region Manipulação de Ficheiros

        /// <summary>
        /// Guarda as despesas num ficheiro binário.
        /// </summary>
        public static bool SaveDespesas(string fileName)
        {
            try
            {
                Stream stream = File.Open(fileName, FileMode.Create);
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, listaDespesas);
                stream.Close();
                return true;
            }
            catch (Exception e)
            {
                throw new FicheiroException("Não foi possível gravar", e);
            }
        }

        /// <summary>
        /// Carrega as despesas de um ficheiro binário.
        /// </summary>
        public static bool LoadDespesas(string fileName)
        {
            if (File.Exists(fileName) && (new FileInfo(fileName).Length > 0))
            {
                try
                {
                    Stream stream = File.Open(fileName, FileMode.Open, FileAccess.Read);
                    BinaryFormatter bin = new BinaryFormatter();
                    listaDespesas = (List<Despesa>)bin.Deserialize(stream);
                    stream.Close();

                    if (listaDespesas == null)
                        listaDespesas = new List<Despesa>();

                    return true;
                }
                catch (Exception e)
                {
                    throw new FicheiroException("Não foi possível ler", e);
                }
            }
            return false;
        }

        #endregion
    }
}