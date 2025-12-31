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
    /// Contém informação base e o conjunto de moradors.
    /// </summary>
    [Serializable]
    public class Condominio
    {
        #region Attributes
        int idCondominio;
        string nomeCondominio;
        string localizacao;
        string dataConstrucao;
        #endregion

        #region Properties
        /// <summary>
        /// Id do condomínio.
        /// </summary>
        public int IdCondominio
        {
            get { return idCondominio; }
            set { idCondominio = value; }
        }

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
        #endregion

        #region Methods
        #endregion

        #region Constructor
        /// <summary>
        /// Construtor principal do Condomínio.
        /// </summary>
        public Condominio(int idCondominio, string nomeCondominio, string localizacao, string dataConstrucao)
        {
            this.idCondominio = idCondominio;
            this.nomeCondominio = nomeCondominio;
            this.localizacao = localizacao;
            this.dataConstrucao = dataConstrucao;
        }
        #endregion
    }
}
