#region author info
// ============================================================
// Author: Rodrigo Lopes Ferreira
// Date:    {13/11/2025}
// Project: {Gestão de Condomínios}
// File:    {inquilinosRN.cs}
//
// Description:
//   Regras de Negócio (RN) específicas de inquilinos.
//
// ============================================================
#endregion

using BO;
using System;

namespace RegrasNegocio
{
    /// <summary>
    /// Regras de Negócio para inquilinos.
    /// </summary>
    public static class InquilinosRN
    {
        #region Methods

        /// <summary>
        /// Valida os dados específicos de um inquilino.
        /// </summary>
        public static bool ValidarInquilino(Inquilino i, out string erro)
        {
            erro = "";

            if (!MoradoresRN.ValidarMorador(i, out erro))
                return false;

            if (string.IsNullOrWhiteSpace(i.IdFraccao))
            {
                erro = "O inquilino tem de estar associado a uma fração.";
                return false;
            }

            if (i.DuracaoMeses <= 0)
            {
                erro = "A duração do contrato tem de ser superior a 0 meses.";
                return false;
            }

            if (i.DataInicioContrato == DateTime.MinValue)
            {
                erro = "A data de início do contrato é inválida.";
                return false;
            }

            return true;
        }

        #endregion
    }
}
