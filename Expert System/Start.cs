using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expert_System
{
    public partial class Start : Form
    {
        public List<Rule> RulesList;
        Rules Rules;
        public Start()
        {
            Rules = new Rules(this);
            InitializeComponent();
            Rules.load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Rules.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Options Option = new Options(RulesList);
            Hide();
            Option.ShowDialog();
            this.Close();
        }
    }
}
