using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAtleta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

            Pessoa obj = new Pessoa();
        private void btn_calc_Click(object sender, EventArgs e)
        {
            try
            {
                obj.Nome = txt_nome.Text;
                obj.Idade = int.Parse(txt_idade.Text);
                obj.Peso = double.Parse(txt_peso.Text);
                obj.Altura = double.Parse(txt_altura.Text);
                MessageBox.Show(obj.Calcular().ToString());
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Erro. \n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
