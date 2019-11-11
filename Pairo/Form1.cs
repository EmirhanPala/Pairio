using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveForSpeed.InSim.Aegio;

namespace Pairo
{
    public partial class Form1 : Form
    {
        Connection bagla = new Connection();
        public Form1()
        {
            InitializeComponent();
        }

        private void InSimConnection()
        {
            bagla.ConnectionOpen(IpNumarasi.Text, Convert.ToInt32(InsimPortu.Text), AdminSifresi.Text, InsimIsmi.Text, Convert.ToInt32(Guncelleme.Text), true);
        }

        private void Btn_Bagla_Click(object sender, EventArgs e)
        {
            InSimConnection();
            bagla.SendToConnections(BaglantiMesaji.Text);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Text = "<";
                Form1.ActiveForm.Width = 600;
            }
            else
            {
                checkBox1.Text = ">";
                Form1.ActiveForm.Width = 300;
            }
        }


        void MsgAll(string mesaj)
        {
            bagla.SendToConnections(mesaj);
        }
    }
}
