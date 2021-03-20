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
using DataLibrary;
using Microsoft.Win32;
using Prism.Services.Dialogs;
using Org.BouncyCastle.Crypto.Tls;

namespace Test
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {           
        V1MainCollection element_collection = new V1MainCollection();
        ListCollectionView list_CollectionView;

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = element_collection;
        }

        private void menu_New(object sender, RoutedEventArgs e)
        {
            
            if (!element_collection.change_after_save)
            {
                if(MessageBox.Show("Объект не был сохранен. Сохранить?","!!!",MessageBoxButton.OKCancel)==MessageBoxResult.OK)
                {
                    menu_Save(sender, e);
                }
               
            }
            element_collection.change_after_save = true;
            element_collection.New_V1MainCollection();
            //element_collection = new V1MainCollection();
           // element_collection.NotifyPropertyChanged("all_elements");
        }

        private void menu_Add_Defaults(object sender, RoutedEventArgs e)
        {
         //   element_collection.change_after_save = false;
            element_collection.AddDefaults();

        }

        private void menu_Add_Default_V1DataOnGrid(object sender, RoutedEventArgs e)
        {
           // element_collection.change_after_save = false;
            Random rnd = new Random();
            DataLibrary.Grid new_grid = new DataLibrary.Grid(rnd.Next(100), rnd.Next(5), 4);
            V1DataOnGrid value1 = new V1DataOnGrid("ID1", new DateTime(5, 5, 5), new_grid);
            value1.InitRandom(3, 7);
            element_collection.Add(value1);

         
        //    ListBox_DataCollection.ItemsSource = from item in element_collection where item is V1DataCollection select (V1DataCollection)item;
        //    ListBox_DataOnGrid.ItemsSource = from item in element_collection where item is V1DataOnGrid select (V1DataOnGrid)item;

        }

        private void menu_Open(object sender, RoutedEventArgs e)
        {
           
            if (!element_collection.change_after_save)
            {
                if (MessageBox.Show("Объект не был сохранен. Сохранить?", "!!!", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
                {
                    menu_Save(sender, e);
                }

            }
            element_collection = new V1MainCollection();
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "C#(*cs)|*.cs|PowerPointDocs(*.ppt;*pptx)|*ppt;*pptx;|All(*.*)|*.*";
            dlg.FilterIndex = 3;
            if (dlg.ShowDialog() == true)
            {
                element_collection.Load(dlg.FileName);
                this.DataContext = element_collection;
                element_collection.change_after_save = true;

            }

            //     ListBox_DataCollection.ItemsSource = from item in element_collection where item is V1DataCollection select (V1DataCollection)item;
            //     ListBox_DataOnGrid.ItemsSource = from item in element_collection where item is V1DataOnGrid select (V1DataOnGrid)item;
        }

        private void menu_Save(object sender, RoutedEventArgs e)
        {
            element_collection.change_after_save = true;
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "C#(*cs)|*.cs|PowerPointDocs(*.ppt;*pptx)|*ppt;*pptx;|All(*.*)|*.*";
            dlg.FilterIndex = 3;
            if (dlg.ShowDialog() == true)
            {
             //   textBox1.Text = dlg.FileName/* + "\n" + Directory.GetCurrentDirectory().ToString()*/;
                element_collection.Save(dlg.FileName);
            }
        }

        private void menu_Add_Default_V1DataCollection(object sender, RoutedEventArgs e)
        {
       //     element_collection.change_after_save = false;
            V1DataCollection value2 = new V1DataCollection("ID4", new DateTime(5, 5, 5));
            value2.InitRandom(5, 1, 4, 3, 4);
            element_collection.Add(value2);

       //     ListBox_DataCollection.ItemsSource = from item in element_collection where item is V1DataCollection select (V1DataCollection)item;
       //     ListBox_DataOnGrid.ItemsSource = from item in element_collection where item is V1DataOnGrid select (V1DataOnGrid)item;

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            //   MessageBox.Show("Объект не сохранен!");
            if (!element_collection.change_after_save)
            {
                MessageBoxResult result = MessageBox.Show("Последний объект не был сохранен. Сохранить?", "", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    element_collection.change_after_save = true;
                    SaveFileDialog dlg = new SaveFileDialog();
                    dlg.Filter = "C#(*cs)|*.cs|PowerPointDocs(*.ppt;*pptx)|*ppt;*pptx;|All(*.*)|*.*";
                    dlg.FilterIndex = 3;
                    if (dlg.ShowDialog() == true)
                    {
                        //textBox1.Text = dlg.FileName/* + "\n" + Directory.GetCurrentDirectory().ToString()*/;
                        element_collection.Save(dlg.FileName);
                    }
                }
            }
        }

        private void menu_Add_Element_from_File(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "C#(*cs)|*.cs|PowerPointDocs(*.ppt;*pptx)|*ppt;*pptx;|All(*.*)|*.*";
                dlg.FilterIndex = 3;
                if (dlg.ShowDialog() == true)
                {
                    element_collection.Add(new V1DataCollection(dlg.FileName));
                }
               // element_collection.change_after_save = false;
             //   ListBox_DataCollection.ItemsSource = from item in element_collection where item is V1DataCollection select (V1DataCollection)item;
             //   ListBox_DataOnGrid.ItemsSource = from item in element_collection where item is V1DataOnGrid select (V1DataOnGrid)item;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void menu_Remove(object sender, RoutedEventArgs e)
        {
            //                string[] file_data = file_string.Split(new char[] { ';' });
            if(ListBox_Main.SelectedItems.Count>0)
            { 
                string[] str_sourse = ListBox_Main.SelectedItem.ToString().Split(new char[] { ' ', '\n' });
                DateTime date = DateTime.Parse(str_sourse[8] + " " + str_sourse[9]);
                element_collection.Remove(str_sourse[5], date);
             //   element_collection.change_after_save = false;

              //  ListBox_DataCollection.ItemsSource = from item in element_collection where item is V1DataCollection select (V1DataCollection)item;
             //   ListBox_DataOnGrid.ItemsSource = from item in element_collection where item is V1DataOnGrid select (V1DataOnGrid)item;
            }
           
        }

        private void FilterByDataCollection(object sender, FilterEventArgs args)
        {
            if (args.Item !=null )
            {
                if (args.Item is V1DataCollection) args.Accepted = true;
                else args.Accepted = false;
            }
        }

        private void FilterByDataOnGrid(object sender, FilterEventArgs args)
        {
            if (args.Item != null)
            {
                if (args.Item is V1DataOnGrid) args.Accepted = true;
                else args.Accepted = false;
            }
        }

    }
}
