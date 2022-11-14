namespace Encantamientos
{
    partial class EditEnchantmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditEnchantmentForm));
            this.groupBoxTittle = new System.Windows.Forms.GroupBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.buttoEdit = new System.Windows.Forms.Button();
            this.textBoxTreasure = new System.Windows.Forms.TextBox();
            this.labelTreasure = new System.Windows.Forms.Label();
            this.textBoxPower = new System.Windows.Forms.TextBox();
            this.labelPower = new System.Windows.Forms.Label();
            this.textBoxEnchantmentDescription = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxEnchantmentName = new System.Windows.Forms.TextBox();
            this.labelEnchantmentName = new System.Windows.Forms.Label();
            this.groupBoxTittle.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTittle
            // 
            this.groupBoxTittle.BackColor = System.Drawing.Color.LimeGreen;
            this.groupBoxTittle.Controls.Add(this.labelTitle);
            this.groupBoxTittle.Location = new System.Drawing.Point(-4, -7);
            this.groupBoxTittle.Name = "groupBoxTittle";
            this.groupBoxTittle.Size = new System.Drawing.Size(891, 119);
            this.groupBoxTittle.TabIndex = 0;
            this.groupBoxTittle.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Minecraft", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(282, 30);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(319, 61);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "EDITING";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Minecraft", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(323, 166);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 21);
            this.labelError.TabIndex = 20;
            // 
            // buttoEdit
            // 
            this.buttoEdit.BackColor = System.Drawing.Color.White;
            this.buttoEdit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttoEdit.FlatAppearance.BorderSize = 0;
            this.buttoEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttoEdit.Font = new System.Drawing.Font("Minecraft", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoEdit.Location = new System.Drawing.Point(738, 303);
            this.buttoEdit.Name = "buttoEdit";
            this.buttoEdit.Size = new System.Drawing.Size(126, 119);
            this.buttoEdit.TabIndex = 19;
            this.buttoEdit.Text = "Save";
            this.buttoEdit.UseVisualStyleBackColor = false;
            this.buttoEdit.Click += new System.EventHandler(this.buttoEdit_Click);
            // 
            // textBoxTreasure
            // 
            this.textBoxTreasure.Font = new System.Drawing.Font("Minecraft", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTreasure.Location = new System.Drawing.Point(323, 568);
            this.textBoxTreasure.MaxLength = 3;
            this.textBoxTreasure.Name = "textBoxTreasure";
            this.textBoxTreasure.Size = new System.Drawing.Size(66, 30);
            this.textBoxTreasure.TabIndex = 18;
            this.textBoxTreasure.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelTreasure
            // 
            this.labelTreasure.AutoSize = true;
            this.labelTreasure.Font = new System.Drawing.Font("Minecraft", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTreasure.Location = new System.Drawing.Point(22, 575);
            this.labelTreasure.Name = "labelTreasure";
            this.labelTreasure.Size = new System.Drawing.Size(270, 23);
            this.labelTreasure.TabIndex = 17;
            this.labelTreasure.Text = "Found as treasure";
            // 
            // textBoxPower
            // 
            this.textBoxPower.Font = new System.Drawing.Font("Minecraft", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPower.Location = new System.Drawing.Point(323, 471);
            this.textBoxPower.Name = "textBoxPower";
            this.textBoxPower.Size = new System.Drawing.Size(40, 30);
            this.textBoxPower.TabIndex = 16;
            this.textBoxPower.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelPower
            // 
            this.labelPower.AutoSize = true;
            this.labelPower.Font = new System.Drawing.Font("Minecraft", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPower.Location = new System.Drawing.Point(71, 471);
            this.labelPower.Name = "labelPower";
            this.labelPower.Size = new System.Drawing.Size(151, 23);
            this.labelPower.TabIndex = 15;
            this.labelPower.Text = "Max Power";
            // 
            // textBoxEnchantmentDescription
            // 
            this.textBoxEnchantmentDescription.Font = new System.Drawing.Font("Minecraft", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEnchantmentDescription.Location = new System.Drawing.Point(323, 234);
            this.textBoxEnchantmentDescription.Multiline = true;
            this.textBoxEnchantmentDescription.Name = "textBoxEnchantmentDescription";
            this.textBoxEnchantmentDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxEnchantmentDescription.Size = new System.Drawing.Size(342, 171);
            this.textBoxEnchantmentDescription.TabIndex = 14;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Minecraft", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(52, 304);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(170, 23);
            this.labelDescription.TabIndex = 13;
            this.labelDescription.Text = "Description";
            // 
            // textBoxEnchantmentName
            // 
            this.textBoxEnchantmentName.Font = new System.Drawing.Font("Minecraft", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEnchantmentName.Location = new System.Drawing.Point(323, 129);
            this.textBoxEnchantmentName.Name = "textBoxEnchantmentName";
            this.textBoxEnchantmentName.Size = new System.Drawing.Size(342, 30);
            this.textBoxEnchantmentName.TabIndex = 12;
            // 
            // labelEnchantmentName
            // 
            this.labelEnchantmentName.AutoSize = true;
            this.labelEnchantmentName.Font = new System.Drawing.Font("Minecraft", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnchantmentName.Location = new System.Drawing.Point(19, 133);
            this.labelEnchantmentName.Name = "labelEnchantmentName";
            this.labelEnchantmentName.Size = new System.Drawing.Size(260, 23);
            this.labelEnchantmentName.TabIndex = 11;
            this.labelEnchantmentName.Text = "Enchantment Name";
            // 
            // EditEnchantmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(883, 654);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttoEdit);
            this.Controls.Add(this.textBoxTreasure);
            this.Controls.Add(this.labelTreasure);
            this.Controls.Add(this.textBoxPower);
            this.Controls.Add(this.labelPower);
            this.Controls.Add(this.textBoxEnchantmentDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxEnchantmentName);
            this.Controls.Add(this.labelEnchantmentName);
            this.Controls.Add(this.groupBoxTittle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditEnchantmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBoxTittle.ResumeLayout(false);
            this.groupBoxTittle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTittle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button buttoEdit;
        private System.Windows.Forms.TextBox textBoxTreasure;
        private System.Windows.Forms.Label labelTreasure;
        private System.Windows.Forms.TextBox textBoxPower;
        private System.Windows.Forms.Label labelPower;
        private System.Windows.Forms.TextBox textBoxEnchantmentDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxEnchantmentName;
        private System.Windows.Forms.Label labelEnchantmentName;
    }
}