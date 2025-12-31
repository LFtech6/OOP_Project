#region author info
// ============================================================
// Author: Rodrigo Lopes Ferreira
// Date:    {13/11/2025}
// Project: {Gestão de Condomínios}
// File:    {fraccoesRN.cs}
//
// Description:
//   Regras de Negócio (RN) associadas às frações.
//
// ============================================================
#endregion

using BO;

namespace RegrasNegocio
{
    /// <summary>
    /// Regras de Negócio para frações.
    /// </summary>
    public static class FraccoesRN
    {
        #region Methods

        /// <summary>
        /// Valida os dados de uma fração.
        /// </summary>
        public static bool ValidarFraccao(Fraccao f, out string erro)
        {
            erro = "";

            if (f == null)
            {
                erro = "A fração é inválida.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(f.IdFraccao))
            {
                erro = "O identificador da fração é obrigatório.";
                return false;
            }

            if (f.Area <= 0)
            {
                erro = "A área da fração tem de ser superior a 0.";
                return false;
            }

            if (f.IdCondominio <= 0)
            {
                erro = "O condomínio da fração é inválido.";
                return false;
            }

            if (f.NifMorador <= 0)
            {
                erro = "O morador associado à fração é inválido.";
                return false;
            }

            return true;
        }

        #endregion
    }
}
