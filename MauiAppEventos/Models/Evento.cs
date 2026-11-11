namespace MauiAppEventos.Models
{
    public class Evento
    {
        public string Nome { get; set; } = string.Empty; // CHAT ME AJUDOU COM O = string.Empty; PARA EVITAR ERRO DE NULL
        public string Local { get; set; } = string.Empty; // CHAT ME AJUDOU COM O = string.Empty; PARA EVITAR ERRO DE NULL
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public int QntParticipantes { get; set; }
        public double CustoPorParticipante { get; set; }

        public TimeSpan Duracao
        {
            get => DataTermino.Subtract(DataInicio);
        }

        public double CustoTotal
        {
            get => QntParticipantes * CustoPorParticipante;
        }
    }
}