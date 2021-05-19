using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CamadaNegocio
{
    public class Download
    {
        #region Propriedades

        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private string appName;

        public string AppName
        {
            get { return appName; }
            set { appName = value; }
        }

        private DateTime timestamp;
        public DateTime Timestamp
        {
            get { return timestamp; }
            set { timestamp = value; }
        }

        private string country;
        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        private string gender;
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        #endregion

        #region Metodos

        public static Download ObterDownloads(string id)
        {
            Download download = null;

            string appName = string.Empty;
            DateTime timestamp = DateTime.Today;
            string country = string.Empty;
            string gender = string.Empty;

            bool ok = CamadaDados.Download.Obter(id, ref appName, ref timestamp, ref country, ref gender);
            if (ok)
            {
                download = new Download();
                download.Id = id;
                download.AppName = appName;
                download.Timestamp = timestamp;
                download.Country = country;
                download.Gender = gender;
            }

            return download;
        }

        public static DownloadCollection ObterListaDownloads()
        {
            DataTable dataTable = CamadaDados.Download.ObterLista();

            DownloadCollection downloads = new DownloadCollection(dataTable);

            return downloads;
        }

        #endregion

    }

    public class DownloadCollection : List<Download>
    {
        public DownloadCollection(DataTable dataTable)
        {
            if (dataTable != null)
            {
                foreach (DataRow dataRow in dataTable.AsEnumerable())
                {
                    Download download = new Download();

                    download.Id = dataRow.Field<string>("id");
                    download.AppName = dataRow.Field<string>("appName");
                    download.Timestamp = dataRow.Field<DateTime>("timestamp");
                    download.Country = dataRow.Field<string>("country");
                    download.Gender = dataRow.Field<string>("gender");

                    this.Add(download);
                }
            }
        }

    }
}
