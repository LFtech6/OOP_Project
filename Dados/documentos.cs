#region author info
// ============================================================
// Author: Rodrigo Lopes Ferreira
// Date:    {13/11/2025}
// Project: {Gestão de Condomínios}
// File:    {documentos.cs}
// Description: Camada de Dados (DL) para gestão de documentos.
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
    /// Classe responsável pela manipulação e persistência de dados referentes aos Documentos.
    /// </summary>
    [Serializable]
    public class Documentos
    {
        #region Attributes
        /// <summary>
        /// Lista estática que armazena os documentos em memória.
        /// </summary>
        static List<Documento> listaDocumentos = new List<Documento>();
        #endregion

        #region CRUD

        /// <summary>
        /// Obtém um documento através do seu identificador único.
        /// </summary>
        public static Documento ObterDocumento(int idDocumento)
        {
            return listaDocumentos.Find(d => d.IdDocumento == idDocumento);
        }

        /// <summary>
        /// Adiciona um documento à lista se este ainda não existir.
        /// </summary>
        public static bool AdicionarDocumento(Documento d)
        {
            if (d == null) return false;
            if (ObterDocumento(d.IdDocumento) != null) return false;

            listaDocumentos.Add(d);
            return true;
        }

        /// <summary>
        /// Retorna todos os documentos registados.
        /// </summary>
        public static List<Documento> ObterTodos()
        {
            return new List<Documento>(listaDocumentos);
        }

        /// <summary>
        /// Filtra e retorna os documentos de um condomínio específico.
        /// </summary>
        public static List<Documento> ObterPorCondominio(int idCondominio)
        {
            return listaDocumentos.FindAll(d => d.IdCondominio == idCondominio);
        }

        /// <summary>
        /// Filtra e retorna os documentos associados a uma reunião.
        /// </summary>
        public static List<Documento> ObterPorReuniao(int idReuniao)
        {
            return listaDocumentos.FindAll(d => d.IdReuniao == idReuniao);
        }

        /// <summary>
        /// Filtra e retorna os documentos associados a uma despesa.
        /// </summary>
        public static List<Documento> ObterPorDespesa(int idDespesa)
        {
            return listaDocumentos.FindAll(d => d.IdDespesa == idDespesa);
        }

        /// <summary>
        /// Limpa a lista de documentos em memória.
        /// </summary>
        public static bool Limpar()
        {
            listaDocumentos.Clear();
            return true;
        }

        #endregion

        #region Manipulação de Ficheiros
        /// <summary>
        /// Serializa a lista de documentos em ficheiro binário.
        /// </summary>
        public static bool SaveDocumentos(string fileName)
        {
            try
            {
                Stream stream = File.Open(fileName, FileMode.Create);
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, listaDocumentos);
                stream.Close();
                return true;
            }
            catch (Exception e)
            {
                throw new FicheiroException("Não foi possível gravar", e);
            }
        }

        /// <summary>
        /// Deserializa a lista de documentos a partir de um ficheiro.
        /// </summary>
        public static bool LoadDocumentos(string fileName)
        {
            if (File.Exists(fileName) && (new FileInfo(fileName).Length > 0))
            {
                try
                {
                    Stream stream = File.Open(fileName, FileMode.Open, FileAccess.Read);
                    BinaryFormatter bin = new BinaryFormatter();
                    listaDocumentos = (List<Documento>)bin.Deserialize(stream);
                    stream.Close();

                    if (listaDocumentos == null)
                        listaDocumentos = new List<Documento>();

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