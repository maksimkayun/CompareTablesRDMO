using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIFormRDMO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PathLabel.Text = UIFormRDMO.Menu.Path;
            PathField.Text = UIFormRDMO.Menu.Path;
        }

        private void GetPath_Click(object sender, EventArgs e)
        {
            var args = new[] { "1", PathField.Text };
            UIFormRDMO.Menu.Start(args);
            PathLabel.Text = UIFormRDMO.Menu.Path;
        }

        private void StartCompareBtn_Click(object sender, EventArgs e)
        {
            var args = new[] { "4" };
            UIFormRDMO.Menu.Start(args);
            
            args = new[] { "6" };
            UIFormRDMO.Menu.Start(args);
        }

        private void ClearListsBtn_Click(object sender, EventArgs e)
        {
            var args = new[] { "5" };
            UIFormRDMO.Menu.Start(args);
        }
    }
}