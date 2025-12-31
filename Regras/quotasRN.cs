#region author info
// ============================================================
// Author: Rodrigo Lopes Ferreira
// Date:    {13/11/2025}
// Project: {Gestão de Condomínios}
// File:    {quotasRN.cs}
//
// Description:
//   Regras de negócio associadas às quotas do condomínio,
//   incluindo validações e cálculos.
//
// ============================================================
#endregion

using System;
using BO;

namespace RegrasNegocio
{
    public static class QuotasRN
    {
        /// <summary>
        /// Valida uma quota de acordo com as regras de negócio.
        /// </summary>
        public static bool ValidarQuota(Quota q, out string erro)
        {
            erro = "";

            if (q == null)
            {
                erro = "A quota é inválida.";
                return false;
            }

            if (q.Mes < 1 || q.Mes > 12)
            {
                erro = "O mês tem de estar entre 1 e 12.";
                return false;
            }

            if (q.Ano < 2000 || q.Ano > 2100)
            {
                erro = "O ano da quota é inválido.";
                return false;
            }

            if (q.Valor < 0)
            {
                erro = "O valor da quota não pode ser negativo.";
                return false;
            }

            if (q.IdCondominio <= 0)
            {
                erro = "O condomínio associado à quota é inválido.";
                return false;
            }

            if (q.NifMorador < 100000000 || q.NifMorador > 999999999)
            {
                erro = "O NIF do morador associado à quota é inválido.";
                return false;
            }

            return true;
        }

        /// <summary>
        /// Calcula o valor da quota com base na permilagem.
        /// Fórmula: (permilagem / 1000) * totalMensalCondominio
        /// </summary>
        public static double CalcularValorQuota(double permilagem, double totalMensalCondominio)
        {
            if (permilagem < 0)
                throw new ArgumentOutOfRangeException(nameof(permilagem));

            if (totalMensalCondominio < 0)
                throw new ArgumentOutOfRangeException(nameof(totalMensalCondominio));

            double valor = (permilagem / 1000.0) * totalMensalCondominio;
            return Math.Round(valor, 2);
        }
    }
}
