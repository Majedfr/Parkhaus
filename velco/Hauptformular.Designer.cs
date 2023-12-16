namespace velco
{
    partial class Hauptformular
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hauptformular));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            tb_etage = new TextBox();
            tb_auto = new TextBox();
            btn_festlegen = new Button();
            label3 = new Label();
            tb_motorad = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(213, 183);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1095, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(213, 183);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(21, 280);
            label1.Name = "label1";
            label1.Size = new Size(377, 30);
            label1.TabIndex = 2;
            label1.Text = "Bitte geben Sie die Anzahl der Etagen";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 337);
            label2.Name = "label2";
            label2.Size = new Size(480, 60);
            label2.TabIndex = 3;
            label2.Text = "Bitte geben Sie die Anzahl die  Autos Parkplätze \r\npro Etage in der Reihenfolge getrennt durch(,)";
            // 
            // tb_etage
            // 
            tb_etage.Location = new Point(600, 281);
            tb_etage.Name = "tb_etage";
            tb_etage.Size = new Size(114, 31);
            tb_etage.TabIndex = 4;
            // 
            // tb_auto
            // 
            tb_auto.Location = new Point(600, 349);
            tb_auto.Name = "tb_auto";
            tb_auto.Size = new Size(320, 31);
            tb_auto.TabIndex = 5;
            // 
            // btn_festlegen
            // 
            btn_festlegen.BackColor = SystemColors.ActiveCaption;
            btn_festlegen.Location = new Point(598, 532);
            btn_festlegen.Name = "btn_festlegen";
            btn_festlegen.Size = new Size(307, 64);
            btn_festlegen.TabIndex = 7;
            btn_festlegen.Text = "Bestätigen und starten";
            btn_festlegen.UseVisualStyleBackColor = false;
            btn_festlegen.Click += btn_festlegen_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 436);
            label3.Name = "label3";
            label3.Size = new Size(530, 60);
            label3.TabIndex = 8;
            label3.Text = "Bitte geben Sie die Anzahl die  Motoräder Parkplätze \r\npro Etage in der Reihenfolge getrennt durch(,)";
            // 
            // tb_motorad
            // 
            tb_motorad.Location = new Point(598, 465);
            tb_motorad.Name = "tb_motorad";
            tb_motorad.Size = new Size(320, 31);
            tb_motorad.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(598, 392);
            label4.Name = "label4";
            label4.Size = new Size(626, 50);
            label4.TabIndex = 10;
            label4.Text = "Beispiel für 3 Etagen \r\n100,50,0  (Hier 0 muss eingegeben wenn in 3 Etage keine parkplätze für Auto)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1320, 649);
            Controls.Add(label4);
            Controls.Add(tb_motorad);
            Controls.Add(label3);
            Controls.Add(btn_festlegen);
            Controls.Add(tb_auto);
            Controls.Add(tb_etage);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Bestätigen und starten";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private TextBox tb_etage;
        private TextBox tb_auto;
        private Button btn_festlegen;
        private Label label3;
        private TextBox tb_motorad;
        private Label label4;
    }
}