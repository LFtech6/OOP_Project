#region author info
// ============================================================
// Author: Rodrigo Lopes Ferreira
// Date:    {13/11/2025}
// Project: {Gestão de Condomínios}
// File:    {quota.cs}
//
// Description:
//   Representa uma quota mensal do condomínio.
//   Classe de dados (BO), sem regras de negócio.
//   As validações e cálculos são tratados na camada RN.
//
// ============================================================
#endregion

using System;

namespace BO
{
    /// <summary>
    /// Representa uma quota mensal associada a um morador de um condomínio.
    /// Esta classe contém apenas dados, sendo as regras de negócio
    /// definidas na respetiva camada de Regras de Negócio (RN).
    /// </summary>
    [Serializable]
    public class Quota
    {
        #region Attributes
        int idQuota;
        int idCondominio;
        int nifMorador;
        int mes;
        int ano;
        double valor;
        bool paga;
        #endregion

        #region Properties

        /// <summary>
        /// Identificador único da quota.
        /// </summary>
        public int IdQuota
        {
            get { return idQuota; }
            set { idQuota = value; }
        }

        /// <summary>
        /// Identificador do condomínio ao qual a quota pertence.
        /// </summary>
        public int IdCondominio
        {
            get { return idCondominio; }
            set { idCondominio = value; }
        }

        /// <summary>
        /// Número de identificação fiscal do morador associado à quota.
        /// </summary>
        public int NifMorador
        {
            get { return nifMorador; }
            set { nifMorador = value; }
        }

        /// <summary>
        /// Mês a que a quota se refere.
        /// </summary>
        public int Mes
        {
            get { return mes; }
            set { mes = value; }
        }

        /// <summary>
        /// Ano a que a quota se refere.
        /// </summary>
        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }

        /// <summary>
        /// Valor monetário da quota.
        /// </summary>
        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        /// <summary>
        /// Indica se a quota já foi paga.
        /// </summary>
        public bool Paga
        {
            get { return paga; }
            set { paga = value; }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Construtor da classe Quota.
        /// Inicializa todos os atributos da quota.
        /// </summary>
        public Quota(int idQuota, int idCondominio, int nifMorador, int mes, int ano, double valor, bool paga = false)
        {
            this.idQuota = idQuota;
            this.idCondominio = idCondominio;
            this.nifMorador = nifMorador;
            this.mes = mes;
            this.ano = ano;
            this.valor = valor;
            this.paga = paga;
        }

        #endregion
    }
}
