using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AgendamentoView : ContentPage
	{
        public Veiculo Veiculo { get; private set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        DateTime dataAgendamento = DateTime.Today;
        public DateTime DataAgendamento
        {
            get => dataAgendamento;
            set => dataAgendamento = value;
        }
        public TimeSpan HoraAgendamento { get; set; }

        public AgendamentoView (Veiculo veiculo)
		{
			InitializeComponent ();
            Veiculo = veiculo;
            this.BindingContext = this;
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Agendamento", 
string.Format(
@"Nome: {0}
Telefone: {1}
E-mail: {2}
Data Agendamento: {3}
Hora Agendamento:{4}",
Nome,Telefone,Email,DataAgendamento.ToString("dd/MM/yyyy"),HoraAgendamento), "ok");
        }
    }
}