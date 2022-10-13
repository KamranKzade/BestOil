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


            radioButton2.Enabled = true;
            rbn_Litr.Enabled = true;
        }

        private void rbn_Litr_CheckedChanged(object sender, EventArgs e)
        {
            txt_mebleg.Enabled = true;

            txt_litr.Enabled = false;
            txt_litr.Text = string.Empty;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txt_litr.Enabled = true;

            txt_mebleg.Enabled = false;
            txt_mebleg.Text = string.Empty;
        }

        double UmumiMeblegBenzin = 0;
        private void txt_mebleg_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(txt_mebleg.Text, out double qiymet);
            UmumiMeblegBenzin = qiymet;
            txtbox_Umimi_qiymet.Text = UmumiMeblegBenzin.ToString();
        }


        private void txt_litr_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(txtbox_qiymet.Text, out double qiymet);
            double.TryParse(txt_litr.Text, out double litr);

            UmumiMeblegBenzin = qiymet * litr;

            txtbox_Umimi_qiymet.Text = UmumiMeblegBenzin.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txt_hot_say.Enabled = true;
            txt_hot_say.Text = string.Empty;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            txt_gambur_say.Enabled = true;
            txt_gambur_say.Text = string.Empty;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            txt_kartof_say.Enabled = true;
            txt_kartof_say.Text = string.Empty;
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            txt_cola_say.Enabled = true;
            txt_cola_say.Text = string.Empty;
        }


        double UmumiMeblegKafe = 0;


        private void txt_hot_say_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(hot_qiymet.Text, out double hot_Qiymet);
            int.TryParse(txt_hot_say.Text, out int hot_say);
            UmumiMeblegKafe = hot_Qiymet * hot_say;

            text_mehsul_qiymet.Text = UmumiMeblegKafe.ToString();
        }

        private void txt_gambur_say_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(gambur_qiymet.Text, out double Gambur_Qiymet);
            int.TryParse(txt_gambur_say.Text, out int gambur_say);
            UmumiMeblegKafe = Gambur_Qiymet * gambur_say;

            text_mehsul_qiymet.Text = UmumiMeblegKafe.ToString();
        }

        private void txt_kartof_say_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(kartof_qiymet.Text, out double Kartof_qiymet);
            int.TryParse(txt_kartof_say.Text, out int kartof_say);
            UmumiMeblegKafe = Kartof_qiymet * kartof_say;

            text_mehsul_qiymet.Text = UmumiMeblegKafe.ToString();
        }

        private void txt_cola_say_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(cola_qiymet.Text, out double Cola_qiymet);
            int.TryParse(txt_cola_say.Text, out int cola_say);
            UmumiMeblegKafe = Cola_qiymet * cola_say;

            text_mehsul_qiymet.Text = UmumiMeblegKafe.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double.TryParse(hot_qiymet.Text, out double hot_Qiymet);
            int.TryParse(txt_hot_say.Text, out int hot_say);
            double.TryParse(gambur_qiymet.Text, out double Gambur_Qiymet);
            int.TryParse(txt_gambur_say.Text, out int gambur_say);
            double.TryParse(kartof_qiymet.Text, out double Kartof_qiymet);
            int.TryParse(txt_kartof_say.Text, out int kartof_say);
            double.TryParse(cola_qiymet.Text, out double Cola_qiymet);
            int.TryParse(txt_cola_say.Text, out int cola_say);



            UmumiMeblegKafe = (Cola_qiymet * cola_say) + (hot_Qiymet * hot_say) + (Gambur_Qiymet * gambur_say) + (Kartof_qiymet * kartof_say);
            txt_kafe_umumi.Text = UmumiMeblegKafe.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_pay.Text = (UmumiMeblegBenzin + UmumiMeblegKafe).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}