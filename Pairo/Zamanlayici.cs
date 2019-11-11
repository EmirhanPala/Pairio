using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pairo
{
    public partial class Form1
    {
        byte ButonDegistiri = 0;
        byte OtomatikMesaj = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            System.Timers.Timer ButonTimers = new System.Timers.Timer(5000);
            ButonTimers.Elapsed += new System.Timers.ElapsedEventHandler(ButonTimers_Elapsed);
            ButonTimers.Enabled = true;

            System.Timers.Timer OtoMesaj = new System.Timers.Timer(1000);
            OtoMesaj.Elapsed += new System.Timers.ElapsedEventHandler(OtoMesaj_Elapsed);
            OtoMesaj.Enabled = true;
        }

        private void ButonTimers_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (checkBox3.Checked)
            {
                if (ButonDegistiri == 0)
                {
                    label11.ForeColor = Color.Black;
                    label9.ForeColor = Color.Red;
                    bagla.ButtonShow(true, Convert.ToByte(numericUpDown1.Value), false, LiveForSpeed.InSim.Aegio.Enums.BTN_STYLE.BACK_DARK, Convert.ToByte(numericUpDown2.Value), Convert.ToByte(numericUpDown3.Value), Convert.ToByte(numericUpDown4.Value), Convert.ToByte(numericUpDown5.Value), Convert.ToByte(numericUpDown6.Value), textBox1.Text);
                    ButonDegistiri += 1;
                }
                else if (ButonDegistiri == 1)
                {
                    label9.ForeColor = Color.Black;
                    label10.ForeColor = Color.Red;
                    bagla.ButtonShow(true, Convert.ToByte(numericUpDown1.Value), false, LiveForSpeed.InSim.Aegio.Enums.BTN_STYLE.BACK_DARK, Convert.ToByte(numericUpDown2.Value), Convert.ToByte(numericUpDown3.Value), Convert.ToByte(numericUpDown4.Value), Convert.ToByte(numericUpDown5.Value), Convert.ToByte(numericUpDown6.Value), textBox2.Text);
                    ButonDegistiri += 1;
                }
                else if (ButonDegistiri == 2)
                {
                    label10.ForeColor = Color.Black;
                    label11.ForeColor = Color.Red;
                    bagla.ButtonShow(true, Convert.ToByte(numericUpDown1.Value), false, LiveForSpeed.InSim.Aegio.Enums.BTN_STYLE.BACK_DARK, Convert.ToByte(numericUpDown2.Value), Convert.ToByte(numericUpDown3.Value), Convert.ToByte(numericUpDown4.Value), Convert.ToByte(numericUpDown5.Value), Convert.ToByte(numericUpDown6.Value), textBox3.Text);
                    ButonDegistiri = 0;
                }
                else
                {
                    ButonDegistiri = 0;
                }
            }
            else
            {

            }
        }

        private void OtoMesaj_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (checkBox2.Checked)
            {
                if (OtomatikMesaj == 0)
                {
                    MsgAll(textBox6.Text);
                    OtomatikMesaj += 1;
                }
                else if (OtomatikMesaj == 1)
                {
                    MsgAll(textBox5.Text);
                    OtomatikMesaj += 1;
                }
                else if (OtomatikMesaj == 2)
                {
                    MsgAll(textBox4.Text);
                    OtomatikMesaj = 0;
                }
                else
                {
                    ButonDegistiri = 0;
                }
            }
            else
            {

            }
        }

    }
}
