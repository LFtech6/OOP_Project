#region author info
// ============================================================
// Author: Rodrigo Lopes Ferreira
// Date:    {13/11/2025}
// Project: {Gestão de Condomínios}
// File:    {permilagem.cs}
//
// Description:
//   Permilagem = (Valor da Fração / Valor Total do Edifício) * 1000.
//   Guarda os dados necessários ao cálculo nas regras de negócio   .
//
// ============================================================
#endregion

using System;

namespace BO
{
    /// <summary>
    /// Representa o cálculo de permilagem de uma fração.
    /// </summary>
    [Serializable]
    public class Permilagem
    {
        #region Attributes
        double valorFracao;
        double valorTotalEdificio;
        string idFraccao;
        #endregion

        #region Properties
        /// <summary>
        /// Valor da fração.
        /// </summary>
        public double ValorFracao
        {
            get { return valorFracao; }
            set { valorFracao = value; }
        }

        /// <summary>
        /// Valor total do edifício.
        /// </summary>
        public double ValorTotalEdificio
        {
            get { return valorTotalEdificio; }
            set { valorTotalEdificio = value; }
        }

        /// <summary>
        /// Fração associada ao cálculo.
        /// </summary>
        public string IdFraccao
        {
            get { return idFraccao; }
            set { idFraccao = value; }
        }
        #endregion

        #region Methods
        #endregion

        #region Constructor
        /// <summary>
        /// Construtor que inicializa os valores necessários ao cálculo.
        /// </summary>
        public Permilagem(double valorFracao, double valorTotalEdificio, string idFraccao)
        {
            this.valorFracao = valorFracao;
            this.valorTotalEdificio = valorTotalEdificio;
            this.idFraccao = idFraccao;
        }
        #endregion
    }
}
