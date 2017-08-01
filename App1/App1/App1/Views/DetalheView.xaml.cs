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
	public partial class DetalheView : ContentPage
	{
        private const int FREIO_ABS = 800;
        private const int AR_CONDICIONADO = 1000;
        private const int MP3_PLAYER = 500;

        public Veiculo Veiculo { get; private set; }
        public string TextoFreioAbs => string.Format("Freio Abs R$ {0}",FREIO_ABS);
        public string TextoArCondicionado => string.Format("Ar Condicionado R${0}", AR_CONDICIONADO);
        public string TextoMp3Player => string.Format("Mp3 Player R$ {0}", MP3_PLAYER);

        bool temFreioAbs;
        public bool TemFreioAbs
        {
            get
            {
                return temFreioAbs;
            }
            set 
            {
                temFreioAbs = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
                /*if (temFreioAbs)
                {
                    DisplayAlert("Freio Abs", "Ligado", "Ok");
                }
                else
                {
                    DisplayAlert("Freio Abs", "Desligado", "Ok");
                }*/
            }
        }

        bool temArCondicionado;
        public bool TemArCondicionado
        { 
            get => temArCondicionado;
            set
            {
                temArCondicionado = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
                /*if (temArCondicionado)
                {
                    DisplayAlert("Ar Condicionado", "Ligado", "Ok");
                }
                else
                {
                    DisplayAlert("Ar Condicionado", "Desligado", "Ok");
                }*/

            }
        }

        bool temMp3Player;
        public bool TemMp3Player
        {
            get =>temMp3Player;
            set
            {
                temMp3Player = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
                /**
                if (temMp3Player)
                {
                    DisplayAlert("Mp3 Player", "Ligado", "ok");
                }
                else
                {
                    DisplayAlert("Mp3 Player", "Desligado", "ok");
                }*/
            }
        }

        public string ValorTotal
        {
            get
            {
                return string.Format("Valor Total: R$ {0}", Veiculo.Preco + 
                    (TemFreioAbs ? FREIO_ABS : 0)+
                    (TemArCondicionado ? AR_CONDICIONADO : 0) +
                    (TemMp3Player ? MP3_PLAYER : 0));
            }
        }


        public DetalheView (Veiculo veiculo)
		{
			InitializeComponent ();            
            Veiculo = veiculo;
            this.BindingContext = this;
        }

        private void buttonProximo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AgendamentoView(Veiculo));
        }
    }
}