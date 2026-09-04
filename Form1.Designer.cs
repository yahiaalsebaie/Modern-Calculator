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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMinmize = new System.Windows.Forms.Button();
            this.btnMaxmize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlHistory = new System.Windows.Forms.Panel();
            this.rtbHistory = new System.Windows.Forms.RichTextBox();
            this.btnClearHistory = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnPlusMinus = new ctrlRoundedButton();
            this.btnNum2 = new ctrlRoundedButton();
            this.btnNum1 = new ctrlRoundedButton();
            this.btnNum4 = new ctrlRoundedButton();
            this.btnNum7 = new ctrlRoundedButton();
            this.btn1X = new ctrlRoundedButton();
            this.btnNum0 = new ctrlRoundedButton();
            this.btnNum5 = new ctrlRoundedButton();
            this.btnNum8 = new ctrlRoundedButton();
            this.btnPercent = new ctrlRoundedButton();
            this.btnX2 = new ctrlRoundedButton();
            this.ctrlRoundedButton24 = new ctrlRoundedButton();
            this.btnNum6 = new ctrlRoundedButton();
            this.btnNum3 = new ctrlRoundedButton();
            this.btnNum9 = new ctrlRoundedButton();
            this.btnCE = new ctrlRoundedButton();
            this.btnSquare = new ctrlRoundedButton();
            this.btnC = new ctrlRoundedButton();
            this.btnEqual = new ctrlRoundedButton();
            this.btnSubtract = new ctrlRoundedButton();
            this.btnAdd = new ctrlRoundedButton();
            this.btnMultiply = new ctrlRoundedButton();
            this.btnDivition = new ctrlRoundedButton();
            this.btnBackSpace = new ctrlRoundedButton();
            this.ctrlRoundedButton6 = new ctrlRoundedButton();
            this.ctrlRoundedButton5 = new ctrlRoundedButton();
            this.ctrlRoundedButton4 = new ctrlRoundedButton();
            this.ctrlRoundedButton3 = new ctrlRoundedButton();
            this.ctrlRoundedButton2 = new ctrlRoundedButton();
            this.ctrlRoundedButton1 = new ctrlRoundedButton();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlHistory.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.label1);
            this.pnlTitle.Controls.Add(this.pictureBox1);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 15.8F);
            this.label1.Location = new System.Drawing.Point(35, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Calculator";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 40);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnMinmize
            // 
            this.btnMinmize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinmize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinmize.FlatAppearance.BorderSize = 0;
            this.btnMinmize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnMinmize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinmize.Font = new System.Drawing.Font("NSimSun", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinmize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinmize.Image")));
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
            this.btnMaxmize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaxmize.Image")));
            this.btnMaxmize.Location = new System.Drawing.Point(276, 0);
            this.btnMaxmize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMaxmize.Name = "btnMaxmize";
            this.btnMaxmize.Size = new System.Drawing.Size(37, 40);
            this.btnMaxmize.TabIndex = 0;
            this.btnMaxmize.UseVisualStyleBackColor = false;
            this.btnMaxmize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("NSimSun", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
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
            this.pnlHistory.Controls.Add(this.rtbHistory);
            this.pnlHistory.Controls.Add(this.btnClearHistory);
            this.pnlHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlHistory.Location = new System.Drawing.Point(0, 590);
            this.pnlHistory.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHistory.Name = "pnlHistory";
            this.pnlHistory.Size = new System.Drawing.Size(350, 5);
            this.pnlHistory.TabIndex = 1;
            // 
            // rtbHistory
            // 
            this.rtbHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.rtbHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbHistory.ForeColor = System.Drawing.Color.DarkGray;
            this.rtbHistory.Location = new System.Drawing.Point(0, 0);
            this.rtbHistory.Margin = new System.Windows.Forms.Padding(0);
            this.rtbHistory.Name = "rtbHistory";
            this.rtbHistory.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.rtbHistory.Size = new System.Drawing.Size(350, 0);
            this.rtbHistory.TabIndex = 2;
            this.rtbHistory.Text = "";
            // 
            // btnClearHistory
            // 
            this.btnClearHistory.BackColor = System.Drawing.Color.Transparent;
            this.btnClearHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClearHistory.FlatAppearance.BorderSize = 0;
            this.btnClearHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnClearHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearHistory.Font = new System.Drawing.Font("NSimSun", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnClearHistory.Image")));
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
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
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
            this.btnHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnHistory.Image")));
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
            this.textBox1.Font = new System.Drawing.Font("Myanmar Text", 24.25F, System.Drawing.FontStyle.Bold);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(0, 119);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(350, 62);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(350, 33);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnPlusMinus
            // 
            this.btnPlusMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btnPlusMinus.BorderRadius = 15;
            this.btnPlusMinus.FlatAppearance.BorderSize = 0;
            this.btnPlusMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlusMinus.Location = new System.Drawing.Point(2, 525);
            this.btnPlusMinus.Name = "btnPlusMinus";
            this.btnPlusMinus.Size = new System.Drawing.Size(85, 55);
            this.btnPlusMinus.TabIndex = 5;
            this.btnPlusMinus.Tag = "±";
            this.btnPlusMinus.Text = "±";
            this.btnPlusMinus.UseVisualStyleBackColor = false;
            this.btnPlusMinus.Click += new System.EventHandler(this.UnaryOperations_Click);
            // 
            // btnNum2
            // 
            this.btnNum2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btnNum2.BorderRadius = 15;
            this.btnNum2.FlatAppearance.BorderSize = 0;
            this.btnNum2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum2.Location = new System.Drawing.Point(89, 465);
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.Size = new System.Drawing.Size(85, 55);
            this.btnNum2.TabIndex = 5;
            this.btnNum2.Tag = "2";
            this.btnNum2.Text = "2";
            this.btnNum2.UseVisualStyleBackColor = false;
            this.btnNum2.Click += new System.EventHandler(this.Num_Click);
            // 
            // btnNum1
            // 
            this.btnNum1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btnNum1.BorderRadius = 15;
            this.btnNum1.FlatAppearance.BorderSize = 0;
            this.btnNum1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum1.Location = new System.Drawing.Point(2, 465);
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.Size = new System.Drawing.Size(85, 55);
            this.btnNum1.TabIndex = 5;
            this.btnNum1.Tag = "1";
            this.btnNum1.Text = "1";
            this.btnNum1.UseVisualStyleBackColor = false;
            this.btnNum1.Click += new System.EventHandler(this.Num_Click);
            // 
            // btnNum4
            // 
            this.btnNum4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btnNum4.BorderRadius = 15;
            this.btnNum4.FlatAppearance.BorderSize = 0;
            this.btnNum4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum4.Location = new System.Drawing.Point(2, 405);
            this.btnNum4.Name = "btnNum4";
            this.btnNum4.Size = new System.Drawing.Size(85, 55);
            this.btnNum4.TabIndex = 5;
            this.btnNum4.Tag = "4";
            this.btnNum4.Text = "4";
            this.btnNum4.UseVisualStyleBackColor = false;
            this.btnNum4.Click += new System.EventHandler(this.Num_Click);
            // 
            // btnNum7
            // 
            this.btnNum7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btnNum7.BorderRadius = 15;
            this.btnNum7.FlatAppearance.BorderSize = 0;
            this.btnNum7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum7.Location = new System.Drawing.Point(2, 345);
            this.btnNum7.Name = "btnNum7";
            this.btnNum7.Size = new System.Drawing.Size(85, 55);
            this.btnNum7.TabIndex = 5;
            this.btnNum7.Tag = "7";
            this.btnNum7.Text = "7";
            this.btnNum7.UseVisualStyleBackColor = false;
            this.btnNum7.Click += new System.EventHandler(this.Num_Click);
            // 
            // btn1X
            // 
            this.btn1X.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn1X.BorderRadius = 15;
            this.btn1X.FlatAppearance.BorderSize = 0;
            this.btn1X.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1X.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1X.Location = new System.Drawing.Point(2, 285);
            this.btn1X.Name = "btn1X";
            this.btn1X.Size = new System.Drawing.Size(85, 55);
            this.btn1X.TabIndex = 5;
            this.btn1X.Tag = "⅟x";
            this.btn1X.Text = "⅟x";
            this.btn1X.UseVisualStyleBackColor = false;
            this.btn1X.Click += new System.EventHandler(this.UnaryOperations_Click);
            // 
            // btnNum0
            // 
            this.btnNum0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btnNum0.BorderRadius = 15;
            this.btnNum0.FlatAppearance.BorderSize = 0;
            this.btnNum0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum0.Location = new System.Drawing.Point(89, 525);
            this.btnNum0.Name = "btnNum0";
            this.btnNum0.Size = new System.Drawing.Size(85, 55);
            this.btnNum0.TabIndex = 5;
            this.btnNum0.Tag = "0";
            this.btnNum0.Text = "0";
            this.btnNum0.UseVisualStyleBackColor = false;
            this.btnNum0.Click += new System.EventHandler(this.Num_Click);
            // 
            // btnNum5
            // 
            this.btnNum5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btnNum5.BorderRadius = 15;
            this.btnNum5.FlatAppearance.BorderSize = 0;
            this.btnNum5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum5.Location = new System.Drawing.Point(89, 405);
            this.btnNum5.Name = "btnNum5";
            this.btnNum5.Size = new System.Drawing.Size(85, 55);
            this.btnNum5.TabIndex = 5;
            this.btnNum5.Tag = "5";
            this.btnNum5.Text = "5";
            this.btnNum5.UseVisualStyleBackColor = false;
            this.btnNum5.Click += new System.EventHandler(this.Num_Click);
            // 
            // btnNum8
            // 
            this.btnNum8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btnNum8.BorderRadius = 15;
            this.btnNum8.FlatAppearance.BorderSize = 0;
            this.btnNum8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum8.Location = new System.Drawing.Point(89, 345);
            this.btnNum8.Name = "btnNum8";
            this.btnNum8.Size = new System.Drawing.Size(85, 55);
            this.btnNum8.TabIndex = 5;
            this.btnNum8.Tag = "8";
            this.btnNum8.Text = "8";
            this.btnNum8.UseVisualStyleBackColor = false;
            this.btnNum8.Click += new System.EventHandler(this.Num_Click);
            // 
            // btnPercent
            // 
            this.btnPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnPercent.BorderRadius = 15;
            this.btnPercent.FlatAppearance.BorderSize = 0;
            this.btnPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPercent.Location = new System.Drawing.Point(2, 225);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(85, 55);
            this.btnPercent.TabIndex = 5;
            this.btnPercent.Tag = "%";
            this.btnPercent.Text = "%";
            this.btnPercent.UseVisualStyleBackColor = false;
            this.btnPercent.Click += new System.EventHandler(this.UnaryOperations_Click);
            // 
            // btnX2
            // 
            this.btnX2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnX2.BorderRadius = 15;
            this.btnX2.FlatAppearance.BorderSize = 0;
            this.btnX2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX2.Location = new System.Drawing.Point(89, 285);
            this.btnX2.Name = "btnX2";
            this.btnX2.Size = new System.Drawing.Size(85, 55);
            this.btnX2.TabIndex = 5;
            this.btnX2.Tag = "x²";
            this.btnX2.Text = "x²";
            this.btnX2.UseVisualStyleBackColor = false;
            this.btnX2.Click += new System.EventHandler(this.UnaryOperations_Click);
            // 
            // ctrlRoundedButton24
            // 
            this.ctrlRoundedButton24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ctrlRoundedButton24.BorderRadius = 15;
            this.ctrlRoundedButton24.FlatAppearance.BorderSize = 0;
            this.ctrlRoundedButton24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ctrlRoundedButton24.Location = new System.Drawing.Point(176, 525);
            this.ctrlRoundedButton24.Name = "ctrlRoundedButton24";
            this.ctrlRoundedButton24.Size = new System.Drawing.Size(85, 55);
            this.ctrlRoundedButton24.TabIndex = 5;
            this.ctrlRoundedButton24.Tag = ".";
            this.ctrlRoundedButton24.Text = ".";
            this.ctrlRoundedButton24.UseVisualStyleBackColor = false;
            this.ctrlRoundedButton24.Click += new System.EventHandler(this.Num_Click);
            // 
            // btnNum6
            // 
            this.btnNum6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btnNum6.BorderRadius = 15;
            this.btnNum6.FlatAppearance.BorderSize = 0;
            this.btnNum6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum6.Location = new System.Drawing.Point(176, 405);
            this.btnNum6.Name = "btnNum6";
            this.btnNum6.Size = new System.Drawing.Size(85, 55);
            this.btnNum6.TabIndex = 5;
            this.btnNum6.Tag = "6";
            this.btnNum6.Text = "6";
            this.btnNum6.UseVisualStyleBackColor = false;
            this.btnNum6.Click += new System.EventHandler(this.Num_Click);
            // 
            // btnNum3
            // 
            this.btnNum3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btnNum3.BorderRadius = 15;
            this.btnNum3.FlatAppearance.BorderSize = 0;
            this.btnNum3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum3.Location = new System.Drawing.Point(176, 465);
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.Size = new System.Drawing.Size(85, 55);
            this.btnNum3.TabIndex = 5;
            this.btnNum3.Tag = "3";
            this.btnNum3.Text = "3";
            this.btnNum3.UseVisualStyleBackColor = false;
            this.btnNum3.Click += new System.EventHandler(this.Num_Click);
            // 
            // btnNum9
            // 
            this.btnNum9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btnNum9.BorderRadius = 15;
            this.btnNum9.FlatAppearance.BorderSize = 0;
            this.btnNum9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum9.Location = new System.Drawing.Point(176, 345);
            this.btnNum9.Name = "btnNum9";
            this.btnNum9.Size = new System.Drawing.Size(85, 55);
            this.btnNum9.TabIndex = 5;
            this.btnNum9.Tag = "9";
            this.btnNum9.Text = "9";
            this.btnNum9.UseVisualStyleBackColor = false;
            this.btnNum9.Click += new System.EventHandler(this.Num_Click);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCE.BorderRadius = 15;
            this.btnCE.FlatAppearance.BorderSize = 0;
            this.btnCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCE.Location = new System.Drawing.Point(89, 225);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(85, 55);
            this.btnCE.TabIndex = 5;
            this.btnCE.Tag = "CE";
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSquare.BorderRadius = 15;
            this.btnSquare.FlatAppearance.BorderSize = 0;
            this.btnSquare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSquare.Location = new System.Drawing.Point(176, 285);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(85, 55);
            this.btnSquare.TabIndex = 5;
            this.btnSquare.Tag = "²√x";
            this.btnSquare.Text = "²√x";
            this.btnSquare.UseVisualStyleBackColor = false;
            this.btnSquare.Click += new System.EventHandler(this.UnaryOperations_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnC.BorderRadius = 15;
            this.btnC.FlatAppearance.BorderSize = 0;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.Location = new System.Drawing.Point(176, 225);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(85, 55);
            this.btnC.TabIndex = 5;
            this.btnC.Tag = "C";
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(118)))), ((int)(((byte)(93)))));
            this.btnEqual.BorderRadius = 15;
            this.btnEqual.FlatAppearance.BorderSize = 0;
            this.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEqual.Location = new System.Drawing.Point(261, 525);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(85, 55);
            this.btnEqual.TabIndex = 5;
            this.btnEqual.Tag = "=";
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSubtract.BorderRadius = 15;
            this.btnSubtract.FlatAppearance.BorderSize = 0;
            this.btnSubtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubtract.Location = new System.Drawing.Point(263, 405);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(85, 55);
            this.btnSubtract.TabIndex = 5;
            this.btnSubtract.Tag = "-";
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = false;
            this.btnSubtract.Click += new System.EventHandler(this.Operations_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnAdd.BorderRadius = 15;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(263, 465);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 55);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Tag = "+";
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.Operations_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnMultiply.BorderRadius = 15;
            this.btnMultiply.FlatAppearance.BorderSize = 0;
            this.btnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiply.Location = new System.Drawing.Point(263, 345);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(85, 55);
            this.btnMultiply.TabIndex = 5;
            this.btnMultiply.Tag = "*";
            this.btnMultiply.Text = "×";
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.Operations_Click);
            // 
            // btnDivition
            // 
            this.btnDivition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDivition.BorderRadius = 15;
            this.btnDivition.FlatAppearance.BorderSize = 0;
            this.btnDivition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivition.Location = new System.Drawing.Point(263, 285);
            this.btnDivition.Name = "btnDivition";
            this.btnDivition.Size = new System.Drawing.Size(85, 55);
            this.btnDivition.TabIndex = 5;
            this.btnDivition.Tag = "/";
            this.btnDivition.Text = "÷";
            this.btnDivition.UseVisualStyleBackColor = false;
            this.btnDivition.Click += new System.EventHandler(this.Operations_Click);
            // 
            // btnBackSpace
            // 
            this.btnBackSpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnBackSpace.BorderRadius = 15;
            this.btnBackSpace.FlatAppearance.BorderSize = 0;
            this.btnBackSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackSpace.Image = global::Modern_Calculator.Properties.Resources.Clear_Symbol;
            this.btnBackSpace.Location = new System.Drawing.Point(263, 225);
            this.btnBackSpace.Name = "btnBackSpace";
            this.btnBackSpace.Size = new System.Drawing.Size(85, 55);
            this.btnBackSpace.TabIndex = 5;
            this.btnBackSpace.Tag = "BackSpace";
            this.btnBackSpace.UseVisualStyleBackColor = false;
            this.btnBackSpace.Click += new System.EventHandler(this.btnBackSpace_Click);
            // 
            // ctrlRoundedButton6
            // 
            this.ctrlRoundedButton6.BorderRadius = 15;
            this.ctrlRoundedButton6.FlatAppearance.BorderSize = 0;
            this.ctrlRoundedButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ctrlRoundedButton6.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Bold);
            this.ctrlRoundedButton6.Location = new System.Drawing.Point(59, 187);
            this.ctrlRoundedButton6.Name = "ctrlRoundedButton6";
            this.ctrlRoundedButton6.Size = new System.Drawing.Size(54, 32);
            this.ctrlRoundedButton6.TabIndex = 4;
            this.ctrlRoundedButton6.Text = "MR";
            this.ctrlRoundedButton6.UseVisualStyleBackColor = true;
            // 
            // ctrlRoundedButton5
            // 
            this.ctrlRoundedButton5.BorderRadius = 15;
            this.ctrlRoundedButton5.FlatAppearance.BorderSize = 0;
            this.ctrlRoundedButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ctrlRoundedButton5.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Bold);
            this.ctrlRoundedButton5.Location = new System.Drawing.Point(0, 187);
            this.ctrlRoundedButton5.Name = "ctrlRoundedButton5";
            this.ctrlRoundedButton5.Size = new System.Drawing.Size(54, 32);
            this.ctrlRoundedButton5.TabIndex = 4;
            this.ctrlRoundedButton5.Text = "MC";
            this.ctrlRoundedButton5.UseVisualStyleBackColor = true;
            // 
            // ctrlRoundedButton4
            // 
            this.ctrlRoundedButton4.BorderRadius = 15;
            this.ctrlRoundedButton4.FlatAppearance.BorderSize = 0;
            this.ctrlRoundedButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ctrlRoundedButton4.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Bold);
            this.ctrlRoundedButton4.Location = new System.Drawing.Point(118, 187);
            this.ctrlRoundedButton4.Name = "ctrlRoundedButton4";
            this.ctrlRoundedButton4.Size = new System.Drawing.Size(54, 32);
            this.ctrlRoundedButton4.TabIndex = 4;
            this.ctrlRoundedButton4.Text = "M+";
            this.ctrlRoundedButton4.UseVisualStyleBackColor = true;
            // 
            // ctrlRoundedButton3
            // 
            this.ctrlRoundedButton3.BorderRadius = 15;
            this.ctrlRoundedButton3.FlatAppearance.BorderSize = 0;
            this.ctrlRoundedButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ctrlRoundedButton3.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Bold);
            this.ctrlRoundedButton3.Location = new System.Drawing.Point(177, 187);
            this.ctrlRoundedButton3.Name = "ctrlRoundedButton3";
            this.ctrlRoundedButton3.Size = new System.Drawing.Size(54, 32);
            this.ctrlRoundedButton3.TabIndex = 4;
            this.ctrlRoundedButton3.Text = "M-";
            this.ctrlRoundedButton3.UseVisualStyleBackColor = true;
            // 
            // ctrlRoundedButton2
            // 
            this.ctrlRoundedButton2.BorderRadius = 15;
            this.ctrlRoundedButton2.FlatAppearance.BorderSize = 0;
            this.ctrlRoundedButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ctrlRoundedButton2.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Bold);
            this.ctrlRoundedButton2.Location = new System.Drawing.Point(236, 187);
            this.ctrlRoundedButton2.Name = "ctrlRoundedButton2";
            this.ctrlRoundedButton2.Size = new System.Drawing.Size(54, 32);
            this.ctrlRoundedButton2.TabIndex = 4;
            this.ctrlRoundedButton2.Text = "MS";
            this.ctrlRoundedButton2.UseVisualStyleBackColor = true;
            // 
            // ctrlRoundedButton1
            // 
            this.ctrlRoundedButton1.BorderRadius = 15;
            this.ctrlRoundedButton1.FlatAppearance.BorderSize = 0;
            this.ctrlRoundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ctrlRoundedButton1.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Bold);
            this.ctrlRoundedButton1.Location = new System.Drawing.Point(295, 187);
            this.ctrlRoundedButton1.Name = "ctrlRoundedButton1";
            this.ctrlRoundedButton1.Size = new System.Drawing.Size(54, 32);
            this.ctrlRoundedButton1.TabIndex = 4;
            this.ctrlRoundedButton1.Text = "M~";
            this.ctrlRoundedButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(350, 595);
            this.Controls.Add(this.btnPlusMinus);
            this.Controls.Add(this.btnNum2);
            this.Controls.Add(this.btnNum1);
            this.Controls.Add(this.btnNum4);
            this.Controls.Add(this.btnNum7);
            this.Controls.Add(this.btn1X);
            this.Controls.Add(this.btnNum0);
            this.Controls.Add(this.btnNum5);
            this.Controls.Add(this.btnNum8);
            this.Controls.Add(this.btnPercent);
            this.Controls.Add(this.btnX2);
            this.Controls.Add(this.ctrlRoundedButton24);
            this.Controls.Add(this.btnNum6);
            this.Controls.Add(this.btnNum3);
            this.Controls.Add(this.btnNum9);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnSquare);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnDivition);
            this.Controls.Add(this.btnBackSpace);
            this.Controls.Add(this.ctrlRoundedButton6);
            this.Controls.Add(this.ctrlRoundedButton5);
            this.Controls.Add(this.ctrlRoundedButton4);
            this.Controls.Add(this.ctrlRoundedButton3);
            this.Controls.Add(this.ctrlRoundedButton2);
            this.Controls.Add(this.ctrlRoundedButton1);
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
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseMove);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnClearHistory;
        private System.Windows.Forms.RichTextBox rtbHistory;
        private ctrlRoundedButton ctrlRoundedButton2;
        private ctrlRoundedButton ctrlRoundedButton3;
        private ctrlRoundedButton ctrlRoundedButton4;
        private ctrlRoundedButton ctrlRoundedButton5;
        private ctrlRoundedButton ctrlRoundedButton6;
        private ctrlRoundedButton ctrlRoundedButton1;
        private ctrlRoundedButton btnBackSpace;
        private ctrlRoundedButton btnC;
        private ctrlRoundedButton btnCE;
        private ctrlRoundedButton btnPercent;
        private ctrlRoundedButton btnDivition;
        private ctrlRoundedButton btnSquare;
        private ctrlRoundedButton btnX2;
        private ctrlRoundedButton btn1X;
        private ctrlRoundedButton btnMultiply;
        private ctrlRoundedButton btnAdd;
        private ctrlRoundedButton btnEqual;
        private ctrlRoundedButton btnNum9;
        private ctrlRoundedButton btnNum8;
        private ctrlRoundedButton btnNum7;
        private ctrlRoundedButton btnNum3;
        private ctrlRoundedButton ctrlRoundedButton24;
        private ctrlRoundedButton btnNum0;
        private ctrlRoundedButton btnPlusMinus;
        private ctrlRoundedButton btnSubtract;
        private ctrlRoundedButton btnNum6;
        private ctrlRoundedButton btnNum5;
        private ctrlRoundedButton btnNum4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ctrlRoundedButton btnNum1;
        private ctrlRoundedButton btnNum2;
    }
}

