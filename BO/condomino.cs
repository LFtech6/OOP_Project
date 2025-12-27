#region author info
// ============================================================
// Author: Rodrigo Lopes Ferreira
// Date:    {13/11/2025}
// Project: {Gestão de Condomínios}
// File:    {condomino.cs}
//
// Description:
//   Representa um proprietário do condomínio.
//   Herda da classe Pessoa e adiciona atributos específicos.
//
// ============================================================
#endregion

using System;

namespace BO
{
    /// <summary>
    /// Classe que representa um condómino (proprietário).
    /// </summary>
    [Serializable]
    public class Condomino : Pessoa
    {
        #region Attributes
        string moradaNotificacao;
        Fraccao idFraccao;
        int piso;
        float permilagem;
        #endregion

        #region Properties
        /// <summary>
        /// Morada usada para envio de notificações.
        /// </summary>
        public string MoradaNotificacao
        {
            get { return moradaNotificacao; }
            set { moradaNotificacao = value; }
        }

        /// <summary>
        /// Fração a que o condómino pertence.
        /// </summary>
        public Fraccao IdFraccao
        {
            get { return idFraccao; }
            set { idFraccao = value; }
        }

        /// <summary>
        /// Piso onde a fração está localizada.
        /// </summary>
        public int Piso
        {
            get { return piso; }
            set { piso = value; }
        }

        /// <summary>
        /// Permilagem associada ao condómino.
        /// </summary>
        public float Permilagem
        {
            get { return permilagem; }
            set { permilagem = value; }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Implementação simples para identificar o condómino.
        /// </summary>
        public override int IdentificarPessoa()
        {
            // Retorna o NIF como identificador único
            return this.Nif;
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Construtor do condómino, inicializa todos os seus atributos.
        /// </summary>
        public Condomino(string nome, int nif, string contacto, string moradaNotificacao, Fraccao idFraccao, int piso, float permilagem)
            : base(nome, nif, contacto)
        {
            this.moradaNotificacao = moradaNotificacao;
            this.idFraccao = idFraccao;
            this.piso = piso;
            this.permilagem = permilagem;
        }
        #endregion
    }
}
