#region author info
// ============================================================
// Author: Rodrigo Lopes Ferreira
// Date:    {13/11/2025}
// Project: {Gestão de Condomínios}
// File:    {proprietariosRN.cs}
//
// Description:
//   Regras de Negócio (RN) específicas de proprietários.
//
// ============================================================
#endregion

using BO;

namespace RegrasNegocio
{
    /// <summary>
    /// Regras de Negócio para proprietários.
    /// </summary>
    public static class ProprietariosRN
    {
        #region Methods

        /// <summary>
        /// Valida os dados específicos de um proprietário.
        /// </summary>
        public static bool ValidarProprietario(Proprietario p, out string erro)
        {
            erro = "";

            if (!MoradoresRN.ValidarMorador(p, out erro))
                return false;

            if (string.IsNullOrWhiteSpace(p.IdFraccao))
            {
                erro = "O proprietário tem de estar associado a uma fração.";
                return false;
            }

            if (p.Piso < 0)
            {
                erro = "O piso do proprietário é inválido.";
                return false;
            }

            if (p.Permilagem < 0 || p.Permilagem > 1000)
            {
                erro = "A permilagem tem de estar entre 0 e 1000.";
                return false;
            }

            return true;
        }

        #endregion
    }
}
