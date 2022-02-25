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

namespace Garcia_Bernardo_PRG_III__A__PrácticaEstructuraCola
{
    /// <summary>
    /// PRACTICA COLAS
    /// Una libreria recibe pedidos por telefono.Cada pedido es registrado y se atiende segun el orden de llegada.
    /// Cada pedido puede solicitar varios productos de dsitintos tipos. 
    /// </summary>
    public partial class MainWindow : Window
    {
        Queue<Order> books = new Queue<Order>();
        Stack<Order> orderAttended = new Stack<Order>();

        int num = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnPedir_Click(object sender, RoutedEventArgs e)
        {
            Order b = new Order(int.Parse(txbNumeroPedido.Text), txbBook.Text, int.Parse(txbNumber.Text));
            books.Enqueue(b);
            ShowQueue();
            txbBook.Text = "";
            txbNumeroPedido.Text = "";
        }

        public void ShowQueue()
        { 
            lstCola.Items.Clear();
            foreach (var item in books)
            {
                lstCola.Items.Add("Número Pedido: " + item.Number + " Libro: " + item.ID + " " + item.Name);
            }
        }

        public void ShowStack()
        {
            lstAtendidos.Items.Clear();
            foreach (var item in orderAttended)
            {
                lstAtendidos.Items.Add("Número Pedido: " + item.Number + " Libro: " + item.ID + " " + item.Name);
            }
        }

        private void btnAttended_Click(object sender, RoutedEventArgs e)
        {
            orderAttended.Push(books.Dequeue());
            ShowQueue();
            ShowStack();
        }
    }
}
