namespace BinaryConversionForm
{
    partial class FillStructForm
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
            this.mainContainer = new System.Windows.Forms.Panel();
            this.structSubmitBtn = new System.Windows.Forms.Button();
            this.mainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.AutoScroll = true;
            this.mainContainer.Controls.Add(this.structSubmitBtn);
            this.mainContainer.Location = new System.Drawing.Point(12, 12);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(776, 426);
            this.mainContainer.TabIndex = 0;
            // 
            // structSubmitBtn
            // 
            this.structSubmitBtn.BackColor = System.Drawing.Color.Chartreuse;
            this.structSubmitBtn.Location = new System.Drawing.Point(3, 3);
            this.structSubmitBtn.Name = "structSubmitBtn";
            this.structSubmitBtn.Size = new System.Drawing.Size(91, 30);
            this.structSubmitBtn.TabIndex = 0;
            this.structSubmitBtn.Text = "Submit";
            this.structSubmitBtn.UseVisualStyleBackColor = false;
            this.structSubmitBtn.Click += new System.EventHandler(this.structSubmitBtn_Click);
            // 
            // FillStructForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainContainer);
            this.Name = "FillStructForm";
            this.Text = "Fill Struct ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FillStructForm_FormClosing);
            this.mainContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainContainer;
        private System.Windows.Forms.Button structSubmitBtn;
    }
}