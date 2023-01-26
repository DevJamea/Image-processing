namespace Image_processing
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.button23 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.text2img = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.width = new System.Windows.Forms.TextBox();
            this.height = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button22 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.undo = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panAndZoomPictureBox1 = new Emgu.CV.UI.PanAndZoomPictureBox();
            this.button24 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panAndZoomPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.BackColor = System.Drawing.Color.FloralWhite;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(228, 342);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
            this.listBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox1_DragEnter);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(12, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "التالي";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(147, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "السابق";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(294, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(947, 34);
            this.button3.TabIndex = 4;
            this.button3.Text = "إستعراض";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(3, 376);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 180);
            this.textBox1.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button4.Location = new System.Drawing.Point(0, 590);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(243, 34);
            this.button4.TabIndex = 6;
            this.button4.Text = "هستوغرام";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 624);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1253, 77);
            this.panel1.TabIndex = 8;
            this.panel1.Click += new System.EventHandler(this.s);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1010, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 624);
            this.panel2.TabIndex = 9;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel13);
            this.panel3.Controls.Add(this.panel12);
            this.panel3.Controls.Add(this.panel11);
            this.panel3.Controls.Add(this.panel10);
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 624);
            this.panel3.TabIndex = 10;
            // 
            // panel13
            // 
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(0, 337);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(265, 93);
            this.panel13.TabIndex = 4;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.button12);
            this.panel12.Controls.Add(this.button11);
            this.panel12.Controls.Add(this.button10);
            this.panel12.Controls.Add(this.label3);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel12.Location = new System.Drawing.Point(0, 421);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(265, 201);
            this.panel12.TabIndex = 3;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(16, 151);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(229, 35);
            this.button12.TabIndex = 3;
            this.button12.Text = "Log transformation";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(16, 99);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(229, 35);
            this.button11.TabIndex = 2;
            this.button11.Text = "Gamma correction";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(16, 49);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(229, 35);
            this.button10.TabIndex = 1;
            this.button10.Text = "Histogram equalization";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Intensity transforms";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.button9);
            this.panel11.Controls.Add(this.button8);
            this.panel11.Controls.Add(this.button7);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 279);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(265, 58);
            this.panel11.TabIndex = 2;
            // 
            // button9
            // 
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(170, 13);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 35);
            this.button9.TabIndex = 2;
            this.button9.Text = "180";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(93, 13);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(66, 35);
            this.button8.TabIndex = 1;
            this.button8.Text = "90";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(16, 13);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(66, 35);
            this.button7.TabIndex = 0;
            this.button7.Text = "90";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.button23);
            this.panel10.Controls.Add(this.button6);
            this.panel10.Controls.Add(this.text2img);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 124);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(265, 155);
            this.panel10.TabIndex = 1;
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(16, 114);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(229, 35);
            this.button23.TabIndex = 2;
            this.button23.Text = "إضافة لوغو الى الصورة";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(16, 62);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(229, 35);
            this.button6.TabIndex = 1;
            this.button6.Text = "إضافة نص الى الصورة";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // text2img
            // 
            this.text2img.Location = new System.Drawing.Point(16, 19);
            this.text2img.Name = "text2img";
            this.text2img.Size = new System.Drawing.Size(229, 26);
            this.text2img.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.button5);
            this.panel9.Controls.Add(this.label2);
            this.panel9.Controls.Add(this.label1);
            this.panel9.Controls.Add(this.width);
            this.panel9.Controls.Add(this.height);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(265, 124);
            this.panel9.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(16, 90);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(229, 31);
            this.button5.TabIndex = 4;
            this.button5.Text = "resize";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "العرض";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "الطول";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // width
            // 
            this.width.Location = new System.Drawing.Point(16, 48);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(143, 26);
            this.width.TabIndex = 1;
            this.width.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.width_KeyPress);
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(16, 9);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(143, 26);
            this.height.TabIndex = 0;
            this.height.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.height.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.height_KeyPress);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button24);
            this.panel4.Controls.Add(this.button22);
            this.panel4.Controls.Add(this.button21);
            this.panel4.Controls.Add(this.button20);
            this.panel4.Controls.Add(this.button19);
            this.panel4.Controls.Add(this.undo);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(267, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(743, 100);
            this.panel4.TabIndex = 11;
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(96, 55);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(75, 35);
            this.button22.TabIndex = 4;
            this.button22.Text = "CMYK";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(96, 9);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(75, 35);
            this.button21.TabIndex = 3;
            this.button21.Text = "CMY";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(15, 55);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(75, 35);
            this.button20.TabIndex = 2;
            this.button20.Text = "RGB";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(15, 10);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(75, 35);
            this.button19.TabIndex = 1;
            this.button19.Text = "Gray";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // undo
            // 
            this.undo.Location = new System.Drawing.Point(651, 10);
            this.undo.Name = "undo";
            this.undo.Size = new System.Drawing.Size(75, 78);
            this.undo.TabIndex = 0;
            this.undo.Text = "تراجع";
            this.undo.UseVisualStyleBackColor = true;
            this.undo.Click += new System.EventHandler(this.undo_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button18);
            this.panel5.Controls.Add(this.button17);
            this.panel5.Controls.Add(this.button16);
            this.panel5.Controls.Add(this.button15);
            this.panel5.Controls.Add(this.button14);
            this.panel5.Controls.Add(this.button13);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(267, 524);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(743, 100);
            this.panel5.TabIndex = 12;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(496, 59);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(230, 35);
            this.button18.TabIndex = 5;
            this.button18.Text = "Sharpning sobel";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(496, 18);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(230, 35);
            this.button17.TabIndex = 4;
            this.button17.Text = "Sharpning laplacian";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(251, 59);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(230, 35);
            this.button16.TabIndex = 3;
            this.button16.Text = "Warm filter";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(251, 18);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(230, 35);
            this.button15.TabIndex = 2;
            this.button15.Text = "Cold filter";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(15, 59);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(230, 35);
            this.button14.TabIndex = 1;
            this.button14.Text = "Smoothing gaussian";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(15, 18);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(230, 35);
            this.button13.TabIndex = 0;
            this.button13.Text = "Smoothing Box";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(993, 100);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(17, 424);
            this.panel6.TabIndex = 13;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(267, 100);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(54, 424);
            this.panel7.TabIndex = 14;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panAndZoomPictureBox1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(321, 100);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(672, 424);
            this.panel8.TabIndex = 15;
            // 
            // panAndZoomPictureBox1
            // 
            this.panAndZoomPictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.panAndZoomPictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panAndZoomPictureBox1.Location = new System.Drawing.Point(6, 6);
            this.panAndZoomPictureBox1.Name = "panAndZoomPictureBox1";
            this.panAndZoomPictureBox1.Size = new System.Drawing.Size(660, 412);
            this.panAndZoomPictureBox1.TabIndex = 2;
            this.panAndZoomPictureBox1.TabStop = false;
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(556, 9);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(76, 79);
            this.button24.TabIndex = 5;
            this.button24.Text = "حفظ";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1253, 701);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "معرض الصور";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panAndZoomPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox width;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.Button undo;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox text2img;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button19;
        private Emgu.CV.UI.PanAndZoomPictureBox panAndZoomPictureBox1;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
    }
}

