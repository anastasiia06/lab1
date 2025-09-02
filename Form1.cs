namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            int count = 0;
            for (int i = 0; i < s.Length -1; i++)
            {
                if (s[i] == s[i + 1])
                {
                    count++;
                }
            }
            label1.Text = $"Результат: {count}";
        }
    }
}
