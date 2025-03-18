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

namespace WpfOefening_Bioscoop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double normale = 9.10;
        double korting = 8.10;
        double student = 6.90;
        int normaalAantaal;
        int kortingAantaal;
        int studentAantaal;

        public MainWindow()
        {
            InitializeComponent();
           
        }
       
        private void BtnBerekenen_Click(object sender, RoutedEventArgs e)
        {
           

            string InputNormaalAantal = TxtNormaal.Text;
            int normaalAantal = Convert.ToInt32(InputNormaalAantal);
            string InputKortingAantal = TxtKorting.Text;
            int kortingAantal = Convert.ToInt32(InputKortingAantal);
            string InputStudentAantal = TxtStudent.Text;
            int studentAantal = Convert.ToInt32(InputStudentAantal);

            double prijsNormaal = normale * normaalAantal;
            double prijsKorting = korting * kortingAantal;
            double prijsStudent = student * studentAantal;
           

            double prijsTeBetalen =
                normaalAantal * normale +
                kortingAantal * korting +
                studentAantal * student;

            //TxtPrijsTeBetalen.Text = Convert.ToString(prijsTeBetalen);
            TxtPrijsTeBetalen.Text = prijsTeBetalen.ToString();


        }

        private void BtnWissen_Click(object sender, RoutedEventArgs e)
        {
            TxtNormaal.Text = "";
            TxtKorting.Text = "";
            TxtStudent.Clear();
            TxtPrijsTeBetalen.Clear();
           // TxtKorting.Background = 

        }

        private void BtnAfsluiten_Click(object sender, RoutedEventArgs e)
        {
            Close();
            //this.Close();
        }

       /* private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) ;
            //TODO berekeningclick

            string InputNormaalAantal = TxtNormaal.Text;
            normaalAantal = Convert.ToInt32(TxtNormaal.Text);
            string InputKortingAantal = TxtKorting.Text;
            kortingAantal = Convert.ToInt32(TxtKorting.Text);
            string InputStudentAantal = TxtStudent.Text;
            studentAantal = Convert.ToInt32(TxtStudent.Text);

            double prijsNormaal = normale * normaalAantal;
            double prijsKorting = korting * kortingAantal;
            double prijsStudent = student * studentAantal;


            double prijsTeBetalen = prijsNormaal + prijsKorting + prijsStudent;

            TxtPrijsTeBetalen.Text = Convert.ToString(prijsTeBetalen);
        }
       */
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
                TxtNormaal.Text = "";
                TxtKorting.Text = "";
                TxtPrijsTeBetalen.Text = "";
                TxtStudent.Text = "";
            
        }

        private void BtnBerekenen_DragEnter(object sender, DragEventArgs e)
        {
            BtnBerekenen_Click(sender, e);
            //string InputNormaalAantal = TxtNormaal.Text;
            //int normaalAantal = Convert.ToInt32(InputNormaalAantal);
            //string InputKortingAantal = TxtKorting.Text;
            //int kortingAantal = Convert.ToInt32(InputKortingAantal);
            //string InputStudentAantal = TxtStudent.Text;
            //int studentAantal = Convert.ToInt32(InputStudentAantal);

            //double prijsNormaal = normale * normaalAantal;
            //double prijsKorting = korting * kortingAantal;
            //double prijsStudent = student * studentAantal;


            //double prijsTeBetalen =
            //    normaalAantal * normale +
            //    kortingAantal * korting +
            //    studentAantal * student;

            ////TxtPrijsTeBetalen.Text = Convert.ToString(prijsTeBetalen);
            //TxtPrijsTeBetalen.Text = prijsTeBetalen.ToString();


        }
    }
}
