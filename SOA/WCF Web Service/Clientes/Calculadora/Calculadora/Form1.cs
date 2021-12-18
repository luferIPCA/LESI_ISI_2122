using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        CalcWCF.CalcClient ws = new CalcWCF.CalcClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            MessageBox.Show(ws.Sum(2,3).ToString());

            //CalcWCF.Res aux = new CalcWCF.Res();
            //aux = ws.SumClock(2, 3);
            //MessageBox.Show("Res:" + aux.Sum.ToString() + " - " + aux.Clock.ToString(), "Sincrono: ");
         }

 

        private void button1_Click(object sender, EventArgs e)
        {
            ws.SumClockCompleted += Ws_SumClockCompleted;
            ws.SumClockAsync(2, 3);
            MessageBox.Show("Depois");
        }

        private void Ws_SumClockCompleted(object sender, CalcWCF.SumClockCompletedEventArgs e)
        {
            System.Threading.Thread.Sleep(2000);
            MessageBox.Show("Res:" + e.Result.Sum.ToString() + " - " + e.Result.Clock.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ws.Close();
            this.Close();
        }
    }
}
