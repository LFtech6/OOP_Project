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

namespace BO
{
    /// <summary>
    /// Representa uma fração do condomínio.
    /// </summary>
    [Serializable]
    public class Fraccao
    {
        #region Attributes
        int idFraccao;
        float area;
        Condomino proprietario;
        #endregion

        #region Properties
        /// <summary>
        /// Identificação da fração (ex.: A1, B2).
        /// </summary>
        public int IdFraccao
        {
            get { return idFraccao; }
            set { idFraccao = value; }
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
        public Fraccao(int idFraccao, float area, Condomino proprietario)
        {
            this.idFraccao = idFraccao;
            this.area = area;
            this.proprietario = proprietario;
        }
        #endregion
    }
}
