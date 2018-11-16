using D2KRMG;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Data.tilesets.
            TileLocation a = new TileLocation("1102");
            TileLocation b = new TileLocation("1202");
            TileLocation c = new TileLocation("2502");
            TileLocation d = new TileLocation("2602");

            label1.Text = a.Location + " " + b.Location + " " + c.Location + " " + d.Location;

            Map map = new Map(128, 128);
            map.Save();
        }
    }
}
