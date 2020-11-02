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

namespace Recipe_Projects
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        People p1 = new People { Name = "Ahmet", Amount = 0, NumberOfRecipe=0 };
        People p2 = new People { Name = "Cihat", Amount = 0, NumberOfRecipe = 0 };
        People p3 = new People { Name = "Muhammed", Amount = 0, NumberOfRecipe = 0 };
        People p4 = new People { Name = "Mucahit", Amount = 0, NumberOfRecipe = 0 };
        People p5 = new People { Name = "Yusuf", Amount = 0, NumberOfRecipe = 0 };



        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            cmbPerson.Items.Add(p1.Name);
            cmbPerson.Items.Add(p2.Name);
            cmbPerson.Items.Add(p3.Name);
            cmbPerson.Items.Add(p4.Name);
            cmbPerson.Items.Add(p5.Name);
        }

        private void btnAddRecipe_Click(object sender, RoutedEventArgs e)
        {
            People people = new People();
            if(cmbPerson.SelectedItem.ToString() == p1.Name)
            {
                p1.Amount += Convert.ToDouble(txtAmount.Text);
                p1.NumberOfRecipe++;
            }
            if(cmbPerson.SelectedItem.ToString() == p2.Name)
            {
                p2.Amount += Convert.ToDouble(txtAmount.Text);
                p2.NumberOfRecipe++;
            }
            if (cmbPerson.SelectedItem.ToString() == p3.Name)
            {
                p3.Amount += Convert.ToDouble(txtAmount.Text);
                p3.NumberOfRecipe++;
            }
            if (cmbPerson.SelectedItem.ToString() == p4.Name)
            {
                p4.Amount += Convert.ToDouble(txtAmount.Text);
                p4.NumberOfRecipe++;
            }
            if (cmbPerson.SelectedItem.ToString() == p5.Name)
            {
                p5.Amount += Convert.ToDouble(txtAmount.Text);
                p5.NumberOfRecipe++;
            }
            txtAmount.Text = "0.00$";
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            Recipe recipe = new Recipe(p1.Amount, p2.Amount, p3.Amount, p4.Amount, p5.Amount);
            recipe.Calculate();

            lblAhmet.Content = recipe.Ahmet.ToString("c");
            lblCihat.Content = recipe.Cihat.ToString("c");
            lblYusuf.Content = recipe.Yusuf.ToString("c");
            lblMuhammed.Content = recipe.Muhammed.ToString("c");
            lblMucahit.Content = recipe.Mucahit.ToString("c");

        }
    }
}
