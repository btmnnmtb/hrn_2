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

namespace hrn_2
{

    public partial class MainWindow : Window
    {
        //table_111TableAdapter table_111TableAdapter = new table_111TableAdapter();
        private pr1poCCCEntities table_22 = new pr1poCCCEntities();
        public MainWindow()
        {
            InitializeComponent();



            //table.ItemsSource = table_111TableAdapter.GetData(); 

            table_2.ItemsSource = table_22.table_222.ToList();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //изменить 
            table_222 ne = new table_222();




            ne.car_god_proizvod = Convert.ToInt32(tex.Text);
            table_22.table_222.Add(ne);
            table_22.SaveChanges();
            table_2.ItemsSource = table_22.table_222.ToList();


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Добавить
            if (table_2.SelectedItem != null)
            {

                var selected = table_2.SelectedItem as table_222;
                tex.Text = Convert.ToString(selected.car_god_proizvod);
                table_22.SaveChanges();
                table_2.ItemsSource = table_22.table_222.ToList();

            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            // удалить
            if (table_2.SelectedItems != null)
            {
                table_22.table_222.Remove(table_2.SelectedItem as table_222);
                table_22.SaveChanges();
                table_2.ItemsSource = table_22.table_222.ToList();
            }
        }

        private void table_2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Проверка на выборку обекта
            if (table_2.SelectedItem != null)
            {

                var selected = table_2.SelectedItem as table_222;
                tex.Text = Convert.ToString(selected.car_god_proizvod);

            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            secondokno sec = new secondokno();
            sec.Show();
            Close();


        }
    }
}
