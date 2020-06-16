using System;


namespace Enumeracao.Enties
{
    class HoraContrato
    {
        public DateTime Date { get; set; }
        public double ValorPorHora { get; set; }
        public int Horas { get; set; }

        public HoraContrato()
        {

        }

        public HoraContrato(DateTime date, double valorPorHora, int horas)
        {
            Date = date;
            ValorPorHora = valorPorHora;
            Horas = horas;
        }

        public double TotalHora()
        {
            return Horas * ValorPorHora;
        }
    }

}
