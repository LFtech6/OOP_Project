#region author info
// ============================================================
// Author: Rodrigo Lopes Ferreira
// Date:    {23/12/2025}
// Project: {Gestão de Condomínios}
// File:    {inquilino.cs}
//
// Description:
//   Representa um inquilino que arrenda uma fração.
//   Herda de Pessoa, justificando a abstração.
//
// ============================================================
#endregion

using System;

namespace BO
{
    /// <summary>
    /// Classe que representa um Inquilino.
    /// Diferente do morador, o Inquilino não tem permilagem nem voto, mas tem um contrato de arrendamento.
    /// </summary>
    [Serializable]
    public class Inquilino : Morador
    {
        #region Attributes
        DateTime dataInicioContrato;
        int duracaoMeses;
        string idFraccao;
        #endregion

        #region Properties

        /// <summary>
        /// Data em que começou o contrato de arrendamento.
        /// </summary>
        public DateTime DataInicioContrato
        {
            get { return dataInicioContrato; }
            set { dataInicioContrato = value; }
        }

        /// <summary>
        /// Duração do contrato em meses.
        /// </summary>
        public int DuracaoMeses
        {
            get { return duracaoMeses; }
            set { duracaoMeses = value; }
        }

        /// <summary>
        /// Identificação da fração onde o inquilino mora.
        /// </summary>
        public string IdFraccao
        {
            get { return idFraccao; }
            set { idFraccao = value; }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Implementação do método abstrato da classe morador.
        /// </summary>
        public override int IdentificarMorador()
        {
            // Retorna o NIF como identificador único
            return this.Nif;
        }

        /// <summary>
        /// Método extra: Verifica se o contrato ainda está válido.
        /// </summary>
        public bool VerificarValidadeContrato()
        {
            // Lógica simples para exemplo
            return duracaoMeses > 0;
        }
        #endregion

        #region Constructor

        /// <summary>
        /// Construtor do Inquilino.
        /// </summary>
        public Inquilino(string nome, int nif, string contacto, int idCondominio, DateTime dataInicioContrato, int duracaoMeses, string idFraccao)
            : base(nome, nif, contacto, idCondominio)
        {
            this.dataInicioContrato = dataInicioContrato;
            this.duracaoMeses = duracaoMeses;
            this.idFraccao = idFraccao;
        }

        #endregion
    }
}