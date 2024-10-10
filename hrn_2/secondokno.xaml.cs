using hrn_2.pr1poCCCDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace hrn_2
{
    /// <summary>
    /// Логика взаимодействия для secondokno.xaml
    /// </summary>
    public partial class secondokno : Window
    {
        table_111TableAdapter table_1 = new table_111TableAdapter();

        public secondokno()
        {
            InitializeComponent();
            table.ItemsSource = table_1.GetData();
           

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // добавть 
            table_1.InsertQuery(tex.Text , tex.Text);
            table.ItemsSource = table_1.GetData();


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //изменить 
            object id = (table.SelectedItem as DataRowView).Row[0];
            table_1.UpdateQuery(tex.Text, texx.Text, Convert.ToInt32(id));
            
            table.ItemsSource = table_1.GetData();




        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            // удалить 
            object id = (table.SelectedItem as DataRowView).Row[0];
            table_1.DeleteQuery(Convert.ToInt32(id));
            table.ItemsSource = table_1.GetData();

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            Close();


        }
    }
}
    