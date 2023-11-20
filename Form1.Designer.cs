namespace WinFormsApp2
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            contextMenuStrip1 = new ContextMenuStrip(components);
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button11 = new Button();
            button1 = new Button();
            label4 = new Label();
            button2 = new Button();
            button6 = new Button();
            button3 = new Button();
            button7 = new Button();
            button5 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(279, 9);
            label1.Name = "label1";
            label1.Size = new Size(372, 42);
            label1.TabIndex = 0;
            label1.Text = "Library management systems";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(254, 77);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(503, 44);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(145, 90);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 2;
            label2.Text = "Nhập từ khóa";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(254, 140);
            label3.Name = "label3";
            label3.Size = new Size(138, 20);
            label3.TabIndex = 3;
            label3.Text = "Tìm kiếm nâng cao";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Tên tác giả", "Thể loại sách", "Năm sản xuất", "Tất cả" });
            comboBox1.Location = new Point(409, 138);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(187, 28);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(117, 270);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(153, 193);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(399, 270);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(153, 193);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(674, 270);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(153, 193);
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // button8
            // 
            button8.BackColor = Color.Turquoise;
            button8.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(117, 589);
            button8.Name = "button8";
            button8.Size = new Size(153, 29);
            button8.TabIndex = 16;
            button8.Text = "Mượn sách";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.Turquoise;
            button9.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(399, 589);
            button9.Name = "button9";
            button9.Size = new Size(153, 29);
            button9.TabIndex = 17;
            button9.Text = "Mượn sách";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.Turquoise;
            button10.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button10.Location = new Point(674, 589);
            button10.Name = "button10";
            button10.Size = new Size(153, 29);
            button10.TabIndex = 18;
            button10.Text = "Mượn sách";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(163, 486);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 19;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(442, 486);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 20;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(719, 486);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 21;
            label7.Text = "label7";
            // 
            // button11
            // 
            button11.BackColor = Color.Pink;
            button11.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button11.Location = new Point(423, 647);
            button11.Name = "button11";
            button11.Size = new Size(103, 29);
            button11.TabIndex = 22;
            button11.Text = "Xem thêm";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Turquoise;
            button1.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(644, 85);
            button1.Name = "button1";
            button1.Size = new Size(103, 29);
            button1.TabIndex = 4;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.BackColor = Color.Turquoise;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(409, 210);
            label4.Name = "label4";
            label4.Size = new Size(108, 30);
            label4.TabIndex = 6;
            label4.Text = "      Gợi ý";
            label4.Click += label4_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Turquoise;
            button2.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(117, 519);
            button2.Name = "button2";
            button2.Size = new Size(153, 29);
            button2.TabIndex = 10;
            button2.Text = "Tổng quan";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button6
            // 
            button6.BackColor = Color.Turquoise;
            button6.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(674, 519);
            button6.Name = "button6";
            button6.Size = new Size(153, 29);
            button6.TabIndex = 14;
            button6.Text = "Tổng quan";
            button6.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Turquoise;
            button3.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(117, 554);
            button3.Name = "button3";
            button3.Size = new Size(153, 29);
            button3.TabIndex = 11;
            button3.Text = "Xem chi tiết";
            button3.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.Turquoise;
            button7.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(399, 519);
            button7.Name = "button7";
            button7.Size = new Size(153, 29);
            button7.TabIndex = 15;
            button7.Text = "Tổng quan";
            button7.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Turquoise;
            button5.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(399, 554);
            button5.Name = "button5";
            button5.Size = new Size(153, 29);
            button5.TabIndex = 13;
            button5.Text = "Xem chi tiết";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Turquoise;
            button4.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(674, 554);
            button4.Name = "button4";
            button4.Size = new Size(153, 29);
            button4.TabIndex = 12;
            button4.Text = "Xem chi tiết";
            button4.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(919, 688);
            Controls.Add(button11);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Library management systems";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ContextMenuStrip contextMenuStrip1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button button8;
        private Button button9;
        private Button button10;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button11;
        private Button button1;
        private Label label4;
        private Button button2;
        private Button button6;
        private Button button3;
        private Button button7;
        private Button button5;
        private Button button4;
    }
}