#region author info
// ============================================================
// Author: Rodrigo Lopes Ferreira
// Date:    {13/11/2025}
// Project: {Gestão de Condomínios}
// File:    {FicheiroExcecoes.cs}
// Description: Exceção personalizada para a DL
//
// ============================================================
#endregion

using System;

namespace Exceptions
{
    /// <summary>
    /// Exceção personalizada para tratar erros específicos de operações com ficheiros.
    /// Herda de ApplicationException para distinguir erros de negócio
    /// de erros de sistema (SystemException).
    /// </summary>
    public class FicheiroException : ApplicationException
    {
        /// <summary>
        /// Construtor vazio. Inicializa a exceção com uma mensagem genérica.
        /// </summary>
        public FicheiroException() : base("Erro genérico de ficheiros.")
        {
        }

        /// <summary>
        /// Construtor com mensagem personalizada.
        /// </summary>
        public FicheiroException(string msg) : base(msg)
        {
        }

        /// <summary>
        /// Construtor completo com mensagem e exceção original.
        /// </summary>
        public FicheiroException(string msg, Exception e) : base(msg, e)
        {
        }
    }
}
