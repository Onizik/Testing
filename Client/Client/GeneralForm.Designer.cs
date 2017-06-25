namespace Client
{
    partial class GeneralForm
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
            this.userList = new System.Windows.Forms.TextBox();
            this.mainText = new System.Windows.Forms.TextBox();
            this.sendText = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonEscape = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userList
            // 
            this.userList.Location = new System.Drawing.Point(540, 38);
            this.userList.Multiline = true;
            this.userList.Name = "userList";
            this.userList.ReadOnly = true;
            this.userList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.userList.Size = new System.Drawing.Size(121, 349);
            this.userList.TabIndex = 0;
            // 
            // mainText
            // 
            this.mainText.Location = new System.Drawing.Point(12, 38);
            this.mainText.Multiline = true;
            this.mainText.Name = "mainText";
            this.mainText.ReadOnly = true;
            this.mainText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mainText.Size = new System.Drawing.Size(495, 349);
            this.mainText.TabIndex = 1;
            // 
            // sendText
            // 
            this.sendText.Location = new System.Drawing.Point(12, 414);
            this.sendText.Multiline = true;
            this.sendText.Name = "sendText";
            this.sendText.Size = new System.Drawing.Size(495, 59);
            this.sendText.TabIndex = 2;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(564, 412);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 3;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            // 
            // buttonEscape
            // 
            this.buttonEscape.Location = new System.Drawing.Point(564, 450);
            this.buttonEscape.Name = "buttonEscape";
            this.buttonEscape.Size = new System.Drawing.Size(75, 23);
            this.buttonEscape.TabIndex = 4;
            this.buttonEscape.Text = "Escape";
            this.buttonEscape.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(582, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Online";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "True Messenger";
            // 
            // GeneralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 485);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEscape);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.sendText);
            this.Controls.Add(this.mainText);
            this.Controls.Add(this.userList);
            this.Name = "GeneralForm";
            this.Text = "True messenger";
            this.Load += new System.EventHandler(this.GeneralForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox mainText;
        private System.Windows.Forms.TextBox sendText;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonEscape;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox userList;
    }
}