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
            btnnatrag = new Button();
            pictureBox1 = new PictureBox();
            btnnaprijed = new Button();
            gbudomitelj = new GroupBox();
            textBoxKontakt = new MaskedTextBox();
            textBoxPrezime = new TextBox();
            textBoxIme = new TextBox();
            dateTimePickerUdomljavanje = new DateTimePicker();
            lblkontakt = new Label();
            lblprezimeudomitelja = new Label();
            lblime = new Label();
            lbldatumudomljavanja = new Label();
            button1 = new Button();
            gbprikaz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gbudomitelj.SuspendLayout();
            SuspendLayout();
            // 
            // btnudomi
            // 
            btnudomi.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnudomi.Location = new Point(150, 432);
            btnudomi.Name = "btnudomi";
            btnudomi.Size = new Size(75, 39);
            btnudomi.TabIndex = 0;
            btnudomi.Text = "Udomi";
            btnudomi.UseVisualStyleBackColor = true;
            btnudomi.Click += btnudomi_Click;
            // 
            // gbprikaz
            // 
            gbprikaz.Controls.Add(btnnatrag);
            gbprikaz.Controls.Add(pictureBox1);
            gbprikaz.Controls.Add(btnnaprijed);
            gbprikaz.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            gbprikaz.Location = new Point(12, 12);
            gbprikaz.Name = "gbprikaz";
            gbprikaz.Size = new Size(355, 199);
            gbprikaz.TabIndex = 1;
            gbprikaz.TabStop = false;
            gbprikaz.Text = "Prikaz životinja";
            // 
            // btnnatrag
            // 
            btnnatrag.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnnatrag.Location = new Point(200, 95);
            btnnatrag.Name = "btnnatrag";
            btnnatrag.Size = new Size(75, 34);
            btnnatrag.TabIndex = 3;
            btnnatrag.Text = "Natrag";
            btnnatrag.UseVisualStyleBackColor = true;
            btnnatrag.Click += btnnatrag_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(18, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(144, 150);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnnaprijed
            // 
            btnnaprijed.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnnaprijed.Location = new Point(200, 28);
            btnnaprijed.Name = "btnnaprijed";
            btnnaprijed.Size = new Size(75, 35);
            btnnaprijed.TabIndex = 2;
            btnnaprijed.Text = "Naprijed";
            btnnaprijed.UseVisualStyleBackColor = true;
            btnnaprijed.Click += btnnaprijed_Click;
            // 
            // gbudomitelj
            // 
            gbudomitelj.Controls.Add(textBoxKontakt);
            gbudomitelj.Controls.Add(textBoxPrezime);
            gbudomitelj.Controls.Add(textBoxIme);
            gbudomitelj.Controls.Add(dateTimePickerUdomljavanje);
            gbudomitelj.Controls.Add(lblkontakt);
            gbudomitelj.Controls.Add(lblprezimeudomitelja);
            gbudomitelj.Controls.Add(lblime);
            gbudomitelj.Controls.Add(lbldatumudomljavanja);
            gbudomitelj.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            gbudomitelj.Location = new Point(12, 232);
            gbudomitelj.Name = "gbudomitelj";
            gbudomitelj.Size = new Size(355, 177);
            gbudomitelj.TabIndex = 0;
            gbudomitelj.TabStop = false;
            gbudomitelj.Text = "Udomitelj";
            // 
            // textBoxKontakt
            // 
            textBoxKontakt.Location = new Point(149, 130);
            textBoxKontakt.Name = "textBoxKontakt";
            textBoxKontakt.Size = new Size(200, 29);
            textBoxKontakt.TabIndex = 11;
            // 
            // textBoxPrezime
            // 
            textBoxPrezime.Location = new Point(149, 95);
            textBoxPrezime.Name = "textBoxPrezime";
            textBoxPrezime.Size = new Size(200, 29);
            textBoxPrezime.TabIndex = 10;
            // 
            // textBoxIme
            // 
            textBoxIme.Location = new Point(149, 60);
            textBoxIme.Name = "textBoxIme";
            textBoxIme.Size = new Size(200, 29);
            textBoxIme.TabIndex = 9;
            // 
            // dateTimePickerUdomljavanje
            // 
            dateTimePickerUdomljavanje.Location = new Point(149, 25);
            dateTimePickerUdomljavanje.Name = "dateTimePickerUdomljavanje";
            dateTimePickerUdomljavanje.Size = new Size(200, 29);
            dateTimePickerUdomljavanje.TabIndex = 8;
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
            // lblprezimeudomitelja
            // 
            lblprezimeudomitelja.AutoSize = true;
            lblprezimeudomitelja.Location = new Point(6, 85);
            lblprezimeudomitelja.Name = "lblprezimeudomitelja";
            lblprezimeudomitelja.Size = new Size(125, 21);
            lblprezimeudomitelja.TabIndex = 6;
            lblprezimeudomitelja.Text = "Prezime udomitelja";
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
            // lbldatumudomljavanja
            // 
            lbldatumudomljavanja.AutoSize = true;
            lbldatumudomljavanja.Location = new Point(6, 25);
            lbldatumudomljavanja.Name = "lbldatumudomljavanja";
            lbldatumudomljavanja.Size = new Size(131, 21);
            lbldatumudomljavanja.TabIndex = 4;
            lbldatumudomljavanja.Text = "Datum udomljavnja";
            // 
            // button1
            // 
            button1.Location = new Point(12, 432);
            button1.Name = "button1";
            button1.Size = new Size(75, 39);
            button1.TabIndex = 12;
            button1.Text = "Nazad";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Udomi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 483);
            Controls.Add(button1);
            Controls.Add(gbudomitelj);
            Controls.Add(gbprikaz);
            Controls.Add(btnudomi);
            Name = "Udomi";
            Text = "Udomi";
            gbprikaz.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gbudomitelj.ResumeLayout(false);
            gbudomitelj.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnudomi;
        private GroupBox gbprikaz;
        private GroupBox gbudomitelj;
        private TextBox textBoxPrezime;
        private TextBox textBoxIme;
        private DateTimePicker dateTimePickerUdomljavanje;
        private Label lblkontakt;
        private Label lblprezimeudomitelja;
        private Label lblime;
        private Label lbldatumudomljavanja;
        private PictureBox pictureBox1;
        private Button btnnaprijed;
        private Button btnnatrag;
        private MaskedTextBox textBoxKontakt;
        private Button button1;
    }
}