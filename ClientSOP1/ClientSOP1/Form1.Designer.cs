namespace ClientSOP
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMT = new System.Windows.Forms.TextBox();
            this.btnConvertion = new System.Windows.Forms.Button();
            this.btnComptes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRes = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Montant";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxMT
            // 
            this.textBoxMT.Location = new System.Drawing.Point(123, 23);
            this.textBoxMT.Name = "textBoxMT";
            this.textBoxMT.Size = new System.Drawing.Size(100, 20);
            this.textBoxMT.TabIndex = 1;
            this.textBoxMT.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnConvertion
            // 
            this.btnConvertion.Location = new System.Drawing.Point(304, 23);
            this.btnConvertion.Name = "btnConvertion";
            this.btnConvertion.Size = new System.Drawing.Size(75, 23);
            this.btnConvertion.TabIndex = 2;
            this.btnConvertion.Text = "Convertion";
            this.btnConvertion.UseVisualStyleBackColor = true;
            this.btnConvertion.Click += new System.EventHandler(this.btnConvertion_Click);
            // 
            // btnComptes
            // 
            this.btnComptes.Location = new System.Drawing.Point(434, 21);
            this.btnComptes.Name = "btnComptes";
            this.btnComptes.Size = new System.Drawing.Size(75, 23);
            this.btnComptes.TabIndex = 3;
            this.btnComptes.Text = "Comptes";
            this.btnComptes.UseVisualStyleBackColor = true;
            this.btnComptes.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Resultat";
            // 
            // textBoxRes
            // 
            this.textBoxRes.Location = new System.Drawing.Point(123, 117);
            this.textBoxRes.Name = "textBoxRes";
            this.textBoxRes.Size = new System.Drawing.Size(100, 20);
            this.textBoxRes.TabIndex = 5;
            this.textBoxRes.Text = "=";
            this.textBoxRes.TextChanged += new System.EventHandler(this.textBoxRes_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(257, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(252, 150);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 261);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxRes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnComptes);
            this.Controls.Add(this.btnConvertion);
            this.Controls.Add(this.textBoxMT);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMT;
        private System.Windows.Forms.Button btnConvertion;
        private System.Windows.Forms.Button btnComptes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRes;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

