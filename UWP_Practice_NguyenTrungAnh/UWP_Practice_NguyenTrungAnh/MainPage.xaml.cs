using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using UWP_Practice_NguyenTrungAnh.Model;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWP_Practice_NguyenTrungAnh
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<Icon> Icons;

        private ObservableCollection<Contact> Contacts;

        public MainPage()
        {
            this.InitializeComponent();
            Icons = new List<Icon>();
            Icons.Add(new Icon { IconPath = "Assets/aodai1.jpg" });
            Icons.Add(new Icon { IconPath = "Assets/aodai2.jpg" });
            Icons.Add(new Icon { IconPath = "Assets/thethao1.jpg" });
            Icons.Add(new Icon { IconPath = "Assets/thethao2.jpg" });
            Icons.Add(new Icon { IconPath = "Assets/vay1.jpg" });
            Icons.Add(new Icon { IconPath = "Assets/vay2.jpg" });

            Contacts = new ObservableCollection<Contact>();
            Contacts.Add(new Contact { ProductName = "Ao Dai", Description = "Great", ImagePath = "Assets/aodai1.jpg" });
            Contacts.Add(new Contact { ProductName = "The Thao", Description = "Good", ImagePath = "Assets/thethao1.jpg" });
            Contacts.Add(new Contact { ProductName = "Vay Ngan", Description = "Great", ImagePath = "Assets/vay2.jpg" });
        }

        private void NewContactButton_Click(object sender, RoutedEventArgs e)
        {
            string image = ((Icon)ImageCombobox.SelectedValue).IconPath;
            Contacts.Add(new Contact
            {
                ProductName = ProductTextBox.Text,
                Description = DescriptionTextBox.Text,
                ImagePath = image
            });

            ProductTextBox.Text = "";
            DescriptionTextBox.Text = "";
            ImageCombobox.SelectedItem = -1;

            ProductTextBox.Focus(FocusState.Programmatic);
        }
    }
}
