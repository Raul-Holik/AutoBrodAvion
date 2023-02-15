namespace AutoBrodAvion
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
            this.txtBxMarka = new System.Windows.Forms.TextBox();
            this.txtBxModel = new System.Windows.Forms.TextBox();
            this.txtBx3 = new System.Windows.Forms.TextBox();
            this.cmbVrsta = new System.Windows.Forms.ComboBox();
            this.btnUnos = new System.Windows.Forms.Button();
            this.btnIspis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnObrada = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBxMarka
            // 
            this.txtBxMarka.Location = new System.Drawing.Point(54, 52);
            this.txtBxMarka.Name = "txtBxMarka";
            this.txtBxMarka.Size = new System.Drawing.Size(100, 20);
            this.txtBxMarka.TabIndex = 0;
            this.txtBxMarka.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtBxModel
            // 
            this.txtBxModel.Location = new System.Drawing.Point(54, 90);
            this.txtBxModel.Name = "txtBxModel";
            this.txtBxModel.Size = new System.Drawing.Size(100, 20);
            this.txtBxModel.TabIndex = 1;
            // 
            // txtBx3
            // 
            this.txtBx3.Location = new System.Drawing.Point(379, 37);
            this.txtBx3.Multiline = true;
            this.txtBx3.Name = "txtBx3";
            this.txtBx3.Size = new System.Drawing.Size(297, 166);
            this.txtBx3.TabIndex = 2;
            // 
            // cmbVrsta
            // 
            this.cmbVrsta.FormattingEnabled = true;
            this.cmbVrsta.Items.AddRange(new object[] {
            "Avion",
            "Auto",
            "Brod"});
            this.cmbVrsta.Location = new System.Drawing.Point(54, 133);
            this.cmbVrsta.Name = "cmbVrsta";
            this.cmbVrsta.Size = new System.Drawing.Size(121, 21);
            this.cmbVrsta.TabIndex = 3;
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(73, 323);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(75, 23);
            this.btnUnos.TabIndex = 4;
            this.btnUnos.Text = "Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // btnIspis
            // 
            this.btnIspis.Location = new System.Drawing.Point(601, 323);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(75, 23);
            this.btnIspis.TabIndex = 5;
            this.btnIspis.Text = "Ispis";
            this.btnIspis.UseVisualStyleBackColor = true;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Marka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Model";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(624, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Vrsta";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnObrada
            // 
            this.btnObrada.Location = new System.Drawing.Point(379, 322);
            this.btnObrada.Name = "btnObrada";
            this.btnObrada.Size = new System.Drawing.Size(75, 23);
            this.btnObrada.TabIndex = 10;
            this.btnObrada.Text = "Obrada";
            this.btnObrada.UseVisualStyleBackColor = true;
            this.btnObrada.Click += new System.EventHandler(this.btnObrada_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnObrada);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIspis);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.cmbVrsta);
            this.Controls.Add(this.txtBx3);
            this.Controls.Add(this.txtBxModel);
            this.Controls.Add(this.txtBxMarka);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxMarka;
        private System.Windows.Forms.TextBox txtBxModel;
        private System.Windows.Forms.TextBox txtBx3;
        private System.Windows.Forms.ComboBox cmbVrsta;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button btnIspis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnObrada;
    }
}

