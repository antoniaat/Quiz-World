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
    public partial class ListBooks : Form
    {
        public ListBooks()
        {
            InitializeComponent();

            var country = new List<City>();

            var capital = new City("Sofia");
            var firstLibrary = new Library("City library", "Center");

            var libraries = new List<Library> {firstLibrary};

            country.Add(capital);
            capital.Add(firstLibrary);

            var firstBindingSource = new BindingSource();
            var secondBindingSource = new BindingSource();

            firstBindingSource.DataSource = country;
            secondBindingSource.DataSource = firstBindingSource;

            secondBindingSource.DataMember = "Members";
            comboBox1.DataSource = firstBindingSource;


                

        }
    }
}
