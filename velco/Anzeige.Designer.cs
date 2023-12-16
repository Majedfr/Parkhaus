namespace velco
{
    partial class Anzeige
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anzeige));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            rtb_info = new RichTextBox();
            btn_info = new Button();
            btn_rein = new Button();
            btn_raus = new Button();
            tb_kennzeichen = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            rbn_motorad = new RadioButton();
            rbn_auto = new RadioButton();
            btn_frei = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 211);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1329, 23);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(189, 225);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // rtb_info
            // 
            rtb_info.Location = new Point(419, 240);
            rtb_info.Name = "rtb_info";
            rtb_info.ReadOnly = true;
            rtb_info.Size = new Size(589, 193);
            rtb_info.TabIndex = 2;
            rtb_info.Text = "";
            // 
            // btn_info
            // 
            btn_info.BackColor = SystemColors.Highlight;
            btn_info.Location = new Point(58, 523);
            btn_info.Name = "btn_info";
            btn_info.Size = new Size(231, 59);
            btn_info.TabIndex = 3;
            btn_info.Text = "Fahrzeug suchen";
            btn_info.UseVisualStyleBackColor = false;
            btn_info.Click += btn_info_Click;
            // 
            // btn_rein
            // 
            btn_rein.BackColor = Color.Lime;
            btn_rein.Location = new Point(438, 523);
            btn_rein.Name = "btn_rein";
            btn_rein.Size = new Size(231, 59);
            btn_rein.TabIndex = 4;
            btn_rein.Text = "Einfahren";
            btn_rein.UseVisualStyleBackColor = false;
            btn_rein.Click += btn_rein_Click;
            // 
            // btn_raus
            // 
            btn_raus.BackColor = Color.Red;
            btn_raus.Location = new Point(807, 523);
            btn_raus.Name = "btn_raus";
            btn_raus.Size = new Size(231, 59);
            btn_raus.TabIndex = 5;
            btn_raus.Text = "Verlassen";
            btn_raus.UseVisualStyleBackColor = false;
            btn_raus.Click += btn_raus_Click;
            // 
            // tb_kennzeichen
            // 
            tb_kennzeichen.Location = new Point(588, 114);
            tb_kennzeichen.Name = "tb_kennzeichen";
            tb_kennzeichen.Size = new Size(240, 31);
            tb_kennzeichen.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(242, 114);
            label1.Name = "label1";
            label1.Size = new Size(292, 25);
            label1.TabIndex = 7;
            label1.Text = "Bitte geben Sie das kennzeichen ein";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbn_motorad);
            groupBox1.Controls.Add(rbn_auto);
            groupBox1.Location = new Point(916, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 150);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bitte wählen Sie den Fahrzeugtyp";
            // 
            // rbn_motorad
            // 
            rbn_motorad.AutoSize = true;
            rbn_motorad.Location = new Point(30, 89);
            rbn_motorad.Name = "rbn_motorad";
            rbn_motorad.Size = new Size(107, 29);
            rbn_motorad.TabIndex = 1;
            rbn_motorad.TabStop = true;
            rbn_motorad.Text = "Motorad";
            rbn_motorad.UseVisualStyleBackColor = true;
            // 
            // rbn_auto
            // 
            rbn_auto.AutoSize = true;
            rbn_auto.Location = new Point(30, 42);
            rbn_auto.Name = "rbn_auto";
            rbn_auto.Size = new Size(76, 29);
            rbn_auto.TabIndex = 0;
            rbn_auto.TabStop = true;
            rbn_auto.Text = "Auto";
            rbn_auto.UseVisualStyleBackColor = true;
            // 
            // btn_frei
            // 
            btn_frei.BackColor = Color.RoyalBlue;
            btn_frei.Location = new Point(1197, 523);
            btn_frei.Name = "btn_frei";
            btn_frei.Size = new Size(231, 59);
            btn_frei.TabIndex = 9;
            btn_frei.Text = "Freiplätze";
            btn_frei.UseVisualStyleBackColor = false;
            btn_frei.Click += btn_frei_Click;
            // 
            // Anzeige
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1549, 686);
            Controls.Add(btn_frei);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(tb_kennzeichen);
            Controls.Add(btn_raus);
            Controls.Add(btn_rein);
            Controls.Add(btn_info);
            Controls.Add(rtb_info);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Anzeige";
            Text = "Anzeige";
            Load += Anzeige_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private RichTextBox rtb_info;
        private Button btn_info;
        private Button btn_rein;
        private Button btn_raus;
        private TextBox tb_kennzeichen;
        private Label label1;
        private GroupBox groupBox1;
        private RadioButton rbn_motorad;
        private RadioButton rbn_auto;
        private Button btn_frei;
    }
}