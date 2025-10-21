namespace Azil
{
    partial class Filtriranje
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
            lsbFiltriranje = new ListBox();
            pbFiltriranje = new PictureBox();
            label1 = new Label();
            tbfiltriranje = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbFiltriranje).BeginInit();
            SuspendLayout();
            // 
            // lsbFiltriranje
            // 
            lsbFiltriranje.FormattingEnabled = true;
            lsbFiltriranje.ItemHeight = 15;
            lsbFiltriranje.Location = new Point(88, 63);
            lsbFiltriranje.Name = "lsbFiltriranje";
            lsbFiltriranje.Size = new Size(159, 94);
            lsbFiltriranje.TabIndex = 0;
            // 
            // pbFiltriranje
            // 
            pbFiltriranje.Location = new Point(88, 178);
            pbFiltriranje.Name = "pbFiltriranje";
            pbFiltriranje.Size = new Size(159, 111);
            pbFiltriranje.TabIndex = 1;
            pbFiltriranje.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(129, 22);
            label1.Name = "label1";
            label1.Size = new Size(69, 21);
            label1.TabIndex = 2;
            label1.Text = "Filtriranje";
            // 
            // tbfiltriranje
            // 
            tbfiltriranje.Location = new Point(88, 325);
            tbfiltriranje.Name = "tbfiltriranje";
            tbfiltriranje.Size = new Size(100, 23);
            tbfiltriranje.TabIndex = 3;
            // 
            // frmFiltriranje
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 450);
            Controls.Add(tbfiltriranje);
            Controls.Add(label1);
            Controls.Add(pbFiltriranje);
            Controls.Add(lsbFiltriranje);
            Name = "frmFiltriranje";
            Text = "frmFiltriranje";
            ((System.ComponentModel.ISupportInitialize)pbFiltriranje).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lsbFiltriranje;
        private PictureBox pbFiltriranje;
        private Label label1;
        private TextBox tbfiltriranje;
    }
}