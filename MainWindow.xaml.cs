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
using practBibl;

namespace practBibl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        string file;
        string stroka;
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            stroka = TextVboxe.Text;
            file = FileN.Text;
            TextVboxe.Text = SerializeAndDes.Serialize("", TextVboxe.Text);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            stroka = TextVboxe.Text;
            file = FileN.Text;
            TextVboxe.Text = SerializeAndDes.Deserialize<string>(TextVboxe.Text);

        }
    }
}
