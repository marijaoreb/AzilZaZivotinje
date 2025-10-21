namespace Azil
{
    partial class Udomi
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
            btnudomi = new Button();
            gbprikaz = new GroupBox();
            gbudomitelj = new GroupBox();
            pbživotinje = new PictureBox();
            btnnaprijed = new Button();
            btnnatrag = new Button();
            lbldatumudomljavanja = new Label();
            lblime = new Label();
            lblprezimeudomitelja = new Label();
            lblkontakt = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            tbprezime = new TextBox();
            mtbkontakt = new MaskedTextBox();
            gbudomitelj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbživotinje).BeginInit();
            SuspendLayout();
            // 
            // btnudomi
            // 
            btnudomi.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnudomi.Location = new Point(149, 399);
            btnudomi.Name = "btnudomi";
            btnudomi.Size = new Size(75, 39);
            btnudomi.TabIndex = 0;
            btnudomi.Text = "Udomi";
            btnudomi.UseVisualStyleBackColor = true;
            // 
            // gbprikaz
            // 
            gbprikaz.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            gbprikaz.Location = new Point(12, 12);
            gbprikaz.Name = "gbprikaz";
            gbprikaz.Size = new Size(355, 121);
            gbprikaz.TabIndex = 1;
            gbprikaz.TabStop = false;
            gbprikaz.Text = "Prikaz životinja";
            // 
            // gbudomitelj
            // 
            gbudomitelj.Controls.Add(mtbkontakt);
            gbudomitelj.Controls.Add(tbprezime);
            gbudomitelj.Controls.Add(textBox1);
            gbudomitelj.Controls.Add(dateTimePicker1);
            gbudomitelj.Controls.Add(lblkontakt);
            gbudomitelj.Controls.Add(lblprezimeudomitelja);
            gbudomitelj.Controls.Add(lblime);
            gbudomitelj.Controls.Add(lbldatumudomljavanja);
            gbudomitelj.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            gbudomitelj.Location = new Point(12, 232);
            gbudomitelj.Name = "gbudomitelj";
            gbudomitelj.Size = new Size(355, 161);
            gbudomitelj.TabIndex = 0;
            gbudomitelj.TabStop = false;
            gbudomitelj.Text = "Udomitelj";
            // 
            // pbživotinje
            // 
            pbživotinje.Location = new Point(49, 136);
            pbživotinje.Name = "pbživotinje";
            pbživotinje.Size = new Size(144, 90);
            pbživotinje.TabIndex = 0;
            pbživotinje.TabStop = false;
            // 
            // btnnaprijed
            // 
            btnnaprijed.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnnaprijed.Location = new Point(212, 139);
            btnnaprijed.Name = "btnnaprijed";
            btnnaprijed.Size = new Size(75, 29);
            btnnaprijed.TabIndex = 2;
            btnnaprijed.Text = "Naprijed";
            btnnaprijed.UseVisualStyleBackColor = true;
            // 
            // btnnatrag
            // 
            btnnatrag.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnnatrag.Location = new Point(212, 191);
            btnnatrag.Name = "btnnatrag";
            btnnatrag.Size = new Size(75, 23);
            btnnatrag.TabIndex = 3;
            btnnatrag.Text = "Natrag";
            btnnatrag.UseVisualStyleBackColor = true;
            // 
            // lbldatumudomljavanja
            // 
            lbldatumudomljavanja.AutoSize = true;
            lbldatumudomljavanja.Location = new Point(6, 25);
            lbldatumudomljavanja.Name = "lbldatumudomljavanja";
            lbldatumudomljavanja.Size = new Size(131, 21);
            lbldatumudomljavanja.TabIndex = 4;
            lbldatumudomljavanja.Text = "Datum udomljavnja";
            // 
            // lblime
            // 
            lblime.AutoSize = true;
            lblime.Location = new Point(6, 55);
            lblime.Name = "lblime";
            lblime.Size = new Size(100, 21);
            lblime.TabIndex = 5;
            lblime.Text = "Ime udomitelja";
            // 
            // lblprezimeudomitelja
            // 
            lblprezimeudomitelja.AutoSize = true;
            lblprezimeudomitelja.Location = new Point(6, 85);
            lblprezimeudomitelja.Name = "lblprezimeudomitelja";
            lblprezimeudomitelja.Size = new Size(125, 21);
            lblprezimeudomitelja.TabIndex = 6;
            lblprezimeudomitelja.Text = "Prezime udomitelja";
            // 
            // lblkontakt
            // 
            lblkontakt.AutoSize = true;
            lblkontakt.Location = new Point(6, 123);
            lblkontakt.Name = "lblkontakt";
            lblkontakt.Size = new Size(128, 21);
            lblkontakt.TabIndex = 7;
            lblkontakt.Text = "Kontakt udomitelja";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(149, 25);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 29);
            dateTimePicker1.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(149, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 29);
            textBox1.TabIndex = 9;
            // 
            // tbprezime
            // 
            tbprezime.Location = new Point(149, 95);
            tbprezime.Name = "tbprezime";
            tbprezime.Size = new Size(200, 29);
            tbprezime.TabIndex = 10;
            // 
            // mtbkontakt
            // 
            mtbkontakt.Location = new Point(149, 130);
            mtbkontakt.Name = "mtbkontakt";
            mtbkontakt.Size = new Size(200, 29);
            mtbkontakt.TabIndex = 11;
            // 
            // Udomi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 450);
            Controls.Add(btnnatrag);
            Controls.Add(btnnaprijed);
            Controls.Add(pbživotinje);
            Controls.Add(gbudomitelj);
            Controls.Add(gbprikaz);
            Controls.Add(btnudomi);
            Name = "Udomi";
            Text = "Udomi";
            gbudomitelj.ResumeLayout(false);
            gbudomitelj.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbživotinje).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnudomi;
        private GroupBox gbprikaz;
        private GroupBox gbudomitelj;
        private TextBox tbprezime;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private Label lblkontakt;
        private Label lblprezimeudomitelja;
        private Label lblime;
        private Label lbldatumudomljavanja;
        private PictureBox pbživotinje;
        private Button btnnaprijed;
        private Button btnnatrag;
        private MaskedTextBox mtbkontakt;
    }
}