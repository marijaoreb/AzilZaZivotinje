namespace Azil
{
    partial class PregledZivotinja
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
            pictureBox1 = new PictureBox();
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(191, 29);
            label1.Name = "label1";
            label1.Size = new Size(110, 21);
            label1.TabIndex = 0;
            label1.Text = "Pregled životinja";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(130, 116);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(232, 169);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(130, 64);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(232, 34);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(130, 291);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(232, 221);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button1.Location = new Point(386, 319);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Uredi ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button2.Location = new Point(386, 366);
            button2.Name = "button2";
            button2.Size = new Size(75, 29);
            button2.TabIndex = 5;
            button2.Text = "Brisanje";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button3.Location = new Point(386, 421);
            button3.Name = "button3";
            button3.Size = new Size(75, 29);
            button3.TabIndex = 6;
            button3.Text = "Nazad";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // PregledZivotinja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 530);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "PregledZivotinja";
            Text = "PregledZivotinja";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private ListBox listBox1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}