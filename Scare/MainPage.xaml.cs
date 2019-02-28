using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Plugin.SimpleAudioPlayer;

namespace Scare
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        int i = 0;

        void Susto(object sender, EventArgs e)
        {
            var player = CrossSimpleAudioPlayer.Current;
            player.Load("guitos_de_horror.mp3");
            i++;
            texto.Text = "Você Clicou " + i + " vezes!";


            if (i == 5)
            {
                texto.Text = "";
                player.Play();
                Imagem.Source = "https://i0.wp.com/arquivoufo.com.br/wp-content/uploads/2011/11/o-exorcista.jpg";
                i = 0;
            }
        }
    }
}
