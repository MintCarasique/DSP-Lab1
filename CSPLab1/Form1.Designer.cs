namespace CSPLab1
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
            this.FunctionTabControl = new System.Windows.Forms.TabControl();
            this.harmonicTabPage = new System.Windows.Forms.TabPage();
            this.harmVariantTabControl = new System.Windows.Forms.TabControl();
            this.AtabPage = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.nBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.NtextBox1 = new System.Windows.Forms.TextBox();
            this.drawAllButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.fiGridView = new System.Windows.Forms.DataGridView();
            this.frequencyTextBox = new System.Windows.Forms.TextBox();
            this.amplitudeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.plotView1 = new OxyPlot.WindowsForms.PlotView();
            this.BtabPage = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.nBox2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.NtextBox2 = new System.Windows.Forms.TextBox();
            this.amplitudeTextBox2 = new System.Windows.Forms.TextBox();
            this.DrawAll2button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.frequenciesGridView = new System.Windows.Forms.DataGridView();
            this.fiTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.plotView2 = new OxyPlot.WindowsForms.PlotView();
            this.CtabPage = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.nBox3 = new System.Windows.Forms.TextBox();
            this.NtextBox3 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.DrawAll3button = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.amplitudeGridView = new System.Windows.Forms.DataGridView();
            this.frequencyTextBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.fiTextBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.plotView3 = new OxyPlot.WindowsForms.PlotView();
            this.polyharmonicTabPage = new System.Windows.Forms.TabPage();
            this.FunctionTabControl.SuspendLayout();
            this.harmonicTabPage.SuspendLayout();
            this.harmVariantTabControl.SuspendLayout();
            this.AtabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fiGridView)).BeginInit();
            this.BtabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frequenciesGridView)).BeginInit();
            this.CtabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amplitudeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FunctionTabControl
            // 
            this.FunctionTabControl.Controls.Add(this.harmonicTabPage);
            this.FunctionTabControl.Controls.Add(this.polyharmonicTabPage);
            this.FunctionTabControl.Location = new System.Drawing.Point(-1, 2);
            this.FunctionTabControl.Name = "FunctionTabControl";
            this.FunctionTabControl.SelectedIndex = 0;
            this.FunctionTabControl.Size = new System.Drawing.Size(1272, 602);
            this.FunctionTabControl.TabIndex = 0;
            // 
            // harmonicTabPage
            // 
            this.harmonicTabPage.Controls.Add(this.harmVariantTabControl);
            this.harmonicTabPage.Location = new System.Drawing.Point(4, 22);
            this.harmonicTabPage.Name = "harmonicTabPage";
            this.harmonicTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.harmonicTabPage.Size = new System.Drawing.Size(1264, 576);
            this.harmonicTabPage.TabIndex = 0;
            this.harmonicTabPage.Text = "Harmonic";
            this.harmonicTabPage.UseVisualStyleBackColor = true;
            // 
            // harmVariantTabControl
            // 
            this.harmVariantTabControl.Controls.Add(this.AtabPage);
            this.harmVariantTabControl.Controls.Add(this.BtabPage);
            this.harmVariantTabControl.Controls.Add(this.CtabPage);
            this.harmVariantTabControl.Location = new System.Drawing.Point(0, 0);
            this.harmVariantTabControl.Name = "harmVariantTabControl";
            this.harmVariantTabControl.SelectedIndex = 0;
            this.harmVariantTabControl.Size = new System.Drawing.Size(1268, 573);
            this.harmVariantTabControl.TabIndex = 0;
            // 
            // AtabPage
            // 
            this.AtabPage.Controls.Add(this.label13);
            this.AtabPage.Controls.Add(this.nBox1);
            this.AtabPage.Controls.Add(this.label10);
            this.AtabPage.Controls.Add(this.NtextBox1);
            this.AtabPage.Controls.Add(this.drawAllButton);
            this.AtabPage.Controls.Add(this.label3);
            this.AtabPage.Controls.Add(this.fiGridView);
            this.AtabPage.Controls.Add(this.frequencyTextBox);
            this.AtabPage.Controls.Add(this.amplitudeTextBox);
            this.AtabPage.Controls.Add(this.label2);
            this.AtabPage.Controls.Add(this.label1);
            this.AtabPage.Controls.Add(this.plotView1);
            this.AtabPage.Location = new System.Drawing.Point(4, 22);
            this.AtabPage.Name = "AtabPage";
            this.AtabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AtabPage.Size = new System.Drawing.Size(1260, 547);
            this.AtabPage.TabIndex = 0;
            this.AtabPage.Text = "Const A and f";
            this.AtabPage.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(1087, 500);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 24);
            this.label13.TabIndex = 11;
            this.label13.Text = "n = ";
            // 
            // nBox1
            // 
            this.nBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nBox1.Location = new System.Drawing.Point(1135, 498);
            this.nBox1.MaxLength = 7;
            this.nBox1.Name = "nBox1";
            this.nBox1.Size = new System.Drawing.Size(100, 29);
            this.nBox1.TabIndex = 10;
            this.nBox1.Text = "512";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(1085, 456);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 24);
            this.label10.TabIndex = 9;
            this.label10.Text = "N = ";
            // 
            // NtextBox1
            // 
            this.NtextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NtextBox1.Location = new System.Drawing.Point(1135, 452);
            this.NtextBox1.MaxLength = 7;
            this.NtextBox1.Name = "NtextBox1";
            this.NtextBox1.Size = new System.Drawing.Size(100, 29);
            this.NtextBox1.TabIndex = 8;
            this.NtextBox1.Text = "512";
            // 
            // drawAllButton
            // 
            this.drawAllButton.Location = new System.Drawing.Point(901, 475);
            this.drawAllButton.Name = "drawAllButton";
            this.drawAllButton.Size = new System.Drawing.Size(126, 23);
            this.drawAllButton.TabIndex = 7;
            this.drawAllButton.Text = "Draw All/Rebuild";
            this.drawAllButton.UseVisualStyleBackColor = true;
            this.drawAllButton.Click += new System.EventHandler(this.drawAllButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(250, 475);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "fi = ";
            // 
            // fiGridView
            // 
            this.fiGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fiGridView.Location = new System.Drawing.Point(304, 452);
            this.fiGridView.Name = "fiGridView";
            this.fiGridView.Size = new System.Drawing.Size(591, 72);
            this.fiGridView.TabIndex = 5;
            this.fiGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.fiGridView_CellClick);
            // 
            // frequencyTextBox
            // 
            this.frequencyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.frequencyTextBox.Location = new System.Drawing.Point(57, 495);
            this.frequencyTextBox.MaxLength = 1;
            this.frequencyTextBox.Name = "frequencyTextBox";
            this.frequencyTextBox.ReadOnly = true;
            this.frequencyTextBox.Size = new System.Drawing.Size(100, 29);
            this.frequencyTextBox.TabIndex = 4;
            this.frequencyTextBox.Text = "5";
            // 
            // amplitudeTextBox
            // 
            this.amplitudeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amplitudeTextBox.Location = new System.Drawing.Point(57, 452);
            this.amplitudeTextBox.MaxLength = 2;
            this.amplitudeTextBox.Name = "amplitudeTextBox";
            this.amplitudeTextBox.ReadOnly = true;
            this.amplitudeTextBox.Size = new System.Drawing.Size(100, 29);
            this.amplitudeTextBox.TabIndex = 3;
            this.amplitudeTextBox.Text = "7";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(26, 498);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "f = ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 455);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "A = ";
            // 
            // plotView1
            // 
            this.plotView1.Location = new System.Drawing.Point(7, 7);
            this.plotView1.Name = "plotView1";
            this.plotView1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView1.Size = new System.Drawing.Size(1247, 432);
            this.plotView1.TabIndex = 0;
            this.plotView1.Text = "plotView";
            this.plotView1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // BtabPage
            // 
            this.BtabPage.Controls.Add(this.label14);
            this.BtabPage.Controls.Add(this.nBox2);
            this.BtabPage.Controls.Add(this.label11);
            this.BtabPage.Controls.Add(this.NtextBox2);
            this.BtabPage.Controls.Add(this.amplitudeTextBox2);
            this.BtabPage.Controls.Add(this.DrawAll2button);
            this.BtabPage.Controls.Add(this.label6);
            this.BtabPage.Controls.Add(this.frequenciesGridView);
            this.BtabPage.Controls.Add(this.fiTextBox);
            this.BtabPage.Controls.Add(this.label5);
            this.BtabPage.Controls.Add(this.label4);
            this.BtabPage.Controls.Add(this.plotView2);
            this.BtabPage.Location = new System.Drawing.Point(4, 22);
            this.BtabPage.Name = "BtabPage";
            this.BtabPage.Padding = new System.Windows.Forms.Padding(3);
            this.BtabPage.Size = new System.Drawing.Size(1260, 547);
            this.BtabPage.TabIndex = 1;
            this.BtabPage.Text = "Const A and fi";
            this.BtabPage.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(1087, 500);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 24);
            this.label14.TabIndex = 15;
            this.label14.Text = "n = ";
            // 
            // nBox2
            // 
            this.nBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nBox2.Location = new System.Drawing.Point(1135, 498);
            this.nBox2.MaxLength = 7;
            this.nBox2.Name = "nBox2";
            this.nBox2.Size = new System.Drawing.Size(100, 29);
            this.nBox2.TabIndex = 14;
            this.nBox2.Text = "512";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(1085, 456);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 24);
            this.label11.TabIndex = 13;
            this.label11.Text = "N = ";
            // 
            // NtextBox2
            // 
            this.NtextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NtextBox2.Location = new System.Drawing.Point(1135, 452);
            this.NtextBox2.MaxLength = 7;
            this.NtextBox2.Name = "NtextBox2";
            this.NtextBox2.Size = new System.Drawing.Size(100, 29);
            this.NtextBox2.TabIndex = 12;
            this.NtextBox2.Text = "512";
            // 
            // amplitudeTextBox2
            // 
            this.amplitudeTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amplitudeTextBox2.Location = new System.Drawing.Point(57, 452);
            this.amplitudeTextBox2.MaxLength = 2;
            this.amplitudeTextBox2.Name = "amplitudeTextBox2";
            this.amplitudeTextBox2.ReadOnly = true;
            this.amplitudeTextBox2.Size = new System.Drawing.Size(100, 29);
            this.amplitudeTextBox2.TabIndex = 4;
            this.amplitudeTextBox2.Text = "7";
            // 
            // DrawAll2button
            // 
            this.DrawAll2button.Location = new System.Drawing.Point(901, 475);
            this.DrawAll2button.Name = "DrawAll2button";
            this.DrawAll2button.Size = new System.Drawing.Size(126, 23);
            this.DrawAll2button.TabIndex = 11;
            this.DrawAll2button.Text = "Draw All/Rebuild";
            this.DrawAll2button.UseVisualStyleBackColor = true;
            this.DrawAll2button.Click += new System.EventHandler(this.DrawAll2button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(252, 477);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "f = ";
            // 
            // frequenciesGridView
            // 
            this.frequenciesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.frequenciesGridView.Location = new System.Drawing.Point(304, 452);
            this.frequenciesGridView.Name = "frequenciesGridView";
            this.frequenciesGridView.Size = new System.Drawing.Size(591, 72);
            this.frequenciesGridView.TabIndex = 9;
            this.frequenciesGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.frequenciesGridView_CellClick);
            // 
            // fiTextBox
            // 
            this.fiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fiTextBox.Location = new System.Drawing.Point(57, 495);
            this.fiTextBox.MaxLength = 2;
            this.fiTextBox.Name = "fiTextBox";
            this.fiTextBox.ReadOnly = true;
            this.fiTextBox.Size = new System.Drawing.Size(100, 29);
            this.fiTextBox.TabIndex = 8;
            this.fiTextBox.Text = "3π/4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(22, 498);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "fi = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(17, 455);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "A = ";
            // 
            // plotView2
            // 
            this.plotView2.Location = new System.Drawing.Point(7, 7);
            this.plotView2.Name = "plotView2";
            this.plotView2.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView2.Size = new System.Drawing.Size(1247, 432);
            this.plotView2.TabIndex = 5;
            this.plotView2.Text = "plotView";
            this.plotView2.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView2.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView2.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // CtabPage
            // 
            this.CtabPage.Controls.Add(this.label15);
            this.CtabPage.Controls.Add(this.nBox3);
            this.CtabPage.Controls.Add(this.NtextBox3);
            this.CtabPage.Controls.Add(this.label12);
            this.CtabPage.Controls.Add(this.DrawAll3button);
            this.CtabPage.Controls.Add(this.label9);
            this.CtabPage.Controls.Add(this.amplitudeGridView);
            this.CtabPage.Controls.Add(this.frequencyTextBox2);
            this.CtabPage.Controls.Add(this.label8);
            this.CtabPage.Controls.Add(this.fiTextBox2);
            this.CtabPage.Controls.Add(this.label7);
            this.CtabPage.Controls.Add(this.plotView3);
            this.CtabPage.Location = new System.Drawing.Point(4, 22);
            this.CtabPage.Name = "CtabPage";
            this.CtabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CtabPage.Size = new System.Drawing.Size(1260, 547);
            this.CtabPage.TabIndex = 2;
            this.CtabPage.Text = "Const fi and f";
            this.CtabPage.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(1087, 500);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 24);
            this.label15.TabIndex = 19;
            this.label15.Text = "n = ";
            // 
            // nBox3
            // 
            this.nBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nBox3.Location = new System.Drawing.Point(1135, 498);
            this.nBox3.MaxLength = 7;
            this.nBox3.Name = "nBox3";
            this.nBox3.Size = new System.Drawing.Size(100, 29);
            this.nBox3.TabIndex = 18;
            this.nBox3.Text = "512";
            // 
            // NtextBox3
            // 
            this.NtextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NtextBox3.Location = new System.Drawing.Point(1135, 452);
            this.NtextBox3.MaxLength = 7;
            this.NtextBox3.Name = "NtextBox3";
            this.NtextBox3.Size = new System.Drawing.Size(100, 29);
            this.NtextBox3.TabIndex = 17;
            this.NtextBox3.Text = "512";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(1085, 456);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 24);
            this.label12.TabIndex = 16;
            this.label12.Text = "N = ";
            // 
            // DrawAll3button
            // 
            this.DrawAll3button.Location = new System.Drawing.Point(901, 475);
            this.DrawAll3button.Name = "DrawAll3button";
            this.DrawAll3button.Size = new System.Drawing.Size(126, 23);
            this.DrawAll3button.TabIndex = 15;
            this.DrawAll3button.Text = "Draw All/Rebuild";
            this.DrawAll3button.UseVisualStyleBackColor = true;
            this.DrawAll3button.Click += new System.EventHandler(this.DrawAll3button_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(255, 475);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 24);
            this.label9.TabIndex = 14;
            this.label9.Text = "A = ";
            // 
            // amplitudeGridView
            // 
            this.amplitudeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.amplitudeGridView.Location = new System.Drawing.Point(304, 452);
            this.amplitudeGridView.Name = "amplitudeGridView";
            this.amplitudeGridView.Size = new System.Drawing.Size(591, 72);
            this.amplitudeGridView.TabIndex = 13;
            this.amplitudeGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.amplitudeGridView_CellClick);
            // 
            // frequencyTextBox2
            // 
            this.frequencyTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.frequencyTextBox2.Location = new System.Drawing.Point(57, 452);
            this.frequencyTextBox2.MaxLength = 1;
            this.frequencyTextBox2.Name = "frequencyTextBox2";
            this.frequencyTextBox2.ReadOnly = true;
            this.frequencyTextBox2.Size = new System.Drawing.Size(100, 29);
            this.frequencyTextBox2.TabIndex = 12;
            this.frequencyTextBox2.Text = "3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(17, 455);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 24);
            this.label8.TabIndex = 11;
            this.label8.Text = "f = ";
            // 
            // fiTextBox2
            // 
            this.fiTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fiTextBox2.Location = new System.Drawing.Point(57, 495);
            this.fiTextBox2.MaxLength = 2;
            this.fiTextBox2.Name = "fiTextBox2";
            this.fiTextBox2.ReadOnly = true;
            this.fiTextBox2.Size = new System.Drawing.Size(100, 29);
            this.fiTextBox2.TabIndex = 10;
            this.fiTextBox2.Text = "3π/4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(26, 498);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 24);
            this.label7.TabIndex = 9;
            this.label7.Text = "fi = ";
            // 
            // plotView3
            // 
            this.plotView3.Location = new System.Drawing.Point(7, 7);
            this.plotView3.Name = "plotView3";
            this.plotView3.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView3.Size = new System.Drawing.Size(1247, 432);
            this.plotView3.TabIndex = 6;
            this.plotView3.Text = "plotView";
            this.plotView3.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView3.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView3.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // polyharmonicTabPage
            // 
            this.polyharmonicTabPage.Location = new System.Drawing.Point(4, 22);
            this.polyharmonicTabPage.Name = "polyharmonicTabPage";
            this.polyharmonicTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.polyharmonicTabPage.Size = new System.Drawing.Size(1264, 576);
            this.polyharmonicTabPage.TabIndex = 1;
            this.polyharmonicTabPage.Text = "Polyharmonic";
            this.polyharmonicTabPage.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 604);
            this.Controls.Add(this.FunctionTabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FunctionTabControl.ResumeLayout(false);
            this.harmonicTabPage.ResumeLayout(false);
            this.harmVariantTabControl.ResumeLayout(false);
            this.AtabPage.ResumeLayout(false);
            this.AtabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fiGridView)).EndInit();
            this.BtabPage.ResumeLayout(false);
            this.BtabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frequenciesGridView)).EndInit();
            this.CtabPage.ResumeLayout(false);
            this.CtabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amplitudeGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl FunctionTabControl;
        private System.Windows.Forms.TabPage harmonicTabPage;
        private System.Windows.Forms.TabPage polyharmonicTabPage;
        private System.Windows.Forms.TabControl harmVariantTabControl;
        private System.Windows.Forms.TabPage AtabPage;
        private System.Windows.Forms.TabPage BtabPage;
        private System.Windows.Forms.TabPage CtabPage;
        private OxyPlot.WindowsForms.PlotView plotView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox amplitudeTextBox;
        private System.Windows.Forms.TextBox frequencyTextBox;
        private System.Windows.Forms.DataGridView fiGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button drawAllButton;
        private System.Windows.Forms.Label label4;
        private OxyPlot.WindowsForms.PlotView plotView2;
        private System.Windows.Forms.TextBox amplitudeTextBox2;
        private System.Windows.Forms.TextBox fiTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView frequenciesGridView;
        private System.Windows.Forms.Button DrawAll2button;
        private System.Windows.Forms.TextBox fiTextBox2;
        private System.Windows.Forms.Label label7;
        private OxyPlot.WindowsForms.PlotView plotView3;
        private System.Windows.Forms.TextBox frequencyTextBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView amplitudeGridView;
        private System.Windows.Forms.Button DrawAll3button;
        private System.Windows.Forms.TextBox NtextBox1;
        private System.Windows.Forms.TextBox NtextBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox NtextBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox nBox1;
        private System.Windows.Forms.TextBox nBox2;
        private System.Windows.Forms.TextBox nBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}

