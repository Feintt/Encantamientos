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
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxEnchantmentDescription = new System.Windows.Forms.TextBox();
            this.labelPower = new System.Windows.Forms.Label();
            this.textBoxPower = new System.Windows.Forms.TextBox();
            this.labelTreasure = new System.Windows.Forms.Label();
            this.textBoxTreasure = new System.Windows.Forms.TextBox();
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
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Minecraft", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(42, 311);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(170, 23);
            this.labelDescription.TabIndex = 3;
            this.labelDescription.Text = "Description";
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
            this.textBoxPower.Size = new System.Drawing.Size(40, 30);
            this.textBoxPower.TabIndex = 6;
            this.textBoxPower.TextChanged += new System.EventHandler(this.textBoxPower_TextChanged);
            this.textBoxPower.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPower_KeyPress);
            // 
            // labelTreasure
            // 
            this.labelTreasure.AutoSize = true;
            this.labelTreasure.Font = new System.Drawing.Font("Minecraft", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTreasure.Location = new System.Drawing.Point(12, 582);
            this.labelTreasure.Name = "labelTreasure";
            this.labelTreasure.Size = new System.Drawing.Size(270, 23);
            this.labelTreasure.TabIndex = 7;
            this.labelTreasure.Text = "Found as treasure";
            // 
            // textBoxTreasure
            // 
            this.textBoxTreasure.Font = new System.Drawing.Font("Minecraft", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTreasure.Location = new System.Drawing.Point(313, 575);
            this.textBoxTreasure.Name = "textBoxTreasure";
            this.textBoxTreasure.Size = new System.Drawing.Size(40, 30);
            this.textBoxTreasure.TabIndex = 8;
            this.textBoxTreasure.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.textBoxTreasure.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTreasure_KeyPress);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.White;
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.Enabled = false;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Font = new System.Drawing.Font("Minecraft", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(728, 310);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(126, 119);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // AddEnchantmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(883, 654);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxTreasure);
            this.Controls.Add(this.labelTreasure);
            this.Controls.Add(this.textBoxPower);
            this.Controls.Add(this.labelPower);
            this.Controls.Add(this.textBoxEnchantmentDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxEnchantmentName);
            this.Controls.Add(this.labelEnchantmentName);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddEnchantmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEnchantmentForm";
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
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxEnchantmentDescription;
        private System.Windows.Forms.Label labelPower;
        private System.Windows.Forms.TextBox textBoxPower;
        private System.Windows.Forms.Label labelTreasure;
        private System.Windows.Forms.TextBox textBoxTreasure;
        private System.Windows.Forms.Button buttonAdd;
    }
}