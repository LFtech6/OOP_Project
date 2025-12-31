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
        string idFraccao;
        float area;
        int nifMorador;
        int idCondominio;
        #endregion

        #region Properties
        /// <summary>
        /// Identificação da fracção (ex.: A1, B2).
        /// </summary>
        public string IdFraccao
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
        /// Proprietário da fracção.
        /// </summary>
        public int NifMorador
        {
            get { return nifMorador; }
            set { nifMorador = value; }
        }

        /// <summary>
        /// Condomínio a que pertence a fracção.
        /// </summary>
        public int IdCondominio 
        { 
            get { return idCondominio; } 
            set { idCondominio = value; } 
        }
        #endregion

        #region Methods
        #endregion

        #region Constructor
        /// <summary>
        /// Construtor que inicializa a fração.
        /// </summary>
        public Fraccao(string idFraccao, float area, int nifMorador, int idCondominio)
        {
            this.idFraccao = idFraccao;
            this.area = area;
            this.nifMorador = nifMorador;
            this.idCondominio = idCondominio;
        }
        #endregion
    }
}
