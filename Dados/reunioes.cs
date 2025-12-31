#region author info
// ============================================================
// Author: Rodrigo Lopes Ferreira
// Date:    {13/11/2025}
// Project: {Gestão de Condomínios}
// File:    {reunioes.cs}
// Description: Camada de Dados (DL) para gestão de reuniões.
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
    /// Classe responsável pela manipulação e persistência de dados referentes às Reuniões.
    /// </summary>
    [Serializable]
    public class Reunioes
    {
        #region Atributos
        /// <summary>
        /// Lista estática que armazena as reuniões em memória.
        /// </summary>
        static List<Reuniao> listaReunioes = new List<Reuniao>();
        #endregion

        #region CRUD

        /// <summary>
        /// Obtém uma reunião específica através do seu identificador único.
        /// </summary>
        public static Reuniao ObterReuniao(int idReuniao)
        {
            return listaReunioes.Find(r => r.IdReuniao == idReuniao);
        }

        /// <summary>
        /// Adiciona uma nova reunião à lista, verificando se já existe duplicado.
        /// </summary>
        public static bool AdicionarReuniao(Reuniao r)
        {
            if (r == null) return false;

            if (ObterReuniao(r.IdReuniao) != null) return false; // evitar duplicados

            listaReunioes.Add(r);
            return true;
        }

        /// <summary>
        /// Retorna uma cópia de todas as reuniões registadas.
        /// </summary>
        public static List<Reuniao> ObterTodos()
        {
            return new List<Reuniao>(listaReunioes);
        }

        /// <summary>
        /// Filtra e retorna as reuniões associadas a um condomínio específico.
        /// </summary>
        public static List<Reuniao> ObterPorCondominio(int idCondominio)
        {
            return listaReunioes.FindAll(r => r.IdCondominio == idCondominio);
        }

        /// <summary>
        /// Remove todas as reuniões da lista em memória.
        /// </summary>
        public static bool Limpar()
        {
            listaReunioes.Clear();
            return true;
        }

        #endregion

        #region Manipulação de Ficheiros

        /// <summary>
        /// Serializa a lista de reuniões para um ficheiro binário.
        /// </summary>
        public static bool SaveReunioes(string fileName)
        {
            try
            {
                Stream stream = File.Open(fileName, FileMode.Create);
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, listaReunioes);
                stream.Close();
                return true;
            }
            catch (Exception e)
            {
                throw new FicheiroException("Não foi possível gravar", e);
            }
        }

        /// <summary>
        /// Deserializa as reuniões de um ficheiro binário para a memória.
        /// </summary>
        public static bool LoadReunioes(string fileName)
        {
            if (File.Exists(fileName) && (new FileInfo(fileName).Length > 0))
            {
                try
                {
                    Stream stream = File.Open(fileName, FileMode.Open, FileAccess.Read);
                    BinaryFormatter bin = new BinaryFormatter();
                    listaReunioes = (List<Reuniao>)bin.Deserialize(stream);
                    stream.Close();

                    if (listaReunioes == null)
                        listaReunioes = new List<Reuniao>();

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