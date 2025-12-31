#region author info
// ============================================================
// Author: Rodrigo Lopes Ferreira
// Date:    {13/11/2025}
// Project: {Gestão de Condomínios}
// File:    {documentosRN.cs}
//
// Description:
//   Regras de Negócio (RN) associadas a documentos.
//
// ============================================================
#endregion

using BO;

namespace RegrasNegocio
{
    /// <summary>
    /// Regras de Negócio para documentos.
    /// </summary>
    public static class DocumentosRN
    {
        #region Methods

        /// <summary>
        /// Valida os dados de um documento.
        /// </summary>
        public static bool ValidarDocumento(Documento d, out string erro)
        {
            erro = "";

            if (d == null)
            {
                erro = "O documento é inválido.";
                return false;
            }

            if (d.IdCondominio <= 0)
            {
                erro = "O condomínio do documento é inválido.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(d.Titulo))
            {
                erro = "O título do documento é obrigatório.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(d.Conteudo))
            {
                erro = "O conteúdo do documento é obrigatório.";
                return false;
            }

            if (d.IdReuniao <= 0 && d.IdDespesa <= 0)
            {
                erro = "O documento tem de estar associado a uma reunião ou a uma despesa.";
                return false;
            }

            return true;
        }

        #endregion
    }
}
