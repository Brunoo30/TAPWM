﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClasses
{
    class Mensalista : Empregado
    {
        public double SalarioMensal { get; set; }

        public static string Empresa = "Irmãos Silva Ltda.";
        public override double SalarioBruto()
        {
            return SalarioMensal;
        }
      
        public Mensalista()
        {

        }

        public Mensalista(int matx, string nomex, DateTime datax, double salx)
        {
            this.NomeEmpregado = nomex;
            this.Matricula = matx;
            this.DataEntradaEmpresa = datax;
            this.SalarioMensal = salx;
        }
    }
}
