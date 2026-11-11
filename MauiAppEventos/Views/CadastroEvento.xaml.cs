using MauiAppEventos.Models;

namespace MauiAppEventos.Views;

public partial class CadastroEvento : ContentPage
{
    public CadastroEvento()
    {
        InitializeComponent();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(txt_nome.Text) ||
                string.IsNullOrWhiteSpace(txt_local.Text))
            {
                throw new Exception("Preencha o nome e o local do evento.");
            }

            Evento ev = new Evento
            {
                Nome = txt_nome.Text,
                Local = txt_local.Text,
                DataInicio = dtpck_inicio.Date ?? DateTime.Today,
                DataTermino = dtpck_termino.Date ?? DateTime.Today,
                // DataInicio = dtpck_inicio.Date, 1 PRIMEIRA TENTATIVA ( IA ME AJUDOU COM AS LINHAS 26 E 27 )
                //  DataTermino = dtpck_termino.Date,
                QntParticipantes = Convert.ToInt32(txt_participantes.Text),
                CustoPorParticipante = Convert.ToDouble(txt_custo.Text),
            };

            if (ev.DataTermino < ev.DataInicio)
            {
                throw new Exception("A data de término não pode ser anterior à data de início.");
            }

            await Navigation.PushAsync(new EventoCadastrado()
            {
                BindingContext = ev
            });
        }
        catch (Exception ex)
        {
            await DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}