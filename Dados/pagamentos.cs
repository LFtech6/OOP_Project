#region author info
// ============================================================
// Author: Rodrigo Lopes Ferreira
// Date:    {13/11/2025}
// Project: {Gestão de Condomínios}
// File:    {pagamentos.cs}
// Description: Camada de Dados (DL) para gestão de pagamentos.
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
    /// Classe responsável pela manipulação e persistência de dados referentes aos Pagamentos.
    /// </summary>
    [Serializable]
    public class Pagamentos
    {
        #region Atributos
        /// <summary>
        /// Lista estática que armazena os pagamentos em memória.
        /// </summary>
        static List<Pagamento> listaPagamentos = new List<Pagamento>();
        #endregion

        #region CRUD

        /// <summary>
        /// Obtém um pagamento específico através do seu identificador.
        /// </summary>
        public static Pagamento ObterPagamento(int idPagamento)
        {
            return listaPagamentos.Find(p => p.IdPagamento == idPagamento);
        }

        /// <summary>
        /// Regista um novo pagamento na lista, garantindo a unicidade do ID.
        /// </summary>
        public static bool AdicionarPagamento(Pagamento p)
        {
            if (p == null) return false;
            if (ObterPagamento(p.IdPagamento) != null) return false;

            listaPagamentos.Add(p);
            return true;
        }

        /// <summary>
        /// Retorna uma cópia de todos os pagamentos registados.
        /// </summary>
        public static List<Pagamento> ObterTodos()
        {
            return new List<Pagamento>(listaPagamentos);
        }

        /// <summary>
        /// Filtra e retorna os pagamentos associados a um condomínio específico.
        /// </summary>
        public static List<Pagamento> ObterPorCondominio(int idCondominio)
        {
            return listaPagamentos.FindAll(p => p.IdCondominio == idCondominio);
        }

        /// <summary>
        /// Filtra e retorna os pagamentos efetuados por um morador específico (via NIF).
        /// </summary>
        public static List<Pagamento> ObterPorMorador(int nifMorador)
        {
            return listaPagamentos.FindAll(p => p.NifMorador == nifMorador);
        }

        /// <summary>
        /// Remove todos os pagamentos da memória.
        /// </summary>
        public static bool Limpar()
        {
            listaPagamentos.Clear();
            return true;
        }

        #endregion

        #region Manipulação de Ficheiros

        /// <summary>
        /// Guarda a lista atual de pagamentos num ficheiro binário.
        /// </summary>
        public static bool SavePagamentos(string fileName)
        {
            try
            {
                Stream stream = File.Open(fileName, FileMode.Create);
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, listaPagamentos);
                stream.Close();
                return true;
            }
            catch (Exception e)
            {
                throw new FicheiroException("Não foi possível gravar", e);
            }
        }

        /// <summary>
        /// Carrega a lista de pagamentos a partir de um ficheiro binário.
        /// </summary>
        public static bool LoadPagamentos(string fileName)
        {
            if (File.Exists(fileName) && (new FileInfo(fileName).Length > 0))
            {
                try
                {
                    Stream stream = File.Open(fileName, FileMode.Open, FileAccess.Read);
                    BinaryFormatter bin = new BinaryFormatter();
                    listaPagamentos = (List<Pagamento>)bin.Deserialize(stream);
                    stream.Close();

                    if (listaPagamentos == null)
                        listaPagamentos = new List<Pagamento>();

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