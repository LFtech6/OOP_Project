#region author info
// ============================================================
// Author: Rodrigo Lopes Ferreira
// Date:    {13/11/2025}
// Project: {Gestão de Condomínios}
// File:    {permilagensRN.cs}
//
// Description:
//   Regras de Negócio (RN) para cálculo de permilagem.
//   Permilagem = (Valor da Fração / Valor Total do Edifício) * 1000.
//
// ============================================================
#endregion

using System;
using BO;

namespace Regras
{
    /// <summary>
    /// Classe de Regras de Negócio responsável pelo cálculo e validação
    /// associados à permilagem.
    /// </summary>
    public static class PermilagensRN
    {
        #region Methods

        /// <summary>
        /// Calcula a permilagem de acordo com a fórmula:
        /// (valorFracao / valorTotalEdificio) * 1000.
        /// </summary>
        public static double Calcular(double valorFracao, double valorTotalEdificio)
        {
            if (valorTotalEdificio <= 0)
                throw new ArgumentException("O valor total do edifício tem de ser > 0.");

            if (valorFracao < 0)
                throw new ArgumentException("O valor da fração não pode ser negativo.");

            double perm = (valorFracao / valorTotalEdificio) * 1000.0;
            return Math.Round(perm, 2);
        }

        /// <summary>
        /// Calcula a permilagem com base num objeto Permilagem (BO),
        /// utilizando os seus valores armazenados.
        /// </summary>
        public static double Calcular(Permilagem p)
        {
            if (p == null)
                throw new ArgumentNullException(nameof(p));

            return Calcular(p.ValorFracao, p.ValorTotalEdificio);
        }

        #endregion
    }
}
