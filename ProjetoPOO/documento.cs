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

namespace EmpGestCondominios
{
    enum TipoDocumento
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
    class Documento
    {
        #region Attributes
        string titulo;
        string conteudo;
        string dataCriacao;
        string autor;
        TipoDocumento tipo;
        #endregion

        #region Properties
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
        public string DataCriacao
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
        /// <summary>
        /// Método placeholder para criação de documento.
        /// </summary>
        public int CriarDocumento()
        {
            return 0;
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Construtor do documento.
        /// </summary>
        public Documento(string titulo, string conteudo, string dataCriacao, string autor, TipoDocumento tipo)
        {
            this.titulo = titulo;
            this.conteudo = conteudo;
            this.dataCriacao = dataCriacao;
            this.autor = autor;
            this.tipo = tipo;
        }
        #endregion
    }
}
