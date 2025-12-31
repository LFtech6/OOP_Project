#region author info
// ============================================================
// Author: Rodrigo Lopes Ferreira
// Date:    {13/11/2025}
// Project: {Gestão de Condomínios}
// File:    {morador.cs}
//
// Description:
//   Classe abstrata que serve de base para os tipos de
//   morador no sistema, fornecendo atributos comuns.
//
// ============================================================
#endregion

using System;

namespace BO
{
    /// <summary>
    /// Classe abstrata que representa um morador genérico do sistema.
    /// </summary>
    [Serializable]
    public abstract class Morador
    {
        #region Attributes
        string nome;
        int nif;
        string contacto;
        int idCondominio;
        #endregion

        #region 
        /// <summary>
        /// Nome da pessoa.
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        /// <summary>
        /// Número de identificação fiscal.
        /// </summary>
        public int Nif
        {
            get { return nif; }
            set { nif = value; }
        }

        /// <summary>
        /// Contacto telefónico do morador.
        /// </summary>
        public string Contacto
        {
            get { return contacto; }
            set { contacto = value; }
        }

        /// <summary>
        /// Id do condomínio do morador.
        /// </summary>
        public int IdCondominio 
        { 
            get { return idCondominio; } 
            set { idCondominio = value; } 
        }
        #endregion

        #region Methods
        /// <summary>
        /// Método abstrato para identificar o morador.
        /// </summary>
        public abstract int IdentificarMorador();
        #endregion

        #region Constructor
        /// <summary>
        /// Construtor base para inicializar um morador.
        /// </summary>
        public Morador(string nome, int nif, string contacto, int idCondominio)
        {
            this.nome = nome;
            this.nif = nif;
            this.contacto = contacto;
            this.idCondominio = idCondominio;
        }
        #endregion
    }
}
