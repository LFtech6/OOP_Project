#region author info
// ============================================================
// Author: Rodrigo Lopes Ferreira
// Date:    {13/11/2025}
// Project: {Gestão de Condomínios}
// File:    {moradores.cs}
// Description: Camada de Dados (DL) para gestão de moradores.
// ============================================================
#endregion

using BO;
using Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Dados
{
    /// <summary>
    /// Classe responsável pela manipulação e persistência de dados referentes aos Moradores.
    /// </summary>
    [Serializable]
    public class Moradores
    {
        #region Attributes
        /// <summary>
        /// Lista estática que armazena os moradores em memória.
        /// </summary>
        static List<Morador> listaMoradores = new List<Morador>();
        #endregion

        #region CRUD
        /// <summary>
        /// Adiciona um novo morador à lista de dados.
        /// </summary>
        public static bool AdicionarMorador(Morador m)
        {
            if (m == null) return false;

            listaMoradores.Add(m);
            return true;
        }

        /// <summary>
        /// Retorna uma cópia de todos os moradores registados.
        /// </summary>
        public static List<Morador> ObterTodos()
        {
            return new List<Morador>(listaMoradores);
        }

        /// <summary>
        /// Remove todos os registos de moradores da memória.
        /// </summary>
        public static bool Limpar()
        {
            listaMoradores.Clear();
            return true;
        }
        #endregion

        #region Manipulação de Ficheiros
        /// <summary>
        /// Serializa a lista de moradores para um ficheiro binário.
        /// </summary>
        public static bool SaveMoradores(string fileName)
        {
            try
            {
                Stream stream = File.Open(fileName, FileMode.Create);
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, listaMoradores);
                stream.Close();
                return true;
            }
            catch (Exception e)
            {
                throw new FicheiroException("Não foi possível gravar", e);
            }
        }

        /// <summary>
        /// Deserializa os moradores de um ficheiro binário para a memória.
        /// </summary>
        public static bool LoadMoradores(string fileName)
        {
            if (File.Exists(fileName) && (new FileInfo(fileName).Length > 0))
            {
                try
                {
                    Stream stream = File.Open(fileName, FileMode.Open, FileAccess.Read);
                    BinaryFormatter bin = new BinaryFormatter();
                    listaMoradores = (List<Morador>)bin.Deserialize(stream);
                    stream.Close();
                    return true;
                }
                catch (Exception e)
                {
                    throw new FicheiroException("Não foi possível ler", e);
                }
            }
            return false;
        }

    }

    #endregion
}