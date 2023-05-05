using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfAppPP5.tabDataSetTableAdapters;

namespace WpfAppPP5
{
    internal class Modele
    {
        public int Care_PetID { get; set; }
        public string TYPУ_CARE { get; set; }
        public int COST { get; set; }
    }
    public partial class oplata : Window
    {
        ТоварTableAdapter tov = new ТоварTableAdapter();
        List<Modele> list = new List<Modele>();
        public int cost = 0;
        public string clos;
        public int namber = 0;
        int ChekNamber = 0;


        public oplata()
        {
            InitializeComponent();
            GridK.ItemsSource = tov.GetData();
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            clos = "Закрыть";
            DialogResult = true;
        }

        private void pluse_Click(object sender, RoutedEventArgs e)
        {

            DataRowView row = GridK.SelectedItem as DataRowView;

            int a = Convert.ToInt16(row.Row.ItemArray[2]);
            cost += a;
            Modele model = new Modele();
            model.Care_PetID = Convert.ToInt16(row.Row.ItemArray[0]);
            model.TYPУ_CARE = row.Row.ItemArray[1].ToString();
            model.COST = Convert.ToInt16(row.Row.ItemArray[2]);
            list.Add(model);
            GridProd.ItemsSource = new ObservableCollection<Modele>(list);
            Cost.Text = cost.ToString();
        }

        private void munes_Click(object sender, RoutedEventArgs e)
        {
            var prod = new ObservableCollection<Modele>(list);
            GridProd.ItemsSource = prod;
            Modele user = GridProd.SelectedItem as Modele;
            if (user != null)
            {
                prod.Remove(user);
                list.Remove(user);

                cost -= user.COST;
                Cost.Text = cost.ToString();

            }
        }

        private void DownloadChek_Click(object sender, RoutedEventArgs e)
        {
            ChekNamber += 1;
            namber += 1;
            NameChek.Text = "Chek" + namber.ToString();
            string newFile = NameChek.Text;
            string path = "C:\\Users\\victo\\OneDrive\\Рабочий стол\\" + newFile + ".txt";
            int pris = Convert.ToInt16(introduced.Text);
            int resylt = 0;
            resylt = pris - cost;

            if (File.Exists(path))
            {
                MessageBox.Show("Такой чек есть");
            }
            else
            {
                using (TextWriter tw = new StreamWriter(path))
                {
                    tw.WriteLine(string.Format($" Пивнуха для Старухина \n"
                                                + $" Кассовый чек №{ChekNamber}\n")
                                                            + "\n");

                    foreach (var item in list)
                    {
                        tw.WriteLine(string.Format($"              {item.TYPУ_CARE} - {item.COST}"));

                    }
                    tw.WriteLine(string.Format("\n"
                                                + $"Итого к оплате:{cost} \n"
                                                + $"Внесено:{pris} \n"
                                                    + $"Сдача:{resylt}\n"));

                }
            }
        }
    }
}