using ObjectOrientedPractics.Model;
using System.Windows.Forms;

namespace ObjectOrientedPractics
{
    partial class MainForm : Form
    {
        private Store _store;

        public MainForm()
        {
            InitializeComponent();

            _store = new Store();

            this.ItemsTab.Items = _store.Items;
            this.CustomersTab.Customers = _store.Customers;
        }
    }
}
