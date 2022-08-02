using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PilhasFilas
{
    public partial class Form1 : Form
    {
        PilhaEstatica pilhaEstatica;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pilhaEstatica = new PilhaEstatica();

        }

        private void buttonPushPilhaEstatica_Click(object sender, EventArgs e)
        {
            try
            {
                pilhaEstatica.push(Convert.ToInt32(textBoxInputPilhaEstatica.Text));
                preencheTextBoxDataPilhaDinamica(pilhaEstatica.data);
                textBoxInputPilhaEstatica.ResetText();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void preencheTextBoxDataPilhaDinamica(string[] data)
        {
            textBoxDataPilhaDinamica.ResetText();
            for (int i = (data.Length - 1); i > -1; i--)
            {
                if (data[i] != "0")
                {
                    textBoxDataPilhaDinamica.AppendText(data[i] + Environment.NewLine);
                }
            }
        }

        private void buttonPopPilhaEstatica_Click(object sender, EventArgs e)
        {
            try
            {
                pilhaEstatica.pop();
                preencheTextBoxDataPilhaDinamica(pilhaEstatica.data);
                textBoxInputPilhaEstatica.ResetText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
