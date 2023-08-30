using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PClasses
{
    public partial class frmMensalista : Form
    {
        public frmMensalista()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnInstanciar1_Click(object sender, EventArgs e)
        {
            Mensalista objMensalista = new Mensalista();
            objMensalista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objMensalista.NomeEmpregado = txtNome.Text;
            objMensalista.SalarioMensal = Convert.ToDouble(txtSalario.Text);
            objMensalista.DataEntradaEmpresa = Convert.ToDateTime(txtData.Text);
            if (rbtnSim.Checked)
                objMensalista.HomeOffice = 'S';
            else
                objMensalista.HomeOffice = 'N';

            //get
            MessageBox.Show("Matricula: " + objMensalista.Matricula + "\n" +
                 "Nome: " + objMensalista.NomeEmpregado + "\n" +
                 "Data Entrada: " + objMensalista.DataEntradaEmpresa.ToShortDateString() + "\n" +
                 "Salário Bruto: " + objMensalista.SalarioBruto().ToString("N2") + "\n" +
                 "Tempo Empresa (dias): " + objMensalista.TempoTrabalho() + '\n' + objMensalista.VerificaHome());
            MessageBox.Show(Mensalista.Empresa);
        }



        private void BtnInstanciar2_Click(object sender, EventArgs e)
        {
            Mensalista ObjMensalista = new Mensalista(
                Convert.ToInt32(txtMatricula.Text),
                txtNome.Text, Convert.ToDateTime(txtData.Text),
                Convert.ToDouble(txtSalario.Text));

            MessageBox.Show("Nome: " + ObjMensalista.NomeEmpregado + "\n" +
                 "Matricula: " + ObjMensalista.Matricula + "\n" +
                 "Tempo Trabalho: " + ObjMensalista.TempoTrabalho() + "\n" +
                 "\n" + "Salário Final:" +
                 ObjMensalista.SalarioBruto().ToString("N2"));
                
        }
    }
}
