#region author info
// ============================================================
// Author: Rodrigo Lopes Ferreira
// Date:    {13/11/2025}
// Project: {Gestão de Condomínios}
// File:    {reunioesRN.cs}
//
// Description:
//   Regras de Negócio (RN) associadas às reuniões.
//
// ============================================================
#endregion

using BO;
using System;

namespace RegrasNegocio
{
    /// <summary>
    /// Regras de Negócio para reuniões de condomínio.
    /// </summary>
    public static class ReunioesRN
    {
        #region Methods

        /// <summary>
        /// Valida os dados de uma reunião.
        /// </summary>
        public static bool ValidarReuniao(Reuniao r, out string erro)
        {
            erro = "";

            if (r == null)
            {
                erro = "A reunião é inválida.";
                return false;
            }

            if (r.IdCondominio <= 0)
            {
                erro = "O condomínio da reunião é inválido.";
                return false;
            }

            if (r.Data == DateTime.MinValue)
            {
                erro = "A data da reunião é inválida.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(r.Local))
            {
                erro = "O local da reunião é obrigatório.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(r.ListaTemas))
            {
                erro = "A lista de temas da reunião é obrigatória.";
                return false;
            }

            return true;
        }

        #endregion
    }
}
