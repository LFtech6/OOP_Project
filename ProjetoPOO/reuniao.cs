#region author info
// ============================================================
// Author: Rodrigo Lopes Ferreira
// Date:    {13/11/2025}
// Project: {Gestão de Condomínios}
// File:    {reuniao.cs}
//
// Description:
//   Representa uma reunião de condomínio com data,
//   ordem de trabalhos e local.
//
// ============================================================
#endregion

using System;

namespace EmpGestCondominios
{
    /// <summary>
    /// Representa uma reunião do condomínio.
    /// </summary>
    class Reuniao
    {
        #region Attributes
        string data;
        string ordemTrabalhos;
        string local;
        #endregion

        #region Properties
        /// <summary>
        /// Data da reunião.
        /// </summary>
        public string Data
        {
            get { return data; }
            set { data = value; }
        }

        /// <summary>
        /// Lista de temas a discutir na reunião.
        /// </summary>
        public string OrdemTrabalhos
        {
            get { return ordemTrabalhos; }
            set { ordemTrabalhos = value; }
        }

        /// <summary>
        /// Local onde a reunião decorre.
        /// </summary>
        public string Local
        {
            get { return local; }
            set { local = value; }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Método placeholder para agendar a reunião.
        /// </summary>
        public int AgendarReuniao()
        {
            return 0;
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Construtor da reunião.
        /// </summary>
        public Reuniao(string data, string ordemTrabalhos, string local)
        {
            this.data = data;
            this.ordemTrabalhos = ordemTrabalhos;
            this.local = local;
        }
        #endregion
    }
}
