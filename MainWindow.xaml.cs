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
using System.Data.SqlClient;
using System.Windows.Forms;
using MessageBox = System.Windows.MessageBox;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            

            
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {

            if (r1.IsChecked==true) {
                Microsoft.Win32.OpenFileDialog openFileDlg = new Microsoft.Win32.OpenFileDialog();
                Nullable<bool> result =  openFileDlg.ShowDialog();
                if (result == true)
                {
                    t2.Text = openFileDlg.FileName;
                 
                }
            }
            else if (r2.IsChecked == true) {
                FolderBrowserDialog folders = new FolderBrowserDialog();
                
                DialogResult result = folders.ShowDialog();
                if (result == System.Windows.Forms.DialogResult.OK) {
                    t2.Text = folders.SelectedPath;
                }
            }
            else {
                MessageBox.Show("Check At Least One Button");
            }
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            if (r1.IsChecked == true)
            {
                Microsoft.Win32.OpenFileDialog openFileDlg = new Microsoft.Win32.OpenFileDialog();
                Nullable<bool> result = openFileDlg.ShowDialog();
                if (result == true)
                {
                    t3.Text = openFileDlg.FileName;

                }
            }
            else if (r2.IsChecked == true)
            {
                FolderBrowserDialog folders = new FolderBrowserDialog();
               
                DialogResult result = folders.ShowDialog();
                if (result == System.Windows.Forms.DialogResult.OK) {
                    t3.Text = folders.SelectedPath;
                }
            }
            else
            {
                MessageBox.Show("Check At Least One Button");
            }
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            string appname = t1.Text;
            string platform = combobox1.Text;
            string applicationtype = combobox2.Text;
            string codelocation = t2.Text;
            string ccodelocation = t3.Text;
            if (appname == "" || platform == ""|| applicationtype == "" || codelocation == "" || ccodelocation == "")
            {
                MessageBox.Show("!!!!All Fields Are Required!!!!");
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-9B7N4PCQ;Initial Catalog=VsCodeForm;Integrated Security=True");
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string q = "insert into Table1(ApplicationName,platform,ApplicationType,SourceLocation,Compiledlocation)values('" + appname + "','" + platform + "','" + applicationtype + "','" + codelocation + "','" + ccodelocation + "');";
                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Added Successfullly");
                    t1.Text = "";
                    combobox1.Text = "";
                    combobox2.Text = "";
                    t2.Text = "";
                    t3.Text = "";

                }
                con.Close();
            }
     
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            second wmd = new second();
            wmd.Show();
        }
    }
}
    

    internal class FileNameTextBox
    {
        public static string Text { get; internal set; }
    }


