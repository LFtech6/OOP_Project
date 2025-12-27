#region author info
// ============================================================
// Author: Rodrigo Lopes Ferreira
// Date:    {13/11/2025}
// Project: {Gestão de Condomínios}
// File:    {pessoa.cs}
//
// Description:
//   Classe abstrata que serve de base a todos os tipos de pessoas
//   no sistema, fornecendo atributos comuns.
//
// ============================================================
#endregion

using System;

namespace BO
{
    /// <summary>
    /// Classe abstrata que representa uma pessoa genérica do sistema.
    /// </summary>
    [Serializable]
    public abstract class Pessoa
    {
        #region Attributes
        string nome;
        int nif;
        string contacto;
        #endregion

        #region Properties
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
        /// Contacto telefónico da pessoa.
        /// </summary>
        public string Contacto
        {
            get { return contacto; }
            set { contacto = value; }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Método abstrato para identificar a pessoa.
        /// </summary>
        public abstract int IdentificarPessoa();
        #endregion

        #region Constructor
        /// <summary>
        /// Construtor base para inicializar uma pessoa.
        /// </summary>
        public Pessoa(string nome, int nif, string contacto)
        {
            this.nome = nome;
            this.nif = nif;
            this.contacto = contacto;
        }
        #endregion
    }
}
