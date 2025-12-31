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
    public enum MetodoPagamento
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
        int idPagamento;
        int idCondominio;
        int nifMorador;
        int idDespesa;
        double valorPago;
        DateTime dataPagamento;
        MetodoPagamento metodo;
        #endregion

        #region Properties
        /// <summary>
        /// Id do pagamento.
        /// </summary>
        public int IdPagamento
        {
            get { return idPagamento; }
            set { idPagamento = value; }
        }

        /// <summary>
        /// Id do condomínio.
        /// </summary>
        public int IdCondominio
        {
            get { return idCondominio; }
            set { idCondominio = value; }
        }

        /// <summary>
        /// Nif do morador.
        /// </summary>
        public int NifMorador
        {
            get { return nifMorador; }
            set { nifMorador = value; }
        }

        /// <summary>
        /// Id da despesa.
        /// </summary>
        public int IdDespesa
        {
            get { return idDespesa; }
            set { idDespesa = value; }
        }

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
        public DateTime DataPagamento
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
        public Pagamento(int idPagamento, int idCondominio, int nifMorador, int idDespesa, double valorPago, DateTime dataPagamento, MetodoPagamento metodo)
        {
            this.idPagamento = idPagamento;
            this.idCondominio = idCondominio;
            this.nifMorador = nifMorador;
            this.idDespesa = idDespesa;
            this.valorPago = valorPago;
            this.dataPagamento = dataPagamento;
            this.metodo = metodo;
        }
        #endregion
    }
}
