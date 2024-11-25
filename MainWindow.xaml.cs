using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAssignment3_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            StudentData.ItemsSource = MockData.CreateData();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            int id = MockData.Students.Count + 1;
            Student.AddStudent_Click(new Student() {StudID = id, FirstName = "Elijah", LastName = "Rogers", Address = "Place in a place", MonthOfAdmission = Months.Mar, Grade = "A" });
            StudentData.Items.Refresh();
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            int id = Convert.ToInt32(txtRemove.Text);
            txtRemove.Clear();
            Student.RemoveStudent_Click(id);
            StudentData.Items.Refresh();
            txtRemove.Text = "Enter Another ID";
        }
    }
}