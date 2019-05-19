using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI
{
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
            var book1 = new Book("Pod Igoto", "Ivan Vazov", new DateTime(23/02/2019));
            var book2 = new Book("Pod Igoto 2", "Ivan Vazov", new DateTime(23/02/2019));
            var book3 = new Book("Pod Igoto 3 ", "Ivan Vazov", new DateTime(23/02/2019));
            var book4 = new Book("Pod Igoto 4", "Ivan Vazov", new DateTime(23/02/2019));

            var books = new List<Book> {book1, book2, book3, book4};

            var bindingSource = new BindingSource {DataSource = books};

            comboBox1.DataSource = bindingSource;
            comboBox1.DisplayMember = "Name";
            textBox1.DataBindings.Add("Text", bindingSource, "Author"); 
        }
    }
}
