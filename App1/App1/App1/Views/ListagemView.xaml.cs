﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1.Views
{
    public class Veiculo
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string PrecoFormatado => string.Format("R$ {0}", Preco);

    }
    public partial class ListagemView : ContentPage
	{
        public List<Veiculo> Veiculos { get; set; }

        public ListagemView()
		{
			InitializeComponent();
            this.Veiculos = new List<Veiculo>
            {
                new Veiculo {Nome="Azera v6", Preco=60000m },
                new Veiculo {Nome="Fiesta 2.0", Preco=50000m },
                new Veiculo {Nome="HB20 S", Preco=40000m }

            };
            this.BindingContext = this;
        }
        private void listViewVeiculos_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var veiculo = (Veiculo)e.Item;
            Navigation.PushAsync(new DetalheView(veiculo));
        }
    }
}
