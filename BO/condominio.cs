#region author info
// ============================================================
// Author: Rodrigo Lopes Ferreira
// Date:    {13/11/2025}
// Project: {Gestão de Condomínios}
// File:    {condominio.cs}
//
// Description:
//   Representa um condomínio, incluindo nome, localização,
//   data de construção e os seus proprietários.
//
// ============================================================
#endregion

using System;

namespace BO
{
    /// <summary>
    /// Classe que representa um condomínio.
    /// Contém informação base e o conjunto de condóminos.
    /// </summary>
    [Serializable]
    public class Condominio
    {
        #region Attributes
        string nomeCondominio;
        string localizacao;
        string dataConstrucao;
        List<Condomino> proprietarios;
        List<Fraccao> fracoes;
        List<Despesa> despesas;
        #endregion

        #region Properties
        /// <summary>
        /// Nome do condomínio.
        /// </summary>
        public string NomeCondominio
        {
            get { return nomeCondominio; }
            set { nomeCondominio = value; }
        }

        /// <summary>
        /// Localização do condomínio.
        /// </summary>
        public string Localizacao
        {
            get { return localizacao; }
            set { localizacao = value; }
        }

        /// <summary>
        /// Data da construção do edifício.
        /// </summary>
        public string DataConstrucao
        {
            get { return dataConstrucao; }
            set { dataConstrucao = value; }
        }

        /// <summary>
        /// Lista de proprietários das frações.
        /// </summary>
        public List<Condomino> Proprietarios
        {
            get { return proprietarios; }
            set { proprietarios = value; }
        }

        /// <summary>
        /// Lista das frações.
        /// </summary>
        public List<Fraccao> Fracoes
        {
            get { return fracoes; }
            set { fracoes = value; }
        }

        /// <summary>
        /// Lista das despesas.
        /// </summary>
        public List<Despesa> Despesas
        {
            get { return despesas; }
            set { despesas = value; }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Método simples para criação do condomínio.
        /// </summary>
        public int CriarCondominio()
        {
            return 0;
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Construtor principal do Condomínio.
        /// </summary>
        public Condominio(string nomeCondominio, string localizacao, string dataConstrucao, Condomino[] proprietarios)
        {
            this.nomeCondominio = nomeCondominio;
            this.localizacao = localizacao;
            this.dataConstrucao = dataConstrucao;
            this.proprietarios = proprietarios;
        }
        #endregion
    }
}
