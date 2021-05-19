using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaNegocio
{
    public class MontlyData
    {
        private List<DownloadCollection> jan;
        public List<DownloadCollection> Jan
        {
            get { return jan; }
            set { jan = value; }
        }

        private List<DownloadCollection> feb;
        public List<DownloadCollection> Feb
        {
            get { return feb; }
            set { feb = value; }
        }

        private List<DownloadCollection> mar;
        public List<DownloadCollection> Mar
        {
            get { return mar; }
            set { mar = value; }
        }

        private List<DownloadCollection> apr;
        public List<DownloadCollection> Apr
        {
            get { return apr; }
            set { apr = value; }
        }

        private List<DownloadCollection> may;
        public List<DownloadCollection> May
        {
            get { return may; }
            set { may = value; }
        }

        private List<DownloadCollection> jun;
        public List<DownloadCollection> Jun
        {
            get { return jun; }
            set { jun = value; }
        }

        private List<DownloadCollection> jul;
        public List<DownloadCollection> Jul
        {
            get { return jul; }
            set { jul = value; }
        }

        private List<DownloadCollection> aug;
        public List<DownloadCollection> Aug
        {
            get { return aug; }
            set { aug = value; }
        }

        private List<DownloadCollection> sep;
        public List<DownloadCollection> Sep
        {
            get { return sep; }
            set { sep = value; }
        }

        private List<DownloadCollection> oct;
        public List<DownloadCollection> Oct
        {
            get { return oct; }
            set { oct = value; }
        }

        private List<DownloadCollection> nov;
        public List<DownloadCollection> Nov
        {
            get { return nov; }
            set { nov = value; }
        }

        private List<DownloadCollection> dec;
        public List<DownloadCollection> Dec
        {
            get { return dec; }
            set { dec = value; }
        }

    }
}
