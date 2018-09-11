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
            this.plotView1 = new OxyPlot.WindowsForms.PlotView();
            this.BtabPage = new System.Windows.Forms.TabPage();
            this.CtabPage = new System.Windows.Forms.TabPage();
            this.polyharmonicTabPage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.amplitudeTextBox = new System.Windows.Forms.TextBox();
            this.frequencyTextBox = new System.Windows.Forms.TextBox();
            this.frequenciesGridView = new System.Windows.Forms.DataGridView();
            this.FunctionTabControl.SuspendLayout();
            this.harmonicTabPage.SuspendLayout();
            this.harmVariantTabControl.SuspendLayout();
            this.AtabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frequenciesGridView)).BeginInit();
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
            this.BtabPage.Location = new System.Drawing.Point(4, 22);
            this.BtabPage.Name = "BtabPage";
            this.BtabPage.Padding = new System.Windows.Forms.Padding(3);
            this.BtabPage.Size = new System.Drawing.Size(831, 547);
            this.BtabPage.TabIndex = 1;
            this.BtabPage.Text = "Const A and fi";
            this.BtabPage.UseVisualStyleBackColor = true;
            // 
            // CtabPage
            // 
            this.CtabPage.Location = new System.Drawing.Point(4, 22);
            this.CtabPage.Name = "CtabPage";
            this.CtabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CtabPage.Size = new System.Drawing.Size(831, 547);
            this.CtabPage.TabIndex = 2;
            this.CtabPage.Text = "Const fi and f";
            this.CtabPage.UseVisualStyleBackColor = true;
            // 
            // polyharmonicTabPage
            // 
            this.polyharmonicTabPage.Location = new System.Drawing.Point(4, 22);
            this.polyharmonicTabPage.Name = "polyharmonicTabPage";
            this.polyharmonicTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.polyharmonicTabPage.Size = new System.Drawing.Size(835, 576);
            this.polyharmonicTabPage.TabIndex = 1;
            this.polyharmonicTabPage.Text = "Polyharmonic";
            this.polyharmonicTabPage.UseVisualStyleBackColor = true;
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
            // amplitudeTextBox
            // 
            this.amplitudeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amplitudeTextBox.Location = new System.Drawing.Point(57, 452);
            this.amplitudeTextBox.MaxLength = 2;
            this.amplitudeTextBox.Name = "amplitudeTextBox";
            this.amplitudeTextBox.Size = new System.Drawing.Size(100, 29);
            this.amplitudeTextBox.TabIndex = 3;
            this.amplitudeTextBox.Text = "7";
            // 
            // frequencyTextBox
            // 
            this.frequencyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.frequencyTextBox.Location = new System.Drawing.Point(57, 495);
            this.frequencyTextBox.MaxLength = 1;
            this.frequencyTextBox.Name = "frequencyTextBox";
            this.frequencyTextBox.Size = new System.Drawing.Size(100, 29);
            this.frequencyTextBox.TabIndex = 4;
            this.frequencyTextBox.Text = "5";
            // 
            // frequenciesGridView
            // 
            this.frequenciesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.frequenciesGridView.Location = new System.Drawing.Point(265, 452);
            this.frequenciesGridView.Name = "frequenciesGridView";
            this.frequenciesGridView.Size = new System.Drawing.Size(243, 72);
            this.frequenciesGridView.TabIndex = 5;
            this.frequenciesGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
    }
}

