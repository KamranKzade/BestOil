namespace Homework3_BestOil
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "A-92":
                    txtbox_qiymet.Text = "1";
                    break;
                case "Ai-95":
                    txtbox_qiymet.Text = "2";
                    break;
                case "Dizel":
                    txtbox_qiymet.Text = "0.8";
                    break;
                case "CNG":
                    txtbox_qiymet.Text = "0.4";
                    break;
                case "Maye qaz":
                    txtbox_qiymet.Text = "0.65";
                    break;
                default:
                    break;
            }
        }

        private void rbn_Litr_CheckedChanged(object sender, EventArgs e) => txt_mebleg.Enabled = true;


        private void radioButton2_CheckedChanged(object sender, EventArgs e) => txt_litr.Enabled = true;

        private void txt_mebleg_TextChanged(object sender, EventArgs e) => txtbox_Umimi_qiymet.Text = txt_mebleg.Text;


        private void txt_litr_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(txtbox_qiymet.Text, out double qiymet);
            double.TryParse(txt_litr.Text, out double litr);

            txtbox_Umimi_qiymet.Text = (qiymet * litr).ToString();
        }
    }
}