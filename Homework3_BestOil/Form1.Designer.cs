namespace Homework3_BestOil
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_benzin_novu = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_qiymet = new System.Windows.Forms.Label();
            this.txtbox_qiymet = new System.Windows.Forms.TextBox();
            this.lbl_azn = new System.Windows.Forms.Label();
            this.rbn_Litr = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_litr = new System.Windows.Forms.TextBox();
            this.txt_mebleg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_Umimi_qiymet = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_benzin_novu
            // 
            this.lbl_benzin_novu.AutoSize = true;
            this.lbl_benzin_novu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_benzin_novu.Location = new System.Drawing.Point(6, 56);
            this.lbl_benzin_novu.Name = "lbl_benzin_novu";
            this.lbl_benzin_novu.Size = new System.Drawing.Size(138, 25);
            this.lbl_benzin_novu.TabIndex = 0;
            this.lbl_benzin_novu.Text = "Benzin Novu";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "A-92",
            "Ai-95",
            "Dizel",
            "CNG",
            "Maye qaz"});
            this.comboBox1.Location = new System.Drawing.Point(172, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(174, 30);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbl_qiymet
            // 
            this.lbl_qiymet.AutoSize = true;
            this.lbl_qiymet.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_qiymet.Location = new System.Drawing.Point(6, 127);
            this.lbl_qiymet.Name = "lbl_qiymet";
            this.lbl_qiymet.Size = new System.Drawing.Size(84, 25);
            this.lbl_qiymet.TabIndex = 0;
            this.lbl_qiymet.Text = "Qiymet";
            // 
            // txtbox_qiymet
            // 
            this.txtbox_qiymet.Location = new System.Drawing.Point(172, 125);
            this.txtbox_qiymet.Name = "txtbox_qiymet";
            this.txtbox_qiymet.ReadOnly = true;
            this.txtbox_qiymet.Size = new System.Drawing.Size(102, 39);
            this.txtbox_qiymet.TabIndex = 2;
            this.txtbox_qiymet.Tag = "";
            // 
            // lbl_azn
            // 
            this.lbl_azn.AutoSize = true;
            this.lbl_azn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_azn.Location = new System.Drawing.Point(300, 124);
            this.lbl_azn.Name = "lbl_azn";
            this.lbl_azn.Size = new System.Drawing.Size(46, 25);
            this.lbl_azn.TabIndex = 0;
            this.lbl_azn.Text = "azn";
            // 
            // rbn_Litr
            // 
            this.rbn_Litr.AutoSize = true;
            this.rbn_Litr.Location = new System.Drawing.Point(9, 50);
            this.rbn_Litr.Name = "rbn_Litr";
            this.rbn_Litr.Size = new System.Drawing.Size(108, 29);
            this.rbn_Litr.TabIndex = 3;
            this.rbn_Litr.TabStop = true;
            this.rbn_Litr.Text = "Mebleg";
            this.rbn_Litr.UseVisualStyleBackColor = true;
            this.rbn_Litr.CheckedChanged += new System.EventHandler(this.rbn_Litr_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(9, 104);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 29);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Litr";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbn_Litr);
            this.groupBox1.Controls.Add(this.txt_litr);
            this.groupBox1.Controls.Add(this.txt_mebleg);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(6, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 155);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alis Novu";
            // 
            // txt_litr
            // 
            this.txt_litr.Enabled = false;
            this.txt_litr.Location = new System.Drawing.Point(166, 99);
            this.txt_litr.Name = "txt_litr";
            this.txt_litr.PlaceholderText = "Litr Secin";
            this.txt_litr.Size = new System.Drawing.Size(157, 34);
            this.txt_litr.TabIndex = 2;
            this.txt_litr.TextChanged += new System.EventHandler(this.txt_litr_TextChanged);
            // 
            // txt_mebleg
            // 
            this.txt_mebleg.Enabled = false;
            this.txt_mebleg.Location = new System.Drawing.Point(166, 44);
            this.txt_mebleg.Name = "txt_mebleg";
            this.txt_mebleg.PlaceholderText = "Mebleg Secin";
            this.txt_mebleg.Size = new System.Drawing.Size(157, 34);
            this.txt_mebleg.TabIndex = 2;
            this.txt_mebleg.TextChanged += new System.EventHandler(this.txt_mebleg_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Umumi Mebleg";
            // 
            // txtbox_Umimi_qiymet
            // 
            this.txtbox_Umimi_qiymet.Location = new System.Drawing.Point(191, 383);
            this.txtbox_Umimi_qiymet.Name = "txtbox_Umimi_qiymet";
            this.txtbox_Umimi_qiymet.ReadOnly = true;
            this.txtbox_Umimi_qiymet.Size = new System.Drawing.Size(155, 39);
            this.txtbox_Umimi_qiymet.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.txtbox_Umimi_qiymet);
            this.groupBox2.Controls.Add(this.lbl_benzin_novu);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.lbl_qiymet);
            this.groupBox2.Controls.Add(this.txtbox_qiymet);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lbl_azn);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(22, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 473);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Socar Best Oil";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 620);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lbl_benzin_novu;
        private ComboBox comboBox1;
        private Label lbl_qiymet;
        private TextBox txtbox_qiymet;
        private Label lbl_azn;
        private RadioButton rbn_Litr;
        private RadioButton radioButton2;
        private GroupBox groupBox1;
        private TextBox txt_litr;
        private TextBox txt_mebleg;
        private Label label1;
        private TextBox txtbox_Umimi_qiymet;
        private GroupBox groupBox2;
    }
}