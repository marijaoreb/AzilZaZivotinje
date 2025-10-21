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
            btnUnos = new Button();
            SuspendLayout();
            // 
            // btnPregled
            // 
            btnPregled.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnPregled.Location = new Point(61, 106);
            btnPregled.Name = "btnPregled";
            btnPregled.Size = new Size(244, 54);
            btnPregled.TabIndex = 1;
            btnPregled.Text = "Pregled životinja";
            btnPregled.UseVisualStyleBackColor = true;
            btnPregled.Click += btnPregled_Click;
            // 
            // btnFiltriranje
            // 
            btnFiltriranje.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
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
            btnUdomljavanje.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnUdomljavanje.Location = new Point(61, 226);
            btnUdomljavanje.Name = "btnUdomljavanje";
            btnUdomljavanje.Size = new Size(244, 54);
            btnUdomljavanje.TabIndex = 3;
            btnUdomljavanje.Text = "Udomljavanje";
            btnUdomljavanje.UseVisualStyleBackColor = true;
            // 
            // btnStatistika
            // 
            btnStatistika.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
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
            btnIzlaz.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnIzlaz.Location = new Point(61, 346);
            btnIzlaz.Name = "btnIzlaz";
            btnIzlaz.Size = new Size(244, 54);
            btnIzlaz.TabIndex = 5;
            btnIzlaz.Text = "Izlaz";
            btnIzlaz.UseVisualStyleBackColor = true;
            btnIzlaz.Click += button6_Click;
            // 
            // btnUnos
            // 
            btnUnos.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnUnos.Location = new Point(61, 46);
            btnUnos.Name = "btnUnos";
            btnUnos.Size = new Size(244, 54);
            btnUnos.TabIndex = 6;
            btnUnos.Text = "Unos životinje";
            btnUnos.UseVisualStyleBackColor = true;
            btnUnos.Click += button1_Click;
            // 
            // Pocetna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(379, 450);
            Controls.Add(btnUnos);
            Controls.Add(btnIzlaz);
            Controls.Add(btnStatistika);
            Controls.Add(btnUdomljavanje);
            Controls.Add(btnFiltriranje);
            Controls.Add(btnPregled);
            Name = "Pocetna";
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
        private Button btnUnos;
    }
}
