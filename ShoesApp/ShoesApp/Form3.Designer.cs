namespace ShoesApp
{
    partial class Form3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxPriceClient = new System.Windows.Forms.TextBox();
            this.textBoxObservacion = new System.Windows.Forms.TextBox();
            this.textBoxPriceMember = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.textBoxAdd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(761, 103);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBoxPriceClient
            // 
            this.textBoxPriceClient.Location = new System.Drawing.Point(163, 356);
            this.textBoxPriceClient.Name = "textBoxPriceClient";
            this.textBoxPriceClient.Size = new System.Drawing.Size(100, 26);
            this.textBoxPriceClient.TabIndex = 40;
            // 
            // textBoxObservacion
            // 
            this.textBoxObservacion.Location = new System.Drawing.Point(163, 311);
            this.textBoxObservacion.Name = "textBoxObservacion";
            this.textBoxObservacion.Size = new System.Drawing.Size(100, 26);
            this.textBoxObservacion.TabIndex = 39;
            // 
            // textBoxPriceMember
            // 
            this.textBoxPriceMember.Location = new System.Drawing.Point(163, 399);
            this.textBoxPriceMember.Name = "textBoxPriceMember";
            this.textBoxPriceMember.Size = new System.Drawing.Size(100, 26);
            this.textBoxPriceMember.TabIndex = 38;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(163, 259);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(100, 26);
            this.textBoxTitle.TabIndex = 37;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(65, 265);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 20);
            this.label13.TabIndex = 36;
            this.label13.Text = "Title";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(65, 314);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 20);
            this.label12.TabIndex = 35;
            this.label12.Text = "Observacion";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(51, 362);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 20);
            this.label11.TabIndex = 34;
            this.label11.Text = "Precio Cliente";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 405);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 20);
            this.label9.TabIndex = 33;
            this.label9.Text = "Precio miembro";
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Location = new System.Drawing.Point(163, 212);
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(156, 26);
            this.textBoxDesc.TabIndex = 32;
            // 
            // textBoxAdd
            // 
            this.textBoxAdd.Location = new System.Drawing.Point(163, 152);
            this.textBoxAdd.Name = "textBoxAdd";
            this.textBoxAdd.Size = new System.Drawing.Size(100, 26);
            this.textBoxAdd.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Nombre";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxPriceClient);
            this.Controls.Add(this.textBoxObservacion);
            this.Controls.Add(this.textBoxPriceMember);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.textBoxAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxPriceClient;
        private System.Windows.Forms.TextBox textBoxObservacion;
        private System.Windows.Forms.TextBox textBoxPriceMember;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.TextBox textBoxAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
    }
}