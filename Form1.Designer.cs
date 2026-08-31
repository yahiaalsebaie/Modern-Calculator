namespace Modern_Calculator
{
    partial class Form1
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
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.btnMinmize = new System.Windows.Forms.Button();
            this.btnMaxmize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlHistory = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnClearHistory = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pnlTitle.SuspendLayout();
            this.pnlHistory.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.btnMinmize);
            this.pnlTitle.Controls.Add(this.btnMaxmize);
            this.pnlTitle.Controls.Add(this.btnClose);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(350, 40);
            this.pnlTitle.TabIndex = 0;
            this.pnlTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseDown);
            this.pnlTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseMove);
            // 
            // btnMinmize
            // 
            this.btnMinmize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinmize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinmize.FlatAppearance.BorderSize = 0;
            this.btnMinmize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnMinmize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinmize.Font = new System.Drawing.Font("NSimSun", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinmize.Image = global::Modern_Calculator.Properties.Resources.Horizontal_Line;
            this.btnMinmize.Location = new System.Drawing.Point(239, 0);
            this.btnMinmize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinmize.Name = "btnMinmize";
            this.btnMinmize.Size = new System.Drawing.Size(37, 40);
            this.btnMinmize.TabIndex = 0;
            this.btnMinmize.UseVisualStyleBackColor = false;
            // 
            // btnMaxmize
            // 
            this.btnMaxmize.BackColor = System.Drawing.Color.Transparent;
            this.btnMaxmize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaxmize.FlatAppearance.BorderSize = 0;
            this.btnMaxmize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnMaxmize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxmize.Font = new System.Drawing.Font("NSimSun", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaxmize.Image = global::Modern_Calculator.Properties.Resources.Rounded_Square;
            this.btnMaxmize.Location = new System.Drawing.Point(276, 0);
            this.btnMaxmize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMaxmize.Name = "btnMaxmize";
            this.btnMaxmize.Size = new System.Drawing.Size(37, 40);
            this.btnMaxmize.TabIndex = 0;
            this.btnMaxmize.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("NSimSun", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::Modern_Calculator.Properties.Resources.Close;
            this.btnClose.Location = new System.Drawing.Point(313, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 40);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlHistory
            // 
            this.pnlHistory.Controls.Add(this.richTextBox1);
            this.pnlHistory.Controls.Add(this.btnClearHistory);
            this.pnlHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlHistory.Location = new System.Drawing.Point(0, 495);
            this.pnlHistory.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHistory.Name = "pnlHistory";
            this.pnlHistory.Size = new System.Drawing.Size(350, 5);
            this.pnlHistory.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.ForeColor = System.Drawing.Color.DarkGray;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.richTextBox1.Size = new System.Drawing.Size(350, 0);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // btnClearHistory
            // 
            this.btnClearHistory.BackColor = System.Drawing.Color.Transparent;
            this.btnClearHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClearHistory.FlatAppearance.BorderSize = 0;
            this.btnClearHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnClearHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearHistory.Font = new System.Drawing.Font("NSimSun", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearHistory.Image = global::Modern_Calculator.Properties.Resources.Delete;
            this.btnClearHistory.Location = new System.Drawing.Point(0, -49);
            this.btnClearHistory.Margin = new System.Windows.Forms.Padding(0);
            this.btnClearHistory.Name = "btnClearHistory";
            this.btnClearHistory.Size = new System.Drawing.Size(350, 54);
            this.btnClearHistory.TabIndex = 1;
            this.btnClearHistory.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnMenu);
            this.panel3.Controls.Add(this.btnHistory);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 40);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 46);
            this.panel3.TabIndex = 2;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("NSimSun", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Image = global::Modern_Calculator.Properties.Resources.Menu;
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(35, 46);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.UseVisualStyleBackColor = false;
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.Transparent;
            this.btnHistory.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("NSimSun", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.Image = global::Modern_Calculator.Properties.Resources.Time_Machine;
            this.btnHistory.Location = new System.Drawing.Point(315, 0);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(0);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(35, 46);
            this.btnHistory.TabIndex = 0;
            this.btnHistory.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Font = new System.Drawing.Font("Myanmar Text", 30.8F, System.Drawing.FontStyle.Bold);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(0, 119);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(350, 62);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "0";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox2.Font = new System.Drawing.Font("Myanmar Text", 12.8F, System.Drawing.FontStyle.Bold);
            this.textBox2.ForeColor = System.Drawing.Color.DarkGray;
            this.textBox2.Location = new System.Drawing.Point(0, 86);
            this.textBox2.Margin = new System.Windows.Forms.Padding(0);
            this.textBox2.Name = "textBox2";
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox2.Size = new System.Drawing.Size(350, 33);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(350, 500);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlHistory);
            this.Controls.Add(this.pnlTitle);
            this.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlTitle.ResumeLayout(false);
            this.pnlHistory.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlHistory;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMaxmize;
        private System.Windows.Forms.Button btnMinmize;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnClearHistory;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

