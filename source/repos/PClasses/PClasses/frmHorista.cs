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
    public partial class frmHorista : Form
    {
        public frmHorista()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // criado o objeto Instanciado o objeto
            Horista ObjHorista = new Horista();

            ObjHorista.NomeEmpregado = txtNome.Text;
            ObjHorista.Matricula = Convert.ToInt32(txtMatricula.Text);
            ObjHorista.SalarioHora = Convert.ToDouble(txtSalario.Text);
            ObjHorista.NumeroHora = Convert.ToDouble(txtHora.Text);
            ObjHorista.DataEntradaEmpresa = Convert.ToDateTime(txtData.Text);
            ObjHorista.DiasFalta = Convert.ToInt32(txtFaltas.Text);

            MessageBox.Show("Nome:" + ObjHorista.NomeEmpregado +
            "\n" + "Matricula:" + ObjHorista.Matricula + "\n" +
            "Tempo Trabalho:" + ObjHorista.TempoTrabalho().ToString() 
            + "\n" + "Salário:" + ObjHorista.SalarioBruto().ToString("N2"));

        }

        private void TxtMatricula_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
