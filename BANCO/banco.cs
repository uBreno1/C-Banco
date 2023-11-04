using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANCO
{
    public partial class banco : Form
    {
        Cliente cliente;

        public banco()
        {
            InitializeComponent();
            this.cliente = new Cliente();

            

        }

        private void banco_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            try  (valor > 0);

            {

                double valor = Convert.ToDouble(textBoxDeposito.Text);

                cliente.Creditar(valor);

                textBoxDeposito.Clear();

                MessageBox.Show("Operação concluida");

                
            }
            catch
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonSacar_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(textBox1.Text);
            if (valor < cliente.saldo)
            {

                cliente.Debitar(valor);

                labelSaldoValor.Text = cliente.saldo.ToString();

                MessageBox.Show("Operação concluida");

                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, digite um numero valido!");
            }
            //else if
            //{
            //    MessageBox.Show("Por favor, digite um numero valido!");
           // }
        }
    }
}
