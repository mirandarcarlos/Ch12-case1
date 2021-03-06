using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenvilleAds
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RulesButton_Click(object sender, EventArgs e)
        {
            FormRules formRules = new FormRules();
            formRules.ShowDialog();
        }

        private void RulesReadCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (rulesReadCheckBox.Checked) {
                ReadRulesForm readRulesForm = new ReadRulesForm();
                readRulesForm.ShowDialog();
            }
        }
    }
}
