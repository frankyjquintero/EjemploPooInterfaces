using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfacesForm
{
    public partial class F2 : Form, IRecibirDatos
    {
        public F2()
        {
            InitializeComponent();
        }

        public void Mostrar(string value)
        {
            comboBox1.Items.Add(value);
            // MessageBox.Show("Form2" +value);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm_bus = new consulta(this);
            frm_bus.Show();
        }

        private void F2_Load(object sender, EventArgs e)
        {

        }
    }
}
