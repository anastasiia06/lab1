namespace WinFormsApp5
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            string[] a = s.Split(' ');

            string[] changed = new string[s.Length];
            int changedCount = 0;

            foreach (string word in a)
            {
                bool exists = false;
                for (int i = 0; i < changedCount; i++)
                {
                    if (changed[i] == word)
                    {
                        exists = true;
                        break;
                    }
                }

                if (!exists)
                {
                    changed[changedCount] = word;
                    changedCount++;
                }
            }
            for (int i = 0; i < changedCount - 1; i++)
            {
                for (int j = 0; j < changedCount - i - 1; j++)
                {
                    if (string.Compare(changed[j], changed[j + 1]) > 0)
                    {
                        string current = changed[j];
                        changed[j] = changed[j + 1];
                        changed[j + 1] = current;
                    }
                }
            }


            string newSentence = "";
            for (int i = 0; i < changedCount; i++)
            {
                if (i > 0) newSentence += " ";
                newSentence += changed[i];
            }

            label1.Text = "Результат: " + newSentence;
        }
    }
}
