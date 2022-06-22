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
            BeginCompare_Label.Font = new Font("Times New Roman", 14, FontStyle.Bold);
        }

        private void GetPath_Click(object sender, EventArgs e)
        {
            var args = new[] { "1", PathField.Text };
            UIFormRDMO.Menu.StartWork(args);
            PathLabel.Text = UIFormRDMO.Menu.Path;
        }

        private void StartCompareBtn_Click(object sender, EventArgs e)
        {
            try
            {
                BeginCompare_Label.Text = "";
                var args = new[] { "4" };
                var callback4 = UIFormRDMO.Menu.StartWork(args);
                if (callback4 != "ok")
                {
                    throw new Exception(callback4);
                }
            
                args = new[] { "6" };
                var callback6= UIFormRDMO.Menu.StartWork(args);
                if (callback6 != "ok")
                {
                    throw new Exception(callback6);
                }
                BeginCompare_Label.ForeColor = Color.Green;
                BeginCompare_Label.Text = callback6;
            }
            catch (Exception exception)
            {
                BeginCompare_Label.ForeColor = Color.Brown;
                BeginCompare_Label.Text = exception.Message;
            }
            
        }

        private void ClearListsBtn_Click(object sender, EventArgs e)
        {
            var args = new[] { "5" };
            UIFormRDMO.Menu.StartWork(args);
        }
    }
}