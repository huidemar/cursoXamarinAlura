﻿using System;
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
        public AgendamentoView (Veiculo veiculo)
		{
			InitializeComponent ();
            Veiculo = veiculo;
            this.BindingContext = this;
		}
	}
}