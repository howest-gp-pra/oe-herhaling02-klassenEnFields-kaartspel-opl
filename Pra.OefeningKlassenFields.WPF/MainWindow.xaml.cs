using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Pra.OefeningKlassenFields.CORE;

namespace Pra.OefeningKlassenFields.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rnd;

        public MainWindow()
        {
            InitializeComponent();
            rnd = new Random();
        }

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            Kaart mijnKaart = MaakKaart();
            Kaart computerKaart = MaakKaart();

            lblMijnKaartKleur.Content = mijnKaart.kleur.ToString();
            lblMijnKaartSoort.Content = mijnKaart.soort.ToString();
            lblMijnKaartBonus.Content = mijnKaart.bonus.ToString();
            lblMijnKaartWaarde.Content = mijnKaart.waarde.ToString();
            int mijnScore = mijnKaart.waarde + mijnKaart.bonus;
            lblMijnKaartScore.Content = mijnScore.ToString();

            lblComputerKaartKleur.Content = computerKaart.kleur.ToString();
            lblComputerKaartSoort.Content = computerKaart.soort.ToString();
            lblComputerKaartBonus.Content = computerKaart.bonus.ToString();
            lblComputerKaartWaarde.Content = computerKaart.waarde.ToString();
            int computerScore = computerKaart.waarde + computerKaart.bonus;
            lblComputerKaartScore.Content = computerScore.ToString();

            if (mijnScore > computerScore)
                lblResultaat.Content = "Je wint";
            else if (mijnScore < computerScore)
                lblResultaat.Content = "Je verliest";
            else
                lblResultaat.Content = "Onbeslist";
        }

        private Kaart MaakKaart()
        {
            int soort = rnd.Next(1, 5);
            // 1 = schoppen
            // 2 = klavers
            // 3 = harten
            // 4 = ruiten
            KaartSoort kaartsoort = KaartSoort.ruiten;
            if (soort == 1) kaartsoort = KaartSoort.schoppen;
            if (soort == 2) kaartsoort = KaartSoort.klavers;
            if (soort == 3) kaartsoort = KaartSoort.harten;
            int waarde = rnd.Next(1, 14);
            return new Kaart(kaartsoort, waarde);

        }
    }
}
