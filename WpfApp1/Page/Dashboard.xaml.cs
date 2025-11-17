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

namespace WpfApp1.Page
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        public Dashboard()
        {
            InitializeComponent();
            txtDateTime.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");

            List<TransactionModel> list = new List<TransactionModel>()
                {
                    new TransactionModel{ Date="2025-01-12", Type="Inward", FileName="File1.xml", Records=150, Status="Success", Ack="Pending", Posting="Done" },
                    new TransactionModel{ Date="2025-01-12", Type="Inward", FileName="File1.xml", Records=150, Status="Success", Ack="Pending", Posting="Done" },
                    new TransactionModel{ Date="2025-01-12", Type="Inward", FileName="File1.xml", Records=150, Status="Success", Ack="Pending", Posting="Done" },
                    new TransactionModel{ Date="2025-01-13", Type="Outward", FileName="File2.xml", Records=95, Status="Failed", Ack="Not Sent", Posting="--" },
                    new TransactionModel{ Date="2025-01-13", Type="Outward", FileName="File2.xml", Records=95, Status="Failed", Ack="Not Sent", Posting="--" },
                    new TransactionModel{ Date="2025-01-13", Type="Outward", FileName="File2.xml", Records=95, Status="Failed", Ack="Not Sent", Posting="--" },
                };

            TransactionGrid.ItemsSource = list;

        }

        private bool isMenuOpen = false;

        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!isMenuOpen)
            {
                // OPEN SIDEBAR
                SideMenu.Visibility = Visibility.Visible;
                SideMenuColumn.Width = new GridLength(250);
            }
            else
            {
                // CLOSE SIDEBAR
                SideMenu.Visibility = Visibility.Collapsed;
                SideMenuColumn.Width = new GridLength(0);
            }

            isMenuOpen = !isMenuOpen;
        }
        private void OpenUserMaster(object sender, RoutedEventArgs e)
        {
            
        }
        public class TransactionModel
        {
            public string Date { get; set; }
            public string Type { get; set; }
            public string FileName { get; set; }
            public int Records { get; set; }
            public string Status { get; set; }
            public string Ack { get; set; }
            public string Posting { get; set; }
        }





    }
}
