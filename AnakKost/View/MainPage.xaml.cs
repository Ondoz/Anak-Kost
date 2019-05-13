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
using System.Windows.Shapes;

namespace AnakKost.View
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Window
    {
        private Controller.MainPageController controll;

        public void TampilData()
        {
            controll.pengguna();
        }

        bool hasil;
        public MainPage()
        {
            InitializeComponent();
            controll = new Controller.MainPageController(this);
            TampilData();
        }
      

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = ListViewMenu.SelectedIndex;
            MoveCursorMenu(index);

            switch (index)
            {
                case 0:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new Home());
                    break;

                case 1:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new Grafic());
                    break;
                case 2:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new CatatanAndJadwal());
                    break;
                case 3:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new Pembuat());
                    break;


                default:
              break;
            }
        }
        private void MoveCursorMenu(int index)
        {
            TranstioningContentSlide.OnApplyTemplate();
            GridCursor.Margin = new Thickness(0, (118 + (50 * index)), 0, 0);
        }

        private void MenuOpen_Click(object sender, RoutedEventArgs e)
        {
            MenuOpen.Visibility = Visibility.Collapsed;
            MenuClose.Visibility = Visibility.Visible;
        }

        private void MenuClose_Click(object sender, RoutedEventArgs e)
        {
            MenuOpen.Visibility = Visibility.Visible;
            MenuClose.Visibility = Visibility.Collapsed;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void btn_Pengaturan_Click(object sender, RoutedEventArgs e)
        {
            if (controll.Pengenaldata() == true)
            {
                hasil = controll.UpdateDataAdmin();
                if (hasil == true)
                {
                    MessageBox.Show("Berhasil di Tambahkan");
                }
                else
                {
                    MessageBox.Show("gagal di isi");
                }
                
            }
            else
            {
                MessageBox.Show("Maaf anda Salah Dalam Memasukan Password Lama");

            }
            TampilData();
        }

        private void btnsettingview_Click(object sender, RoutedEventArgs e)
        {
            txt_Passlama.Password = "";
            txt_passbaru.Text = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var view = new Login();
            view.Show();
            this.Close();


        }
    }
   
}
