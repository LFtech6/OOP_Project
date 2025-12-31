#region author info
// ============================================================
// Author: Rodrigo Lopes Ferreira
// Date:    {13/11/2025}
// Project: {Gestão de Condomínios}
// File:    {despesasRN.cs}
//
// Description:
//   Regras de Negócio (RN) associadas às despesas.
//
// ============================================================
#endregion

using BO;

namespace RegrasNegocio
{
    /// <summary>
    /// Regras de Negócio para despesas.
    /// </summary>
    public static class DespesasRN
    {
        #region Methods

        /// <summary>
        /// Valida os dados de uma despesa.
        /// </summary>
        public static bool ValidarDespesa(Despesa d, out string erro)
        {
            erro = "";

            if (d == null)
            {
                erro = "A despesa é inválida.";
                return false;
            }

            if (d.IdCondominio <= 0)
            {
                erro = "O condomínio da despesa é inválido.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(d.Descricao))
            {
                erro = "A descrição da despesa é obrigatória.";
                return false;
            }

            if (d.Valor <= 0)
            {
                erro = "O valor da despesa tem de ser superior a 0.";
                return false;
            }

            return true;
        }

        #endregion
    }
}
