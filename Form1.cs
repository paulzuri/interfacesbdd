using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace bases_dist
{
    public partial class formInterfaz : Form
    {
        OracleConnection conn = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=lenovoflex)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl))); USER ID=ORA1; PASSWORD=ORACLE; CONNECTION TIMEOUT=120;");

        public formInterfaz()
        {
            InitializeComponent();
        }

        private void formInterfaz_Load(object sender, EventArgs e)
        {

        }



        private void buttonPago_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MessageBox.Show("conectado");
            }
            catch
            {
                MessageBox.Show("no conectado :(");
            }
        }
    }
}
