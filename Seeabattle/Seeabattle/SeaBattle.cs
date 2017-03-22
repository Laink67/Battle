using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seeabattle
{
    public partial class SeaBattle : Form
    {
        
        
            public SeaBattle()
        {
            InitializeComponent();
        }
        Rasstanovka my_Rasstanovka = new Rasstanovka();
        

      

        public void SeaBattle_Load(object sender, EventArgs e)
        {
            Player1_field.RowCount = 10;
            Player1_field.ColumnCount = 10;
            my_Rasstanovka.Init(Player1_field);
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Player1_field.Enabled = true;
        }

        private void Player1_field_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewButtonCell ButtonCell = (DataGridViewButtonCell)Player1_field.Rows[e.RowIndex].Cells[e.ColumnIndex];
            {
              
            }
        }
    }
}
