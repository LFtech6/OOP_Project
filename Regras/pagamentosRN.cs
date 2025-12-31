#region author info
// ============================================================
// Author: Rodrigo Lopes Ferreira
// Date:    {13/11/2025}
// Project: {Gestão de Condomínios}
// File:    {pagamentosRN.cs}
//
// Description:
//   Regras de Negócio (RN) associadas aos pagamentos.
//
// ============================================================
#endregion

using BO;

namespace RegrasNegocio
{
    /// <summary>
    /// Regras de Negócio para pagamentos.
    /// </summary>
    public static class PagamentosRN
    {
        #region Methods

        /// <summary>
        /// Valida os dados de um pagamento.
        /// </summary>
        public static bool ValidarPagamento(Pagamento p, out string erro)
        {
            erro = "";

            if (p == null)
            {
                erro = "O pagamento é inválido.";
                return false;
            }

            if (p.IdCondominio <= 0)
            {
                erro = "O condomínio do pagamento é inválido.";
                return false;
            }

            if (p.NifMorador < 100000000 || p.NifMorador > 999999999)
            {
                erro = "O NIF do morador é inválido.";
                return false;
            }

            if (p.ValorPago <= 0)
            {
                erro = "O valor do pagamento tem de ser superior a 0.";
                return false;
            }

            return true;
        }

        #endregion
    }
}
