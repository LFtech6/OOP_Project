#region author info
// ============================================================
// Author: Rodrigo Lopes Ferreira
// Date:    {13/11/2025}
// Project: {Gestão de Condomínios}
// File:    {moradoresRN.cs}
//
// Description:
//   Regras de Negócio (RN) associadas aos moradores.
//   Valida dados base comuns a proprietários e inquilinos.
//
// ============================================================
#endregion

using BO;

namespace RegrasNegocio
{
    /// <summary>
    /// Regras de Negócio para validação de moradores.
    /// </summary>
    public static class MoradoresRN
    {
        #region Methods

        /// <summary>
        /// Valida os dados base de um morador.
        /// </summary>
        public static bool ValidarMorador(Morador m, out string erro)
        {
            erro = "";

            if (m == null)
            {
                erro = "O morador é inválido.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(m.Nome))
            {
                erro = "O nome do morador é obrigatório.";
                return false;
            }

            if (m.Nif < 100000000 || m.Nif > 999999999)
            {
                erro = "O NIF do morador é inválido.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(m.Contacto))
            {
                erro = "O contacto do morador é obrigatório.";
                return false;
            }

            if (m.IdCondominio <= 0)
            {
                erro = "O condomínio do morador é inválido.";
                return false;
            }

            return true;
        }

        #endregion
    }
}
