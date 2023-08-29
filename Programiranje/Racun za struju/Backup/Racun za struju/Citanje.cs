using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    class Citanje
    {
        public string Citaj(StreamReader sr)
        {
            sr.ReadLine();
            sr.ReadLine();
            sr.ReadLine();
            return sr.ReadLine();
        }
    }
}
