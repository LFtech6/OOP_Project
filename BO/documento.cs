#region author info
// ============================================================
// Author: Rodrigo Lopes Ferreira
// Date:    {13/11/2025}
// Project: {Gestão de Condomínios}
// File:    {documento.cs}
//
// Description:
//   Representa um documento associado ao condomínio.
//   Pode ser uma ata, contrato, comunicação ou relatório.
//
// ============================================================
#endregion

using System;

namespace BO
{
    /// <summary>
    /// Vários tipos de documentos.
    /// </summary>
    public enum TipoDocumento
    {
        Ata,
        Contrato,
        Comunicacao,
        Relatorio,
        Fatura,
        Orcamento,
        RegrasInternas,
        Seguro,
        Outro
    }

    /// <summary>
    /// Representa um documento do condomínio.
    /// </summary>
    [Serializable]
    public class Documento
    {
        #region Attributes
        int idDocumento;
        int idCondominio;
        int idReuniao;
        int idDespesa;
        string titulo;
        string conteudo;
        DateTime dataCriacao;
        string autor;
        TipoDocumento tipo;
        #endregion

        #region Properties
        /// <summary>
        /// Id do documento.
        /// </summary>
        public int IdDocumento
        {
            get { return idDocumento; }
            set { idDocumento = value; }
        }

        /// <summary>
        /// Id do condomínio.
        /// </summary>
        public int IdCondominio
        {
            get { return idCondominio; }
            set { idCondominio = value; }
        }

        /// <summary>
        /// Id da reunião.
        /// </summary>
        public int IdReuniao
        {
            get { return idReuniao; }
            set { idReuniao = value; }
        }

        /// <summary>
        /// Id da despesa.
        /// </summary>
        public int IdDespesa
        {
            get { return idDespesa; }
            set { idDespesa = value; }
        }

        /// <summary>
        /// Título do documento.
        /// </summary>
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        /// <summary>
        /// Conteúdo textual do documento.
        /// </summary>
        public string Conteudo
        {
            get { return conteudo; }
            set { conteudo = value; }
        }

        /// <summary>
        /// Data de criação do documento.
        /// </summary>
        public DateTime DataCriacao
        {
            get { return dataCriacao; }
            set { dataCriacao = value; }
        }

        /// <summary>
        /// Autor do documento.
        /// </summary>
        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }

        /// <summary>
        /// Tipo do documento (ata, contrato, etc.).
        /// </summary>
        public TipoDocumento Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        #endregion

        #region Methods
        #endregion

        #region Constructor
        /// <summary>
        /// Construtor do documento.
        /// </summary>
        public Documento(int idDocumento, int idCondominio, int idReuniao, int idDespesa, string titulo, string conteudo, DateTime dataCriacao, string autor, TipoDocumento tipo)
        {
            this.idDocumento = idDocumento;
            this.idCondominio = idCondominio;
            this.idReuniao = idReuniao;
            this.idDespesa = idDespesa;
            this.titulo = titulo;
            this.conteudo = conteudo;
            this.dataCriacao = dataCriacao;
            this.autor = autor;
            this.tipo = tipo;
        }
        #endregion
    }
}
