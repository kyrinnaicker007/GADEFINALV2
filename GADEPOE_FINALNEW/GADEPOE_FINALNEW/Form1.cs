using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GADEPOE_FINALNEW
{

    public partial class Form1 : Form
    {
        int i = 0;

        GameEngine eng = new GameEngine();
        public Form1()
        {
            InitializeComponent();
        }

        private void tmrCounter_Tick(object sender, EventArgs e)
        {
            cmbUnitsDisplay.Items.Clear();
            for(int a =0; a< eng.map.arrUnits.Length;a++)
            {
                if (eng.map.arrUnits[a] != null)
                    cmbUnitsDisplay.Items.Add(eng.map.arrUnits[a].ToString());
            }

            eng.BeginGame();
            i++;
            lblTimerDisplay.Text = i.ToString() + ".";

            MapRefresh();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            i = 0;
            eng.map.Battlefield();
            eng.map.FillMap();
            tmrCounter.Enabled = true;
            tmrCounter.Start();
        }

        public void MapRefresh()
        {
            lblMapDisplay.Text = " ";
            for(int x =0; x< 20; x++)
            {
                for(int y =0; y<20; y++)
                {
                    lblMapDisplay.Text += eng.map.mapArray[x, y];
                }
                lblMapDisplay.Text += "\n";
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            tmrCounter.Enabled = false;
            tmrCounter.Stop();
        }

        private void cmbUnitsDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
