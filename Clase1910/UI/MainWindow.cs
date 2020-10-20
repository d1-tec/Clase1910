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
    public partial class MainWindow : Form, ISubscribeable
    {
        public MainWindow()
        {
            InitializeComponent();

            RentableHandler.Subscribe(this, SubscriptionTypes.ITEMS);

            this.Update_X();
        }

        public void Update_X()
        {
            this.listBoxItems.Items.Clear();
            this.listBoxItems.Items.AddRange(RentableHandler.GetAllRentable().ToArray());
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            string itemName = this.textBoxItemName.Text;

            RentableHandler.AddItem(itemName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IRentable rentable = (IRentable)this.listBoxItems.SelectedItem;
            DateTime from = this.dateTimePickerFrom.Value;
            DateTime to = this.dateTimePickerTo.Value;

            if (rentable != null)
            {
                if (rentable.IsAvailableToRent(from, to) == true)
                {
                    rentable.Book(from, to);
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }
    }
}
