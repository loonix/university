using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WPF_Philosophers
{
    public class Philosopher
    {
        const string imagepath = @"/Images/";
        string imagename;
        public string ImageName
        {
            get { return imagepath + imagename; }
            set { imagename = value; }
        }

        public int DoB { get; set; }
        public int DoP { get; set; }
              
        public string Nationality { get; set; }
        public string Name { get; set; }
        public string Thesis { get; set; }
        public string Quote { get; set; }
    }
}
