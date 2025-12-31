#region author info
// ============================================================
// Author: Rodrigo Lopes Ferreira
// Date:    {13/11/2025}
// Project: {Gestão de Condomínios}
// File:    {fraccoes.cs}
// Description: Camada de Dados (DL) para gestão de frações.
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
    /// Classe responsável pela manipulação e persistência de dados referentes às Frações.
    /// </summary>
    [Serializable]
    public class Fraccoes
    {
        #region Attributes
        /// <summary>
        /// Lista estática que armazena as frações em memória.
        /// </summary>
        static List<Fraccao> listaFraccoes = new List<Fraccao>();
        #endregion

        #region CRUD

        /// <summary>
        /// Pesquisa e devolve uma fração pelo seu identificador.
        /// </summary>
        public static Fraccao ObterFraccao(string idFraccao)
        {
            return listaFraccoes.Find(f => f.IdFraccao == idFraccao);
        }

        /// <summary>
        /// Insere uma nova fração na lista, validando a inexistência de duplicados.
        /// </summary>
        public static bool AdicionarFraccao(Fraccao f)
        {
            if (f == null) return false;

            // evitar duplicados pelo Id
            if (ObterFraccao(f.IdFraccao) != null) return false;

            listaFraccoes.Add(f);
            return true;
        }

        /// <summary>
        /// Devolve uma cópia da lista completa de frações.
        /// </summary>
        public static List<Fraccao> ObterTodos()
        {
            return new List<Fraccao>(listaFraccoes);
        }

        /// <summary>
        /// Apaga todos os registos de frações da memória.
        /// </summary>
        public static bool Limpar()
        {
            listaFraccoes.Clear();
            return true;
        }

        #endregion

        #region Manipulação de Ficheiros

        /// <summary>
        /// Guarda a lista de frações em ficheiro binário.
        /// </summary>
        public static bool SaveFraccoes(string fileName)
        {
            try
            {
                Stream stream = File.Open(fileName, FileMode.Create);
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, listaFraccoes);
                stream.Close();
                return true;
            }
            catch (Exception e)
            {
                throw new FicheiroException("Não foi possível gravar", e);
            }
        }

        /// <summary>
        /// Carrega a lista de frações a partir de ficheiro binário.
        /// </summary>
        public static bool LoadFraccoes(string fileName)
        {
            if (File.Exists(fileName) && (new FileInfo(fileName).Length > 0))
            {
                try
                {
                    Stream stream = File.Open(fileName, FileMode.Open, FileAccess.Read);
                    BinaryFormatter bin = new BinaryFormatter();
                    listaFraccoes = (List<Fraccao>)bin.Deserialize(stream);
                    stream.Close();

                    if (listaFraccoes == null)
                        listaFraccoes = new List<Fraccao>();

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