namespace USchleifeWhile
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            double input = Double.Parse(TBxInput.Text);
            LblOutput.Text = "";
            while (input > 0.01)
            {
                LblOutput.Text += $"{input -= input / 2}\n";
            }
        }
    }
}