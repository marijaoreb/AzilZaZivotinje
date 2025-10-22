namespace Azil
{
    partial class Statistika
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBoxVrste = new ComboBox();
            lblUkupno = new Label();
            lblTrenutno = new Label();
            lblUdomljene = new Label();
            lblProsjecnaDob = new Label();
            lblVrstaBroj = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 71);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 0;
            label1.Text = "Broj ukupnih životinja:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 122);
            label2.Name = "label2";
            label2.Size = new Size(177, 15);
            label2.TabIndex = 1;
            label2.Text = "Broj trenutno prisutnih životinja:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 179);
            label3.Name = "label3";
            label3.Size = new Size(142, 15);
            label3.TabIndex = 2;
            label3.Text = "Broj udomljenih životinja:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 240);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 3;
            label4.Text = "Prosječna dob: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 294);
            label5.Name = "label5";
            label5.Size = new Size(140, 15);
            label5.TabIndex = 4;
            label5.Text = "Broj životinja po vrstama:";
            // 
            // comboBoxVrste
            // 
            comboBoxVrste.FormattingEnabled = true;
            comboBoxVrste.Location = new Point(238, 291);
            comboBoxVrste.Name = "comboBoxVrste";
            comboBoxVrste.Size = new Size(121, 23);
            comboBoxVrste.TabIndex = 5;
            // 
            // lblUkupno
            // 
            lblUkupno.AutoSize = true;
            lblUkupno.Location = new Point(204, 71);
            lblUkupno.Name = "lblUkupno";
            lblUkupno.Size = new Size(97, 15);
            lblUkupno.TabIndex = 6;
            lblUkupno.Text = "čekam podatke...";
            // 
            // lblTrenutno
            // 
            lblTrenutno.AutoSize = true;
            lblTrenutno.Location = new Point(277, 124);
            lblTrenutno.Name = "lblTrenutno";
            lblTrenutno.Size = new Size(97, 15);
            lblTrenutno.TabIndex = 7;
            lblTrenutno.Text = "čekam podatke...";
            // 
            // lblUdomljene
            // 
            lblUdomljene.AutoSize = true;
            lblUdomljene.Location = new Point(296, 189);
            lblUdomljene.Name = "lblUdomljene";
            lblUdomljene.Size = new Size(97, 15);
            lblUdomljene.TabIndex = 8;
            lblUdomljene.Text = "čekam podatke...";
            // 
            // lblProsjecnaDob
            // 
            lblProsjecnaDob.AutoSize = true;
            lblProsjecnaDob.Location = new Point(223, 254);
            lblProsjecnaDob.Name = "lblProsjecnaDob";
            lblProsjecnaDob.Size = new Size(97, 15);
            lblProsjecnaDob.TabIndex = 9;
            lblProsjecnaDob.Text = "čekam podatke...";
            // 
            // lblVrstaBroj
            // 
            lblVrstaBroj.AutoSize = true;
            lblVrstaBroj.Location = new Point(146, 373);
            lblVrstaBroj.Name = "lblVrstaBroj";
            lblVrstaBroj.Size = new Size(97, 15);
            lblVrstaBroj.TabIndex = 10;
            lblVrstaBroj.Text = "čekam podatke...";
            // 
            // button1
            // 
            button1.Location = new Point(157, 432);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "Nazad";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Statistika
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 510);
            Controls.Add(button1);
            Controls.Add(lblVrstaBroj);
            Controls.Add(lblProsjecnaDob);
            Controls.Add(lblUdomljene);
            Controls.Add(lblTrenutno);
            Controls.Add(lblUkupno);
            Controls.Add(comboBoxVrste);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Statistika";
            Text = "Statistika";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBoxVrste;
        private Label lblUkupno;
        private Label lblTrenutno;
        private Label lblUdomljene;
        private Label lblProsjecnaDob;
        private Label lblVrstaBroj;
        private Button button1;
    }
}