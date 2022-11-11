namespace Encantamientos
{
    partial class AddEnchantmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEnchantmentForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelAddTittle = new System.Windows.Forms.Label();
            this.labelEnchantmentName = new System.Windows.Forms.Label();
            this.textBoxEnchantmentName = new System.Windows.Forms.TextBox();
            this.labelEnchantmentDescription = new System.Windows.Forms.Label();
            this.textBoxEnchantmentDescription = new System.Windows.Forms.TextBox();
            this.labelPower = new System.Windows.Forms.Label();
            this.textBoxPower = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LimeGreen;
            this.groupBox1.Controls.Add(this.labelAddTittle);
            this.groupBox1.Location = new System.Drawing.Point(-4, -9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(890, 119);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // labelAddTittle
            // 
            this.labelAddTittle.AutoSize = true;
            this.labelAddTittle.Font = new System.Drawing.Font("Minecraft", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddTittle.Location = new System.Drawing.Point(230, 30);
            this.labelAddTittle.Name = "labelAddTittle";
            this.labelAddTittle.Size = new System.Drawing.Size(442, 61);
            this.labelAddTittle.TabIndex = 0;
            this.labelAddTittle.Text = "Properties";
            this.labelAddTittle.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelEnchantmentName
            // 
            this.labelEnchantmentName.AutoSize = true;
            this.labelEnchantmentName.Font = new System.Drawing.Font("Minecraft", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnchantmentName.Location = new System.Drawing.Point(9, 140);
            this.labelEnchantmentName.Name = "labelEnchantmentName";
            this.labelEnchantmentName.Size = new System.Drawing.Size(260, 23);
            this.labelEnchantmentName.TabIndex = 1;
            this.labelEnchantmentName.Text = "Enchantment Name";
            // 
            // textBoxEnchantmentName
            // 
            this.textBoxEnchantmentName.Font = new System.Drawing.Font("Minecraft", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEnchantmentName.Location = new System.Drawing.Point(313, 136);
            this.textBoxEnchantmentName.Name = "textBoxEnchantmentName";
            this.textBoxEnchantmentName.Size = new System.Drawing.Size(342, 30);
            this.textBoxEnchantmentName.TabIndex = 2;
            this.textBoxEnchantmentName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelEnchantmentDescription
            // 
            this.labelEnchantmentDescription.AutoSize = true;
            this.labelEnchantmentDescription.Font = new System.Drawing.Font("Minecraft", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnchantmentDescription.Location = new System.Drawing.Point(42, 311);
            this.labelEnchantmentDescription.Name = "labelEnchantmentDescription";
            this.labelEnchantmentDescription.Size = new System.Drawing.Size(170, 23);
            this.labelEnchantmentDescription.TabIndex = 3;
            this.labelEnchantmentDescription.Text = "Description";
            // 
            // textBoxEnchantmentDescription
            // 
            this.textBoxEnchantmentDescription.Font = new System.Drawing.Font("Minecraft", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEnchantmentDescription.Location = new System.Drawing.Point(313, 241);
            this.textBoxEnchantmentDescription.Multiline = true;
            this.textBoxEnchantmentDescription.Name = "textBoxEnchantmentDescription";
            this.textBoxEnchantmentDescription.Size = new System.Drawing.Size(342, 171);
            this.textBoxEnchantmentDescription.TabIndex = 4;
            this.textBoxEnchantmentDescription.TextChanged += new System.EventHandler(this.textBoxEnchantmentDescription_TextChanged);
            // 
            // labelPower
            // 
            this.labelPower.AutoSize = true;
            this.labelPower.Font = new System.Drawing.Font("Minecraft", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPower.Location = new System.Drawing.Point(61, 478);
            this.labelPower.Name = "labelPower";
            this.labelPower.Size = new System.Drawing.Size(151, 23);
            this.labelPower.TabIndex = 5;
            this.labelPower.Text = "Max Power";
            // 
            // textBoxPower
            // 
            this.textBoxPower.Font = new System.Drawing.Font("Minecraft", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPower.Location = new System.Drawing.Point(313, 478);
            this.textBoxPower.Name = "textBoxPower";
            this.textBoxPower.Size = new System.Drawing.Size(342, 30);
            this.textBoxPower.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minecraft", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 582);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Max Power";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Minecraft", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(313, 575);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(342, 30);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.Font = new System.Drawing.Font("Minecraft", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(728, 310);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(126, 119);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // AddEnchantmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(883, 654);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPower);
            this.Controls.Add(this.labelPower);
            this.Controls.Add(this.textBoxEnchantmentDescription);
            this.Controls.Add(this.labelEnchantmentDescription);
            this.Controls.Add(this.textBoxEnchantmentName);
            this.Controls.Add(this.labelEnchantmentName);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddEnchantmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEnchantmentForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddEnchantmentForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelAddTittle;
        private System.Windows.Forms.Label labelEnchantmentName;
        private System.Windows.Forms.TextBox textBoxEnchantmentName;
        private System.Windows.Forms.Label labelEnchantmentDescription;
        private System.Windows.Forms.TextBox textBoxEnchantmentDescription;
        private System.Windows.Forms.Label labelPower;
        private System.Windows.Forms.TextBox textBoxPower;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonAdd;
    }
}