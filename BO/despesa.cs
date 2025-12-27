#region author info
// ============================================================
// Author: Rodrigo Lopes Ferreira
// Date:    {13/11/2025}
// Project: {Gestão de Condomínios}
// File:    {despesa.cs}
//
// Description:
//   Regista uma despesa do condomínio.
//
// ============================================================
#endregion

using System;

namespace BO
{
    /// <summary>
    /// Representa uma despesa efetuada pelo condomínio.
    /// </summary>
    [Serializable]
    public class Despesa
    {
        #region Attributes
        string descricao;
        double valor;
        string data;
        #endregion

        #region Properties
        /// <summary>
        /// Descrição da despesa.
        /// </summary>
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        /// <summary>
        /// Valor da despesa.
        /// </summary>
        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        /// <summary>
        /// Data em que a despesa ocorreu.
        /// </summary>
        public string Data
        {
            get { return data; }
            set { data = value; }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Método placeholder para registar a despesa.
        /// </summary>
        public int RegistarDespesa()
        {
            return 0;
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Construtor que inicializa a despesa.
        /// </summary>
        public Despesa(string descricao, double valor, string data)
        {
            this.descricao = descricao;
            this.valor = valor;
            this.data = data;
        }
        #endregion
    }
}
