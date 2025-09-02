using System.Diagnostics.Eventing.Reader;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string n = textBox1.Text;
            string changed = ChangedNumber(n);
            label1.Text = $"Результат: {changed}";

        }
        private string ChangedNumber(string n) {

            StringBuilder sb = new StringBuilder();
            int len = n.Length;
            int i = 0;
            int fLength = len % 2 == 0 ? 2 : 1;
            sb.Append(n.Substring(0, fLength));
            i += fLength;

            
            if (i < len) sb.Append("-");

            
            while (i < len)
            {
                sb.Append(n.Substring(i, 2));
                i += 2;
                if (i < len)
                    sb.Append("-");
            }

            return sb.ToString();
        }

    }



    }

