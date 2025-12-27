#region author info
// ============================================================
// Author: Rodrigo Lopes Ferreira
// Date:    {13/11/2025}
// Project: {Gestão de Condomínios}
// File:    {pagamento.cs}
//
// Description:
//   Representa um pagamento de quota efetuado por um condómino.
//
// ============================================================
#endregion

using System;

namespace BO
{
    enum MetodoPagamento
    {
        Transferencia,
        Mbway,
        Numerario,
        Cheque,
        Outro
    }

    /// <summary>
    /// Representa o pagamento de uma quota.
    /// </summary>
    [Serializable]
    public class Pagamento
    {
        #region Attributes
        double valorPago;
        string dataPagamento;
        MetodoPagamento metodo;
        #endregion

        #region Properties
        /// <summary>
        /// Valor pago.
        /// </summary>
        public double ValorPago
        {
            get { return valorPago; }
            set { valorPago = value; }
        }

        /// <summary>
        /// Data do pagamento.
        /// </summary>
        public string DataPagamento
        {
            get { return dataPagamento; }
            set { dataPagamento = value; }
        }

        /// <summary>
        /// Método utilizado para o pagamento.
        /// </summary>
        public MetodoPagamento Metodo
        {
            get { return metodo; }
            set { metodo = value; }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Método placeholder para registar o pagamento.
        /// </summary>
        public int RegistarPagamento()
        {
            return 0;
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Construtor que inicializa o pagamento.
        /// </summary>
        public Pagamento(double valorPago, string dataPagamento, MetodoPagamento metodo)
        {
            this.valorPago = valorPago;
            this.dataPagamento = dataPagamento;
            this.metodo = metodo;
        }
        #endregion
    }
}
