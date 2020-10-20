using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace UI
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            this.RefreshPeople();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonHandler.Add(this.textBox1.Text, "");
        }

        private void RefreshPeople()
        {
            this.listBox1.Items.Clear();
            this.listBox1.Items.AddRange(PersonHandler.GetPeople().ToArray());
        }
    }
}
