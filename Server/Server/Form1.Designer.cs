namespace Server
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.controlButtonsGroupBox = new System.Windows.Forms.GroupBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.chattingGroupBox = new System.Windows.Forms.GroupBox();
            this.sendMessageButton = new System.Windows.Forms.Button();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.chattingHistoryTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.controlButtonsGroupBox.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.chattingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.controlButtonsGroupBox, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(435, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.28347F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.71654F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(243, 519);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.logTextBox);
            this.groupBox1.Location = new System.Drawing.Point(3, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 346);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log area";
            // 
            // logTextBox
            // 
            this.logTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logTextBox.Location = new System.Drawing.Point(7, 20);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.Size = new System.Drawing.Size(216, 320);
            this.logTextBox.TabIndex = 0;
            // 
            // controlButtonsGroupBox
            // 
            this.controlButtonsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlButtonsGroupBox.Controls.Add(this.exitButton);
            this.controlButtonsGroupBox.Controls.Add(this.stopButton);
            this.controlButtonsGroupBox.Controls.Add(this.startButton);
            this.controlButtonsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.controlButtonsGroupBox.Name = "controlButtonsGroupBox";
            this.controlButtonsGroupBox.Size = new System.Drawing.Size(237, 161);
            this.controlButtonsGroupBox.TabIndex = 1;
            this.controlButtonsGroupBox.TabStop = false;
            this.controlButtonsGroupBox.Text = "Control buttons";
            // 
            // exitButton
            // 
            this.exitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exitButton.Location = new System.Drawing.Point(46, 102);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(142, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Close & Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // stopButton
            // 
            this.stopButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stopButton.Location = new System.Drawing.Point(46, 72);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(142, 23);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "Server stop";
            this.stopButton.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startButton.Location = new System.Drawing.Point(46, 42);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(142, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Server start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.chattingGroupBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(421, 519);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // chattingGroupBox
            // 
            this.chattingGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chattingGroupBox.Controls.Add(this.sendMessageButton);
            this.chattingGroupBox.Controls.Add(this.messageTextBox);
            this.chattingGroupBox.Controls.Add(this.chattingHistoryTextBox);
            this.chattingGroupBox.Location = new System.Drawing.Point(3, 3);
            this.chattingGroupBox.Name = "chattingGroupBox";
            this.chattingGroupBox.Size = new System.Drawing.Size(412, 513);
            this.chattingGroupBox.TabIndex = 0;
            this.chattingGroupBox.TabStop = false;
            this.chattingGroupBox.Text = "ChattingArea";
            // 
            // sendMessageButton
            // 
            this.sendMessageButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sendMessageButton.Location = new System.Drawing.Point(6, 484);
            this.sendMessageButton.Name = "sendMessageButton";
            this.sendMessageButton.Size = new System.Drawing.Size(400, 23);
            this.sendMessageButton.TabIndex = 2;
            this.sendMessageButton.Text = "Send";
            this.sendMessageButton.UseVisualStyleBackColor = true;
            // 
            // messageTextBox
            // 
            this.messageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.messageTextBox.Location = new System.Drawing.Point(6, 436);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(400, 42);
            this.messageTextBox.TabIndex = 1;
            this.messageTextBox.Enter += new System.EventHandler(this.MessageTextBox_Enter);
            this.messageTextBox.Leave += new System.EventHandler(this.messageTextBox_Leave);
            // 
            // chattingHistoryTextBox
            // 
            this.chattingHistoryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chattingHistoryTextBox.Location = new System.Drawing.Point(6, 19);
            this.chattingHistoryTextBox.Multiline = true;
            this.chattingHistoryTextBox.Name = "chattingHistoryTextBox";
            this.chattingHistoryTextBox.ReadOnly = true;
            this.chattingHistoryTextBox.Size = new System.Drawing.Size(400, 411);
            this.chattingHistoryTextBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 530);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(698, 569);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(698, 569);
            this.Name = "MainForm";
            this.Text = "Server";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.controlButtonsGroupBox.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.chattingGroupBox.ResumeLayout(false);
            this.chattingGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.GroupBox controlButtonsGroupBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox chattingGroupBox;
        private System.Windows.Forms.Button sendMessageButton;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.TextBox chattingHistoryTextBox;
    }
}

