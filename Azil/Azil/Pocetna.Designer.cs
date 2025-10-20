namespace Azil
{
    partial class Pocetna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pocetna));
            btnPregled = new Button();
            btnFiltriranje = new Button();
            btnUdomljavanje = new Button();
            btnStatistika = new Button();
            btnIzlaz = new Button();
            bntUnos = new Button();
            SuspendLayout();
            // 
            // btnPregled
            // 
            btnPregled.Location = new Point(61, 106);
            btnPregled.Name = "btnPregled";
            btnPregled.Size = new Size(244, 54);
            btnPregled.TabIndex = 1;
            btnPregled.Text = "Pregled";
            btnPregled.UseVisualStyleBackColor = true;
            // 
            // btnFiltriranje
            // 
            btnFiltriranje.Location = new Point(61, 166);
            btnFiltriranje.Name = "btnFiltriranje";
            btnFiltriranje.Size = new Size(244, 54);
            btnFiltriranje.TabIndex = 2;
            btnFiltriranje.Text = "Filtriranje";
            btnFiltriranje.UseVisualStyleBackColor = true;
            btnFiltriranje.Click += button3_Click;
            // 
            // btnUdomljavanje
            // 
            btnUdomljavanje.Location = new Point(61, 226);
            btnUdomljavanje.Name = "btnUdomljavanje";
            btnUdomljavanje.Size = new Size(244, 54);
            btnUdomljavanje.TabIndex = 3;
            btnUdomljavanje.Text = "Udomljavanje";
            btnUdomljavanje.UseVisualStyleBackColor = true;
            // 
            // btnStatistika
            // 
            btnStatistika.Location = new Point(61, 286);
            btnStatistika.Name = "btnStatistika";
            btnStatistika.Size = new Size(244, 54);
            btnStatistika.TabIndex = 4;
            btnStatistika.Text = "Statistika";
            btnStatistika.UseVisualStyleBackColor = true;
            btnStatistika.Click += button5_Click;
            // 
            // btnIzlaz
            // 
            btnIzlaz.Location = new Point(61, 346);
            btnIzlaz.Name = "btnIzlaz";
            btnIzlaz.Size = new Size(244, 54);
            btnIzlaz.TabIndex = 5;
            btnIzlaz.Text = "Izlaz";
            btnIzlaz.UseVisualStyleBackColor = true;
            btnIzlaz.Click += button6_Click;
            // 
            // bntUnos
            // 
            bntUnos.Location = new Point(61, 46);
            bntUnos.Name = "bntUnos";
            bntUnos.Size = new Size(244, 54);
            bntUnos.TabIndex = 6;
            bntUnos.Text = "Unos životinje";
            bntUnos.UseVisualStyleBackColor = true;
            bntUnos.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(379, 450);
            Controls.Add(bntUnos);
            Controls.Add(btnIzlaz);
            Controls.Add(btnStatistika);
            Controls.Add(btnUdomljavanje);
            Controls.Add(btnFiltriranje);
            Controls.Add(btnPregled);
            Name = "Form1";
            Text = "Azil za životinje";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button btnPregled;
        private Button btnFiltriranje;
        private Button btnUdomljavanje;
        private Button btnStatistika;
        private Button btnIzlaz;
        private Button bntUnos;
    }
}
