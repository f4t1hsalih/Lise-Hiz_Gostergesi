using System;
using System.Windows.Forms;

namespace Hiz_Gostergesi
{
    public partial class FormHiz : Form
    {
        public FormHiz()
        {
            InitializeComponent();
        }

        int a = 0;

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            a++;

            arcScaleNeedleComponent1.Value = a;
            this.Text = a.ToString();

            if (a == 100) a -= 4;

        }
    }
}
