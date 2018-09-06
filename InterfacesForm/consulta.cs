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
    public partial class consulta : Form
    {
        private IRecibirDatos from;
        public consulta(IRecibirDatos frm)
        {
            this.from = frm;
            InitializeComponent();
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            this.Parent
            from.Mostrar(txt_value.Text);
            this.Close();
        }
    }
}
