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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ADONetDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataSet musicDataSet = new DataSet();

            // Setup the schema and the tables
            musicDataSet.ReadXmlSchema("music.xsd");

            // Read the XML data into the tables
            musicDataSet.ReadXml("music.xml");

            // After changes are made to the DataSet, save back to file
            musicDataSet.WriteXml("music.xml");

            MusicDataGrid.ItemsSource = musicDataSet.Tables["song"]?.DefaultView;
        }
    }
}
