using Enumeracao.Enties.Enums;
using System.Collections.Generic;


namespace Enumeracao.Enties
{
    class Trabalho
    {
        public string Name { get; set; }
        public TrabalhoCargo Cargo { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public List<HoraContrato> Contrato { get; private set; } = new List<HoraContrato>();


        public Trabalho()
        {

        }

        public Trabalho(string name, TrabalhoCargo cargo, double salarioBase, Departamento departamento)
        {
            Name = name;
            Cargo = cargo;
            SalarioBase = salarioBase;
            Departamento = departamento;
            Contrato = new List<HoraContrato>();
        }

        public void AddContrato(HoraContrato contrato)
        {
            Contrato.Add(contrato);
        }

        public void RemoveContrato(HoraContrato contrato)
        {
            Contrato.Remove(contrato);
        }

        public double Income (int ano, int mes)
        {
            double soma = SalarioBase;
            foreach (HoraContrato contrato in Contrato)
            {
                if(contrato.Date.Year == ano && contrato.Date.Month == mes)
                {
                    soma += contrato.TotalHora();
                }
            }
            return soma;
        }
    }
}
