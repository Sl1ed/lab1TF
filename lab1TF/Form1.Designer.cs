namespace lab1TF
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
            this.tbFSource = new System.Windows.Forms.TextBox();
            this.tbFMessage = new System.Windows.Forms.TextBox();
            this.btnFStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbFSource
            // 
            this.tbFSource.Location = new System.Drawing.Point(59, 60);
            this.tbFSource.Multiline = true;
            this.tbFSource.Name = "tbFSource";
            this.tbFSource.Size = new System.Drawing.Size(203, 161);
            this.tbFSource.TabIndex = 0;
            // 
            // tbFMessage
            // 
            this.tbFMessage.Location = new System.Drawing.Point(59, 349);
            this.tbFMessage.Multiline = true;
            this.tbFMessage.Name = "tbFMessage";
            this.tbFMessage.Size = new System.Drawing.Size(582, 60);
            this.tbFMessage.TabIndex = 1;
            // 
            // btnFStart
            // 
            this.btnFStart.Location = new System.Drawing.Point(421, 170);
            this.btnFStart.Name = "btnFStart";
            this.btnFStart.Size = new System.Drawing.Size(75, 23);
            this.btnFStart.TabIndex = 2;
            this.btnFStart.Text = "button1";
            this.btnFStart.UseVisualStyleBackColor = true;
            this.btnFStart.Click += new System.EventHandler(this.btnFStart_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFStart);
            this.Controls.Add(this.tbFMessage);
            this.Controls.Add(this.tbFSource);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFSource;
        private System.Windows.Forms.TextBox tbFMessage;
        private System.Windows.Forms.Button btnFStart;
    }
}

