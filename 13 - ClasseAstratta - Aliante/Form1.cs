using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace _13___ClasseAstratta___Aliante
{
    public partial class Form1 : Form
    {
        private List<string> values = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Aggiungibutton_Click(object sender, EventArgs e)
        {


            if (FusoliaraRadio.Checked)
            {
                values.Add(textBox1.Text);
                values.Add(textBox2.Text);

            }
            if (AlaRadio.Checked)
            {
                values.Add(textBox4.Text);
                values.Add(textBox3.Text);

            }
            if (CodaRadio.Checked)
            {
                values.Add(textBox5.Text);
            }
            if (RuotaRadio.Checked)
            {
                values.Add(textBox7.Text);
                values.Add(textBox6.Text);
                values.Add(textBox8.Text);
                
                values.Add(textBox10.Text);
                values.Add(textBox9.Text);

            }
        }

        private void Visualizzabutton_Click(object sender, EventArgs e)
        {
            foreach (string value in values)
            {
                listView1.Items.Add(value);
            }
        }
    }
}
