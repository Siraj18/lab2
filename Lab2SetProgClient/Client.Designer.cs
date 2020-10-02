namespace Lab2SetProgClient
{
	partial class Client
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
			this.components = new System.ComponentModel.Container();
			this.nicknameData = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.enterChat = new System.Windows.Forms.Button();
			this.userList = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.messageData = new System.Windows.Forms.TextBox();
			this.userMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.nameData = new System.Windows.Forms.Label();
			this.chatBox = new System.Windows.Forms.RichTextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// nicknameData
			// 
			this.nicknameData.Location = new System.Drawing.Point(352, 9);
			this.nicknameData.Name = "nicknameData";
			this.nicknameData.Size = new System.Drawing.Size(182, 22);
			this.nicknameData.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(130, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(216, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "Для подключения введите ник:";
			// 
			// enterChat
			// 
			this.enterChat.Location = new System.Drawing.Point(540, 8);
			this.enterChat.Name = "enterChat";
			this.enterChat.Size = new System.Drawing.Size(150, 23);
			this.enterChat.TabIndex = 3;
			this.enterChat.Text = "Подключиться";
			this.enterChat.UseVisualStyleBackColor = true;
			this.enterChat.Click += new System.EventHandler(this.enterChat_Click_1);
			// 
			// userList
			// 
			this.userList.FormattingEnabled = true;
			this.userList.ItemHeight = 16;
			this.userList.Location = new System.Drawing.Point(540, 60);
			this.userList.Name = "userList";
			this.userList.Size = new System.Drawing.Size(150, 356);
			this.userList.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(530, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(163, 17);
			this.label2.TabIndex = 5;
			this.label2.Text = "Список пользователей:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 87);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(33, 17);
			this.label3.TabIndex = 7;
			this.label3.Text = "Чат";
			// 
			// messageData
			// 
			this.messageData.Location = new System.Drawing.Point(12, 394);
			this.messageData.Name = "messageData";
			this.messageData.Size = new System.Drawing.Size(522, 22);
			this.messageData.TabIndex = 8;
			this.messageData.KeyUp += new System.Windows.Forms.KeyEventHandler(this.messageData_KeyUp_1);
			// 
			// userMenu
			// 
			this.userMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.userMenu.Name = "userMenu";
			this.userMenu.Size = new System.Drawing.Size(61, 4);
			// 
			// nameData
			// 
			this.nameData.AutoSize = true;
			this.nameData.Location = new System.Drawing.Point(78, 87);
			this.nameData.Name = "nameData";
			this.nameData.Size = new System.Drawing.Size(46, 17);
			this.nameData.TabIndex = 10;
			this.nameData.Text = "label4";
			// 
			// chatBox
			// 
			this.chatBox.Location = new System.Drawing.Point(12, 107);
			this.chatBox.Name = "chatBox";
			this.chatBox.Size = new System.Drawing.Size(522, 281);
			this.chatBox.TabIndex = 11;
			this.chatBox.Text = "";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(112, 62);
			this.button1.TabIndex = 0;
			this.button1.Text = "Запустить Сервер";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Client
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(705, 487);
			this.Controls.Add(this.chatBox);
			this.Controls.Add(this.nameData);
			this.Controls.Add(this.messageData);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.userList);
			this.Controls.Add(this.enterChat);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.nicknameData);
			this.Controls.Add(this.button1);
			this.Name = "Client";
			this.Text = "Client";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client_FormClosing);
			this.Load += new System.EventHandler(this.Client_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox nicknameData;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button enterChat;
		private System.Windows.Forms.ListBox userList;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox messageData;
		private System.Windows.Forms.ContextMenuStrip userMenu;
		private System.Windows.Forms.Label nameData;
		private System.Windows.Forms.RichTextBox chatBox;
		private System.Windows.Forms.Button button1;
	}
}