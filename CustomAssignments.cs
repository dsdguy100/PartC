using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartC
{
    public partial class CustomAssignments : Form
    {
        string value;
        string[,] assignments = new string[8,2];
        public CustomAssignments()
        {
            InitializeComponent();
        }

        private void CustomAssignments_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
           value = Convert.ToString(dataGridView1.Rows[0].Cells[0].Value);
           assignments[0,0] = value;
           Test.Text = assignments[0,0];
           for (int i = 0; i < 8; i++) {
                for(int j = 0; j < 2; j++)
                {

                    assignments[i, j] = Convert.ToString(dataGridView1.Rows[0].Cells[0].Value);
                }
                
            }

        }

        private void Test_Click(object sender, EventArgs e)
        {
            value = Convert.ToString(dataGridView1.Rows[0].Cells[0].Value);
            Test.Text = value;
        }
    }
}
