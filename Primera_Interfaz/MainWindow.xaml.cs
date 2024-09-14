using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Primera_Interfaz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            //Grid miGrid = new Grid();
            //this.Content = miGrid;
            
            //Button miButton = new Button();
            //miButton.Width = 150;
            //miButton.Height = 50;
            //miButton.Background = Brushes.Blue;

            //WrapPanel miWrap = new WrapPanel();

            //TextBlock text1 = new TextBlock();
            //text1.Background = Brushes.Red;
            //text1.Foreground= Brushes.Yellow;
            //text1.Text = "Click";
            //miWrap.Children.Add(text1);
            
            //TextBlock text2 = new TextBlock();
            //text2.Text = "Enviar!";
            //miWrap.Children.Add(text2);
            
            //TextBlock text3 = new TextBlock();
            //text3.Text = "Daleeeee";
            //miWrap.Children.Add(text3);
            
            //miButton.Content = miWrap;
            
            //miGrid.Children.Add(miButton);
            
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    /*MessageBox.Show("Le has dado al Boton!");*/
        //    Console.WriteLine("Le has dado al Boton 2");
        //}

        /*private void Panel_OnClick(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Le has dado al Panel/Stack");
        }*/

        //private void Panel_OnPreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        //{
        //    Console.WriteLine("Le has dado al Panel/Stack");
        //}

        public int MiProperty
        {
            get { return (int)GetValue(MiDepencyProperty); }

            set { SetValue(MiDepencyProperty, value); }

        }

        public static readonly DependencyProperty MiDepencyProperty =
            DependencyProperty.Register("MiProperty", typeof(int), typeof(MainWindow), new PropertyMetadata(0));
}