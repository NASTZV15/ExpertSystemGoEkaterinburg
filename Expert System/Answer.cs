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
    public partial class Answer : Form
    {
        Rule Rule;
        int pr;
        public Answer(Rule Rule , int pr)
        {
            this.Rule = Rule;
            this.pr = pr;
            InitializeComponent();
            SolutiontextBox.Text = Rule.adress;
            ProblemtextBox.Text = Rule.answer;
            textBox1.Text = Rule.pr.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
