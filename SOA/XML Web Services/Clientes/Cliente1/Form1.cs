/**
 * Clientes de XML Web Services
 * lufer & Oscar
 */
using System;
using System.Collections;
using System.Windows.Forms;

namespace Cliente1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Calcula uma soma
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            WsExt.SomaSoapClient ws = new WsExt.SomaSoapClient(); //proxy
            MessageBox.Show(ws.Somar(2, 3).ToString());

            MessageBox.Show("Multiplicar:", ws.Multiplica(2, 3).ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WsExt.SomaSoapClient ws = new WsExt.SomaSoapClient(); //proxy
            WsExt.SomaProd aux = new WsExt.SomaProd();
            aux = ws.SomaEMultiplica(int.Parse(textBox1.Text), int.Parse(textBox2.Text));

            //MessageBox.Show("Soma= " + aux.S + " Mult =" + aux.P);
            textBox3.Text = "Soma= " + aux.S + " Mult =" + aux.P;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WsExt2.CalcPlusSoapClient ws = new WsExt2.CalcPlusSoapClient();
            WsExt2.ArrayOfString aux = ws.Currencies();
            ArrayList myArrayList = new ArrayList();
            myArrayList.AddRange(aux);
            comboBox1.DataSource = myArrayList;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
