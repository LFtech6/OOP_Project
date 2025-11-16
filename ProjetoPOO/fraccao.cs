#region author info
// ============================================================
// Author: Rodrigo Lopes Ferreira
// Date:    {13/11/2025}
// Project: {Gestão de Condomínios}
// File:    {fraccao.cs}
//
// Description:
//   Representa uma fração pertencente ao condomínio,
//   com identificação, área e proprietário associado.
//
// ============================================================
#endregion

using System;

namespace EmpGestCondominios
{
    /// <summary>
    /// Representa uma fração do condomínio.
    /// </summary>
    class Fraccao
    {
        #region Attributes
        string identificacao;
        float area;
        Condomino proprietario;
        #endregion

        #region Properties
        /// <summary>
        /// Identificação da fração (ex.: A1, B2).
        /// </summary>
        public string Identificacao
        {
            get { return identificacao; }
            set { identificacao = value; }
        }

        /// <summary>
        /// Área da fração em metros quadrados.
        /// </summary>
        public float Area
        {
            get { return area; }
            set { area = value; }
        }

        /// <summary>
        /// Proprietário da fração.
        /// </summary>
        public Condomino Proprietario
        {
            get { return proprietario; }
            set { proprietario = value; }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Método placeholder para criar uma fração.
        /// </summary>
        public int CriarFraccao()
        {
            return 0;
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Construtor que inicializa a fração.
        /// </summary>
        public Fraccao(string identificacao, float area, Condomino proprietario)
        {
            this.identificacao = identificacao;
            this.area = area;
            this.proprietario = proprietario;
        }
        #endregion
    }
}
