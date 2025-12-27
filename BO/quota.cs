#region author info
// ============================================================
// Author: Rodrigo Lopes Ferreira
// Date:    {13/11/2025}
// Project: {Gestão de Condomínios}
// File:    {quota.cs}
//
// Description:
//   Representa uma quota mensal do condomínio.
//
// ============================================================
#endregion

using System;

namespace BO
{
    /// <summary>
    /// Representa uma quota mensal associada a um condómino.
    /// </summary>
    [Serializable]
    public class Quota
    {
        #region Attributes
        double valor;
        string mes;
        string ano;
        #endregion

        #region Properties
        /// <summary>
        /// Valor da quota.
        /// </summary>
        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        /// <summary>
        /// Mês a que a quota se refere.
        /// </summary>
        public string Mes
        {
            get { return mes; }
            set { mes = value; }
        }

        /// <summary>
        /// Ano a que a quota se refere.
        /// </summary>
        public string Ano
        {
            get { return ano; }
            set { ano = value; }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Método placeholder para registo da quota.
        /// </summary>
        public int RegistarQuota()
        {
            return 0;
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Construtor que inicializa a quota.
        /// </summary>
        public Quota(double valor, string mes, string ano)
        {
            this.valor = valor;
            this.mes = mes;
            this.ano = ano;
        }
        #endregion
    }
}
