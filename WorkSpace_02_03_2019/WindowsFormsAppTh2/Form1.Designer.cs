namespace WindowsFormsAppTh2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.buttonRM = new System.Windows.Forms.Button();
            this.buttonRP = new System.Windows.Forms.Button();
            this.buttonLM = new System.Windows.Forms.Button();
            this.buttonLP = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxL = new System.Windows.Forms.TextBox();
            this.textBoxR = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(234, 25);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(486, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Value = 50;
            // 
            // buttonRM
            // 
            this.buttonRM.Location = new System.Drawing.Point(740, 25);
            this.buttonRM.Name = "buttonRM";
            this.buttonRM.Size = new System.Drawing.Size(75, 23);
            this.buttonRM.TabIndex = 1;
            this.buttonRM.Text = "-";
            this.buttonRM.UseVisualStyleBackColor = true;
            this.buttonRM.Click += new System.EventHandler(this.buttonRM_Click);
            // 
            // buttonRP
            // 
            this.buttonRP.Location = new System.Drawing.Point(835, 25);
            this.buttonRP.Name = "buttonRP";
            this.buttonRP.Size = new System.Drawing.Size(75, 23);
            this.buttonRP.TabIndex = 2;
            this.buttonRP.Text = "+";
            this.buttonRP.UseVisualStyleBackColor = true;
            this.buttonRP.Click += new System.EventHandler(this.buttonRP_Click);
            // 
            // buttonLM
            // 
            this.buttonLM.Location = new System.Drawing.Point(12, 26);
            this.buttonLM.Name = "buttonLM";
            this.buttonLM.Size = new System.Drawing.Size(75, 23);
            this.buttonLM.TabIndex = 3;
            this.buttonLM.Text = "-";
            this.buttonLM.UseVisualStyleBackColor = true;
            this.buttonLM.Click += new System.EventHandler(this.buttonLM_Click);
            // 
            // buttonLP
            // 
            this.buttonLP.Location = new System.Drawing.Point(110, 26);
            this.buttonLP.Name = "buttonLP";
            this.buttonLP.Size = new System.Drawing.Size(75, 23);
            this.buttonLP.TabIndex = 4;
            this.buttonLP.Text = "+";
            this.buttonLP.UseVisualStyleBackColor = true;
            this.buttonLP.Click += new System.EventHandler(this.buttonLP_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(439, 76);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBoxL
            // 
            this.textBoxL.Location = new System.Drawing.Point(59, 88);
            this.textBoxL.Name = "textBoxL";
            this.textBoxL.Size = new System.Drawing.Size(100, 20);
            this.textBoxL.TabIndex = 6;
            // 
            // textBoxR
            // 
            this.textBoxR.Location = new System.Drawing.Point(779, 76);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(100, 20);
            this.textBoxR.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 120);
            this.Controls.Add(this.textBoxR);
            this.Controls.Add(this.textBoxL);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonLP);
            this.Controls.Add(this.buttonLM);
            this.Controls.Add(this.buttonRP);
            this.Controls.Add(this.buttonRM);
            this.Controls.Add(this.trackBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button buttonRM;
        private System.Windows.Forms.Button buttonRP;
        private System.Windows.Forms.Button buttonLM;
        private System.Windows.Forms.Button buttonLP;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBoxL;
        private System.Windows.Forms.TextBox textBoxR;
    }
}

