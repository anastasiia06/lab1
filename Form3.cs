using System.Threading.Channels;

namespace WinFormsApp4
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            string[] a = s.Split(" ");
            int maxLength = 0;
            foreach (string word in a)
            {
                if (word.Length > maxLength)
                    maxLength = word.Length;
            }
            string result = "";
            for (int len = 1; len <= maxLength; len++)
            {
                foreach (string word in a)
                {
                    if (word.Length == len)
                    {
                        if (result != "")
                            result += " "; 
                        result += word;
                    }
                }
            }
            label1.Text = $"Результат: {result}";

        }
    }
}
