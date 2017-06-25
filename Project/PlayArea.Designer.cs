namespace Zero_n_Cross
{
    partial class PlayArea
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PlayArea_label_text = new System.Windows.Forms.Label();
            this.Lag_label_text = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 18;
            this.dataGridView1.Size = new System.Drawing.Size(226, 217);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(279, 27);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 217);
            this.textBox1.TabIndex = 1;
            // 
            // PlayArea_label_text
            // 
            this.PlayArea_label_text.AutoSize = true;
            this.PlayArea_label_text.Location = new System.Drawing.Point(13, 8);
            this.PlayArea_label_text.Name = "PlayArea_label_text";
            this.PlayArea_label_text.Size = new System.Drawing.Size(54, 13);
            this.PlayArea_label_text.TabIndex = 2;
            this.PlayArea_label_text.Text = "Play area:";
            // 
            // Lag_label_text
            // 
            this.Lag_label_text.AutoSize = true;
            this.Lag_label_text.Location = new System.Drawing.Point(276, 9);
            this.Lag_label_text.Name = "Lag_label_text";
            this.Lag_label_text.Size = new System.Drawing.Size(28, 13);
            this.Lag_label_text.TabIndex = 3;
            this.Lag_label_text.Text = "Log:";
            // 
            // PlayArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 256);
            this.Controls.Add(this.Lag_label_text);
            this.Controls.Add(this.PlayArea_label_text);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PlayArea";
            this.Text = "PlayArea";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label PlayArea_label_text;
        private System.Windows.Forms.Label Lag_label_text;
    }
}