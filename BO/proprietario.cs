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
    /// Classe que representa um proprietário.
    /// </summary>
    [Serializable]
    public class Proprietario : Morador
    {
        #region Attributes
        string moradaNotificacao;
        string idFraccao;
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
        /// Fração a que o morador pertence.
        /// </summary>
        public string IdFraccao
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
        /// Permilagem associada ao morador.
        /// </summary>
        public float Permilagem
        {
            get { return permilagem; }
            set { permilagem = value; }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Implementação simples para identificar o morador.
        /// </summary>
        public override int IdentificarMorador()
        {
            // Retorna o NIF como identificador único
            return this.Nif;
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Construtor do proprietário, inicializa todos os seus atributos.
        /// </summary>
        public Proprietario(string nome, int nif, string contacto, int idCondominio, string moradaNotificacao, string idFraccao, int piso, float permilagem)
            : base(nome, nif, contacto, idCondominio)
        {
            this.moradaNotificacao = moradaNotificacao;
            this.idFraccao = idFraccao;
            this.piso = piso;
            this.permilagem = permilagem;
        }
        #endregion
    }
}
