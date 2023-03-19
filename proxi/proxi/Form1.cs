using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static proxi.IBank;

namespace proxi
{
    public partial class Form1 : Form
    {
        private BankProxy _bankProxy;
        public Form1()
        {
            InitializeComponent();
            _bankProxy = new BankProxy();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGetConsultation_Click(object sender, EventArgs e)
        {
            var question = txtQuestion.Text;
            var answer = _bankProxy.GetConsultation(question);
            txtAnswer.Text = answer;
        }
    }
}
