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
using CSharpOv7.Classes;

namespace CSharpOv7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //Ser på oppgave C som unødvendig (i.f.t. brukervennligheten til UI da det er bare å calle metoden Reverse en gang til.
        public MainWindow()
        {
            InitializeComponent();
            Title = "C# Øving 7 - Joachim F. Stamnes";
            txtResultat.IsReadOnly = true;
        }

        private void btnSnuText_Click(object sender, RoutedEventArgs e)
        {
            txtResultat.Text = Input.Baklengs(txtInput.Text);
        }
        
        private void btnToLower_Click(object sender, RoutedEventArgs e)
        {
            txtResultat.Text = txtInput.Text.ToLower();
        }

        private void btnLenght_Click(object sender, RoutedEventArgs e)
        {
            txtResultat.Text = "Antall innskrevne tegn: " + txtInput.GetLineLength(0);
        }

        private void btnOmvendt_Click(object sender, RoutedEventArgs e)
        {
            txtResultat.Text = Input.Omvendt(txtInput.Text);
        }

        private void btnStorBokstav_Click(object sender, RoutedEventArgs e)
        {
            txtResultat.Text = Input.StorBokstav(txtInput.Text);
        }

        private void btnEndreBGC_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.ColorDialog dg = new System.Windows.Forms.ColorDialog();

            if (dg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Color color = Color.FromArgb(dg.Color.A, dg.Color.R, dg.Color.G, dg.Color.B);

                Brush brush = new SolidColorBrush(color);

                Background = brush;
            }
        }

        private void btnKursiv_Click(object sender, RoutedEventArgs e)
        {
            if (!(txtResultat.FontStyle == FontStyles.Italic))
            {
                btnKursiv.Background = new SolidColorBrush(Color.FromRgb(0, 255, 0));
                txtResultat.FontStyle = FontStyles.Italic;
            }
            else
            {
                btnKursiv.Background = new SolidColorBrush(Color.FromRgb(221, 221, 221));
                txtResultat.FontStyle = FontStyles.Normal;
            }
        }

        private void btnFet_Click(object sender, RoutedEventArgs e)
        {
            if (!(txtResultat.FontWeight == FontWeights.Bold))
            {
                btnFet.Background = new SolidColorBrush(Color.FromRgb(0, 255, 0));
                txtResultat.FontWeight = FontWeights.Bold;
            }
            else
            {
                btnFet.Background = new SolidColorBrush(Color.FromRgb(221, 221, 221));
                txtResultat.FontWeight = FontWeights.Normal;
            }
        }
    }

}
