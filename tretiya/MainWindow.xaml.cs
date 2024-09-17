using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace tretiya
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static List<UserScopedSettingAttribute> users = new List<user>();
        public MainWindow()
        {
            InitializeComponent();

        }
        void Load()
        {
            users.Add(new user)
                {
                name = name.Text,
                password = password.Text,
                };

        }
        public class user
        {
            public string name(get; set;)
                public string password (get; set;)
        }

    }
}
