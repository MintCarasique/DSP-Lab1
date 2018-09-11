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
            this.drawAllButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.frequenciesGridView = new System.Windows.Forms.DataGridView();
            this.frequencyTextBox = new System.Windows.Forms.TextBox();
            this.amplitudeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.plotView1 = new OxyPlot.WindowsForms.PlotView();
            this.BtabPage = new System.Windows.Forms.TabPage();
            this.CtabPage = new System.Windows.Forms.TabPage();
            this.polyharmonicTabPage = new System.Windows.Forms.TabPage();
            this.rebuildButton = new System.Windows.Forms.Button();
            this.amplitudeTextBox2 = new System.Windows.Forms.TextBox();
            this.plotView2 = new OxyPlot.WindowsForms.PlotView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fiTextBox = new System.Windows.Forms.TextBox();
            this.FunctionTabControl.SuspendLayout();
            this.harmonicTabPage.SuspendLayout();
            this.harmVariantTabControl.SuspendLayout();
            this.AtabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frequenciesGridView)).BeginInit();
            this.BtabPage.SuspendLayout();
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
            this.AtabPage.Controls.Add(this.rebuildButton);
            this.AtabPage.Controls.Add(this.drawAllButton);
            this.AtabPage.Controls.Add(this.label3);
            this.AtabPage.Controls.Add(this.frequenciesGridView);
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
            // drawAllButton
            // 
            this.drawAllButton.Location = new System.Drawing.Point(901, 475);
            this.drawAllButton.Name = "drawAllButton";
            this.drawAllButton.Size = new System.Drawing.Size(75, 23);
            this.drawAllButton.TabIndex = 7;
            this.drawAllButton.Text = "Draw All";
            this.drawAllButton.UseVisualStyleBackColor = true;
            this.drawAllButton.Click += new System.EventHandler(this.drawAllButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(254, 475);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "fi = ";
            // 
            // frequenciesGridView
            // 
            this.frequenciesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.frequenciesGridView.Location = new System.Drawing.Point(304, 452);
            this.frequenciesGridView.Name = "frequenciesGridView";
            this.frequenciesGridView.Size = new System.Drawing.Size(591, 72);
            this.frequenciesGridView.TabIndex = 5;
            this.frequenciesGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.frequenciesGridView_CellClick);
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
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            this.BtabPage.Controls.Add(this.fiTextBox);
            this.BtabPage.Controls.Add(this.label5);
            this.BtabPage.Controls.Add(this.label4);
            this.BtabPage.Controls.Add(this.plotView2);
            this.BtabPage.Controls.Add(this.amplitudeTextBox2);
            this.BtabPage.Location = new System.Drawing.Point(4, 22);
            this.BtabPage.Name = "BtabPage";
            this.BtabPage.Padding = new System.Windows.Forms.Padding(3);
            this.BtabPage.Size = new System.Drawing.Size(1260, 547);
            this.BtabPage.TabIndex = 1;
            this.BtabPage.Text = "Const A and fi";
            this.BtabPage.UseVisualStyleBackColor = true;
            // 
            // CtabPage
            // 
            this.CtabPage.Location = new System.Drawing.Point(4, 22);
            this.CtabPage.Name = "CtabPage";
            this.CtabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CtabPage.Size = new System.Drawing.Size(1260, 547);
            this.CtabPage.TabIndex = 2;
            this.CtabPage.Text = "Const fi and f";
            this.CtabPage.UseVisualStyleBackColor = true;
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
            // rebuildButton
            // 
            this.rebuildButton.Location = new System.Drawing.Point(983, 475);
            this.rebuildButton.Name = "rebuildButton";
            this.rebuildButton.Size = new System.Drawing.Size(75, 23);
            this.rebuildButton.TabIndex = 8;
            this.rebuildButton.Text = "Rebuild";
            this.rebuildButton.UseVisualStyleBackColor = true;
            this.rebuildButton.Click += new System.EventHandler(this.rebuildButton_Click);
            // 
            // amplitudeTextBox2
            // 
            this.amplitudeTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amplitudeTextBox2.Location = new System.Drawing.Point(56, 454);
            this.amplitudeTextBox2.MaxLength = 2;
            this.amplitudeTextBox2.Name = "amplitudeTextBox2";
            this.amplitudeTextBox2.ReadOnly = true;
            this.amplitudeTextBox2.Size = new System.Drawing.Size(100, 29);
            this.amplitudeTextBox2.TabIndex = 4;
            this.amplitudeTextBox2.Text = "7";
            this.amplitudeTextBox2.TextChanged += new System.EventHandler(this.amplitudeTextBox2_TextChanged);
            // 
            // plotView2
            // 
            this.plotView2.Location = new System.Drawing.Point(7, 6);
            this.plotView2.Name = "plotView2";
            this.plotView2.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView2.Size = new System.Drawing.Size(1247, 432);
            this.plotView2.TabIndex = 5;
            this.plotView2.Text = "plotView";
            this.plotView2.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView2.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView2.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 457);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "A = ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(17, 495);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "fi = ";
            // 
            // fiTextBox
            // 
            this.fiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fiTextBox.Location = new System.Drawing.Point(56, 492);
            this.fiTextBox.MaxLength = 2;
            this.fiTextBox.Name = "fiTextBox";
            this.fiTextBox.ReadOnly = true;
            this.fiTextBox.Size = new System.Drawing.Size(100, 29);
            this.fiTextBox.TabIndex = 8;
            this.fiTextBox.Text = "7";
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
            ((System.ComponentModel.ISupportInitialize)(this.frequenciesGridView)).EndInit();
            this.BtabPage.ResumeLayout(false);
            this.BtabPage.PerformLayout();
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
        private System.Windows.Forms.DataGridView frequenciesGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button drawAllButton;
        private System.Windows.Forms.Button rebuildButton;
        private System.Windows.Forms.Label label4;
        private OxyPlot.WindowsForms.PlotView plotView2;
        private System.Windows.Forms.TextBox amplitudeTextBox2;
        private System.Windows.Forms.TextBox fiTextBox;
        private System.Windows.Forms.Label label5;
    }
}

