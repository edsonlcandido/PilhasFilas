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
    public partial class FormPilhasFilas : Form
    {
        PilhaEstatica pilhaEstatica;
        PilhaDinamica pilhaDinamica;
        FilaEstatica filaEstatica;
        public FormPilhasFilas()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pilhaEstatica = new PilhaEstatica();
            pilhaDinamica = new PilhaDinamica();
            filaEstatica = new FilaEstatica();
        }

        private void buttonPushPilhaEstatica_Click(object sender, EventArgs e)
        {
            try
            {
                pilhaEstatica.push(Convert.ToInt32(textBoxInputPilhaEstatica.Text));
                preencheTextBoxDataPilhaEstatica(pilhaEstatica.data);
                textBoxInputPilhaEstatica.ResetText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void buttonPushPilhaDinamica_Click(object sender, EventArgs e)
        {
            try
            {
                pilhaDinamica.push(Convert.ToInt32(textBoxPilhaDinamica.Text));
                preencheTextBoxDataPilhaDinamica(pilhaDinamica.data);
                textBoxPilhaDinamica.ResetText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void preencheTextBoxDataPilhaEstatica(string[] data)
        {
            textBoxDataPilhaEstatica.ResetText();
            for (int i = (data.Length - 1); i > -1; i--)
            {
                if (data[i] != "0")
                {
                    textBoxDataPilhaEstatica.AppendText(data[i] + Environment.NewLine);
                }
            }
        }

        private void preencheTextBoxDataPilhaDinamica(string[] data)
        {
            textBoxDataPilhaDinamica.ResetText();
            for (int i = 0; i < data.Length; i++)
            {
                //if (data[i] != "0")
                //{
                    textBoxDataPilhaDinamica.AppendText(data[i] + Environment.NewLine);
                //}
            }
        }

        private void preencheTextBoxDataFilaEstatica(string[] data)
        {
            textBoxDataFilaEstatica.ResetText();
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] != "0")
                {
                textBoxDataFilaEstatica.AppendText(data[i] + Environment.NewLine);
                }
            }
        }

        private void buttonPopPilhaEstatica_Click(object sender, EventArgs e)
        {
            try
            {
                pilhaEstatica.pop();
                preencheTextBoxDataPilhaEstatica(pilhaDinamica.data);
                textBoxInputPilhaEstatica.ResetText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void buttonPopPilhaDinamica_Click(object sender, EventArgs e)
        {
            try
            {
                pilhaDinamica.pop();
                preencheTextBoxDataPilhaDinamica(pilhaDinamica.data);
                textBoxPilhaDinamica.ResetText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonEnqueueFilaEstatica_Click(object sender, EventArgs e)
        {
            try
            {
                filaEstatica.enQueue(Convert.ToInt32(textBoxFilaEstatica.Text));
                preencheTextBoxDataFilaEstatica(filaEstatica.data);
                textBoxFilaEstatica.ResetText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDequeueFilaEstatica_Click(object sender, EventArgs e)
        {
            try
            {
                filaEstatica.deQueue();
                preencheTextBoxDataFilaEstatica(filaEstatica.data);
                textBoxFilaEstatica.ResetText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
