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

namespace BO
{
    /// <summary>
    /// Representa uma reunião do condomínio.
    /// </summary>
    [Serializable]
    public class Reuniao
    {
        #region Attributes
        int idReuniao;
        int idCondominio;
        DateTime data;
        string listaTemas;
        string local;
        #endregion

        #region Properties
        /// <summary>
        /// Id da reunião.
        /// </summary>
        public int IdReuniao
        {
            get { return idReuniao; }
            set { idReuniao = value; }
        }

        /// <summary>
        /// Id do condomínio.
        /// </summary>
        public int IdCondominio
        {
            get { return idCondominio; }
            set { idCondominio = value; }
        }

        /// <summary>
        /// Data da reunião.
        /// </summary>
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        /// <summary>
        /// Lista de temas a discutir na reunião por ordem de tema.
        /// </summary>
        public string ListaTemas
        {
            get { return listaTemas; }
            set { listaTemas = value; }
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
        public Reuniao(int idReuniao, int idCondominio, DateTime data, string listaTemas, string local)
        {
            this.idReuniao = idReuniao;
            this.idCondominio = idCondominio;
            this.data = data;
            this.listaTemas = listaTemas;
            this.local = local;
        }
        #endregion
    }
}
