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
    public partial class F1 : Form, IRecibirDatos 
    {
        public F1()
        {
            InitializeComponent();
        }

        public void Mostrar(string value)
        {
            //MessageBox.Show("Form1" + value);
            textBox1.Text = value;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm_bus = new consulta(this);
            frm_bus.Show();
        }
    }
}
