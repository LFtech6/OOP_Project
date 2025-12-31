#region author info
// ============================================================
// Author: Rodrigo Lopes Ferreira
// Date:    {13/11/2025}
// Project: {Gestão de Condomínios}
// File:    {condominiosRN.cs}
//
// Description:
//   Regras de Negócio (RN) associadas a condomínios.
//
// ============================================================
#endregion

using BO;

namespace RegrasNegocio
{
    /// <summary>
    /// Regras de Negócio para condomínios.
    /// </summary>
    public static class CondominiosRN
    {
        #region Methods

        /// <summary>
        /// Valida os dados de um condomínio.
        /// </summary>
        public static bool ValidarCondominio(Condominio c, out string erro)
        {
            erro = "";

            if (c == null)
            {
                erro = "O condomínio é inválido.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(c.NomeCondominio))
            {
                erro = "O nome do condomínio é obrigatório.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(c.Localizacao))
            {
                erro = "A localização do condomínio é obrigatória.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(c.DataConstrucao))
            {
                erro = "A data de construção é obrigatória.";
                return false;
            }

            return true;
        }

        #endregion
    }
}
