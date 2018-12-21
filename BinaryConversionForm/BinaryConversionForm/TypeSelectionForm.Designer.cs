namespace BinaryConversionForm
{
    partial class TypeSelectionForm
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
            this.structTypeCB = new System.Windows.Forms.ComboBox();
            this.addTypeBtn = new System.Windows.Forms.Button();
            this.mainContainer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // structTypeCB
            // 
            this.structTypeCB.FormattingEnabled = true;
            this.structTypeCB.Items.AddRange(new object[] {
            "AutoRecord",
            "CheckRec",
            "DspStateTable",
            "FgenDataVerifyStruct",
            "ImdPtrU",
            "LEALFileHeader",
            "LimRec",
            "ModeDirectory",
            "PwfAmpsEntry",
            "PwfAmpsTable",
            "PwfCategory",
            "PwfCategoryString",
            "PwfControl",
            "PwfEDSHeader",
            "PwfEDSRec",
            "PwfExposed",
            "PwfFat",
            "PwfFilter",
            "PwfKey",
            "PwfProcInfo",
            "PwfState",
            "PwfSynergicWFSRec",
            "PwfSystemType",
            "PwfWireType",
            "PWZCompressed",
            "PWZHeader",
            "RegRec",
            "SfRec",
            "TouchRetract",
            "WfsControlRec"});
            this.structTypeCB.Location = new System.Drawing.Point(12, 12);
            this.structTypeCB.Name = "structTypeCB";
            this.structTypeCB.Size = new System.Drawing.Size(183, 24);
            this.structTypeCB.TabIndex = 0;
            // 
            // addTypeBtn
            // 
            this.addTypeBtn.BackColor = System.Drawing.Color.Chartreuse;
            this.addTypeBtn.Location = new System.Drawing.Point(201, 12);
            this.addTypeBtn.Name = "addTypeBtn";
            this.addTypeBtn.Size = new System.Drawing.Size(107, 24);
            this.addTypeBtn.TabIndex = 1;
            this.addTypeBtn.Text = "Add Type";
            this.addTypeBtn.UseVisualStyleBackColor = false;
            this.addTypeBtn.Click += new System.EventHandler(this.addTypeBtn_Click);
            // 
            // mainContainer
            // 
            this.mainContainer.AutoScroll = true;
            this.mainContainer.Location = new System.Drawing.Point(12, 42);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(776, 363);
            this.mainContainer.TabIndex = 2;
            // 
            // TypeSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.addTypeBtn);
            this.Controls.Add(this.structTypeCB);
            this.Name = "TypeSelectionForm";
            this.Text = "Type Selection";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox structTypeCB;
        private System.Windows.Forms.Button addTypeBtn;
        private System.Windows.Forms.Panel mainContainer;
    }
}