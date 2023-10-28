namespace CurrencyConverter
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
            ConvertBtn = new Button();
            label1 = new Label();
            FromCurr = new ComboBox();
            ToCurr = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            AmountToConvert = new TextBox();
            RateDisplay = new Label();
            AmountDisplay = new Label();
            SuspendLayout();
            // 
            // ConvertBtn
            // 
            ConvertBtn.Font = new Font("Stencil", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ConvertBtn.Location = new Point(311, 651);
            ConvertBtn.Margin = new Padding(6);
            ConvertBtn.Name = "ConvertBtn";
            ConvertBtn.Size = new Size(150, 50);
            ConvertBtn.TabIndex = 0;
            ConvertBtn.Text = " Convert";
            ConvertBtn.UseVisualStyleBackColor = true;
            ConvertBtn.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(232, 47);
            label1.Name = "label1";
            label1.Size = new Size(348, 35);
            label1.TabIndex = 1;
            label1.Text = "Currency Converter";
            label1.Click += label1_Click;
            // 
            // FromCurr
            // 
            FromCurr.FormattingEnabled = true;
            FromCurr.Items.AddRange(new object[] { "USD", "EUR", "INR", "GBP" });
            FromCurr.Location = new Point(294, 475);
            FromCurr.Name = "FromCurr";
            FromCurr.Size = new Size(182, 33);
            FromCurr.TabIndex = 2;
            FromCurr.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // ToCurr
            // 
            ToCurr.FormattingEnabled = true;
            ToCurr.Items.AddRange(new object[] { "USD", "EUR", "INR", "GBP" });
            ToCurr.Location = new Point(294, 578);
            ToCurr.Name = "ToCurr";
            ToCurr.Size = new Size(182, 33);
            ToCurr.TabIndex = 3;
            ToCurr.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(285, 425);
            label2.Name = "label2";
            label2.Size = new Size(206, 29);
            label2.TabIndex = 4;
            label2.Text = "From Currency";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(306, 532);
            label3.Name = "label3";
            label3.Size = new Size(170, 29);
            label3.TabIndex = 5;
            label3.Text = "To Currency";
            label3.TextAlign = ContentAlignment.TopCenter;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(262, 313);
            label4.Name = "label4";
            label4.Size = new Size(253, 29);
            label4.TabIndex = 7;
            label4.Text = "Amount to convert";
            label4.TextAlign = ContentAlignment.TopCenter;
            label4.Click += label4_Click;
            // 
            // AmountToConvert
            // 
            AmountToConvert.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            AmountToConvert.Location = new Point(294, 362);
            AmountToConvert.Name = "AmountToConvert";
            AmountToConvert.Size = new Size(182, 26);
            AmountToConvert.TabIndex = 8;
            // 
            // RateDisplay
            // 
            RateDisplay.AutoSize = true;
            RateDisplay.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RateDisplay.Location = new Point(223, 152);
            RateDisplay.Name = "RateDisplay";
            RateDisplay.Size = new Size(330, 29);
            RateDisplay.TabIndex = 9;
            RateDisplay.Text = "Conversion Rate: 1$ = ???";
            RateDisplay.TextAlign = ContentAlignment.TopCenter;
            // 
            // AmountDisplay
            // 
            AmountDisplay.AutoSize = true;
            AmountDisplay.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AmountDisplay.Location = new Point(223, 220);
            AmountDisplay.Name = "AmountDisplay";
            AmountDisplay.Size = new Size(355, 29);
            AmountDisplay.TabIndex = 10;
            AmountDisplay.Text = "Converted Amount: 1$ = ???";
            AmountDisplay.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 737);
            Controls.Add(AmountDisplay);
            Controls.Add(RateDisplay);
            Controls.Add(AmountToConvert);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ToCurr);
            Controls.Add(FromCurr);
            Controls.Add(label1);
            Controls.Add(ConvertBtn);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ConvertBtn;
        private Label label1;
        private ComboBox FromCurr;
        private ComboBox ToCurr;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox AmountToConvert;
        private Label RateDisplay;
        private Label AmountDisplay;
    }
}