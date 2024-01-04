namespace SetIconAllForms
{
    public partial class FDemo : Form
    {
        public FDemo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FDemo2 fDemo2 = new FDemo2();
            fDemo2.Show();
        }
    }
}
