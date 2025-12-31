#region author info
// ============================================================
// Author: Rodrigo Lopes Ferreira
// Date:    {13/11/2025}
// Project: {Gestão de Condomínios}
// File:    {condominios.cs}
// Description: Camada de Dados (DL) para gestão de condomínios.
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
    /// Classe responsável pela manipulação e persistência de dados referentes aos Condomínios.
    /// </summary>
    [Serializable]
    public class Condominios
    {
        #region Attributes
        /// <summary>
        /// Lista estática que armazena os condomínios em memória.
        /// </summary>
        static List<Condominio> listaCondominios = new List<Condominio>();
        #endregion

        #region CRUD
        /// <summary>
        /// Procura e retorna um condomínio através do seu ID.
        /// </summary>
        public static Condominio ObterCondominio(int idCondominio)
        {
            return listaCondominios.Find(c => c.IdCondominio == idCondominio);
        }

        /// <summary>
        /// Insere um novo condomínio na lista, validando se já existe.
        /// </summary>
        public static bool AdicionarCondominio(Condominio c)
        {
            if (c == null) return false;

            if (ObterCondominio(c.IdCondominio) != null) return false;

            listaCondominios.Add(c);
            return true;
        }

        /// <summary>
        /// Devolve todos os condomínios registados no sistema.
        /// </summary>
        public static List<Condominio> ObterTodos()
        {
            return new List<Condominio>(listaCondominios);
        }

        /// <summary>
        /// Apaga todos os condomínios da lista em memória.
        /// </summary>
        public static bool Limpar()
        {
            listaCondominios.Clear();
            return true;
        }

        #endregion

        #region Manipulação de Ficheiros

        /// <summary>
        /// Serializa a lista de condomínios para um ficheiro binário.
        /// </summary>
        public static bool SaveCondominios(string fileName)
        {
            try
            {

                Stream stream = File.Open(fileName, FileMode.Create);
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, listaCondominios);
                stream.Close();
                return true;
            }
            catch (Exception e)
            {
                throw new FicheiroException("Não foi possível gravar", e);
            }
        }

        /// <summary>
        /// Deserializa a lista de condomínios a partir de um ficheiro binário.
        /// </summary>
        public static bool LoadCondominios(string fileName)
        {
            if (File.Exists(fileName) && (new FileInfo(fileName).Length > 0))
            {
                try
                {
                    Stream stream = File.Open(fileName, FileMode.Open, FileAccess.Read);
                    BinaryFormatter bin = new BinaryFormatter();
                    listaCondominios = (List<Condominio>)bin.Deserialize(stream);
                    stream.Close();

                    if (listaCondominios == null)
                        listaCondominios = new List<Condominio>();

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