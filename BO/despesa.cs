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
        int idDespesa;
        int idCondominio;
        string descricao;
        double valor;
        DateTime data;
        #endregion

        #region Properties
        /// <summary>
        /// Id da despesa.
        /// </summary>
        public int IdDespesa
        {
            get { return idDespesa; }
            set { idDespesa = value; }
        }

        /// <summary>
        /// Condomínio que tem esta despesa.
        /// </summary>
        public int IdCondominio
        {
            get { return idCondominio; }
            set { idCondominio = value; }
        }

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
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }
        #endregion

        #region Methods
        #endregion

        #region Constructor
        /// <summary>
        /// Construtor que inicializa a despesa.
        /// </summary>
        public Despesa(int idDespesa, int idCondominio, string descricao, double valor, DateTime data)
        {
            this.idDespesa = idDespesa;
            this.idCondominio = idCondominio;
            this.descricao = descricao;
            this.valor = valor;
            this.data = data;
        }
        #endregion
    }
}
