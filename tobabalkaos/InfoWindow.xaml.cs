using System.Windows;

namespace tobabalkaos
{
    public partial class InfoWindow : Window
    {
        public InfoWindow()
        {
            InitializeComponent();
        }

        private void Hello_Click(object sender, RoutedEventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Add meg a neved!");
                return;
            }

            MessageBox.Show($"Szia {txtName.Text.Trim()}!");
        }

        private void Title_Click(object sender, RoutedEventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Add meg a neved!");
                return;
            }

            Title = txtName.Text.Trim();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
