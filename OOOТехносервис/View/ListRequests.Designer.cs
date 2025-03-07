﻿namespace OOOТехносервис.View
{
    partial class ListRequests
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exit_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.search_textButton = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.filter_comboBox = new System.Windows.Forms.ComboBox();
            this.dgvRequests = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newRequest_button = new System.Windows.Forms.Button();
            this.editRequest_button = new System.Windows.Forms.Button();
            this.createReport_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OOOТехносервис.Properties.Resources.repair_tools_icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(606, 21);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(78, 37);
            this.exit_button.TabIndex = 1;
            this.exit_button.Text = "Выход";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(268, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Список заявок";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Поиск (по номеру)";
            // 
            // search_textButton
            // 
            this.search_textButton.Location = new System.Drawing.Point(188, 114);
            this.search_textButton.Multiline = true;
            this.search_textButton.Name = "search_textButton";
            this.search_textButton.Size = new System.Drawing.Size(100, 20);
            this.search_textButton.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Фильтр по статусу";
            // 
            // filter_comboBox
            // 
            this.filter_comboBox.FormattingEnabled = true;
            this.filter_comboBox.Location = new System.Drawing.Point(474, 113);
            this.filter_comboBox.Name = "filter_comboBox";
            this.filter_comboBox.Size = new System.Drawing.Size(121, 21);
            this.filter_comboBox.TabIndex = 7;
            // 
            // dgvRequests
            // 
            this.dgvRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvRequests.Location = new System.Drawing.Point(48, 153);
            this.dgvRequests.Name = "dgvRequests";
            this.dgvRequests.Size = new System.Drawing.Size(604, 216);
            this.dgvRequests.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Номер заявки";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Дата";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Оборудование";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ФИО клиента";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Статус";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "ФИО мастера";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Этап выполнения";
            this.Column7.Name = "Column7";
            // 
            // newRequest_button
            // 
            this.newRequest_button.Location = new System.Drawing.Point(71, 393);
            this.newRequest_button.Name = "newRequest_button";
            this.newRequest_button.Size = new System.Drawing.Size(111, 23);
            this.newRequest_button.TabIndex = 9;
            this.newRequest_button.Text = "Новая заявка";
            this.newRequest_button.UseVisualStyleBackColor = true;
            // 
            // editRequest_button
            // 
            this.editRequest_button.Location = new System.Drawing.Point(273, 393);
            this.editRequest_button.Name = "editRequest_button";
            this.editRequest_button.Size = new System.Drawing.Size(145, 23);
            this.editRequest_button.TabIndex = 10;
            this.editRequest_button.Text = "Редактировать заявку";
            this.editRequest_button.UseVisualStyleBackColor = true;
            // 
            // createReport_button
            // 
            this.createReport_button.Location = new System.Drawing.Point(517, 393);
            this.createReport_button.Name = "createReport_button";
            this.createReport_button.Size = new System.Drawing.Size(115, 23);
            this.createReport_button.TabIndex = 11;
            this.createReport_button.Text = "Отчёт";
            this.createReport_button.UseVisualStyleBackColor = true;
            // 
            // ListRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 450);
            this.ControlBox = false;
            this.Controls.Add(this.createReport_button);
            this.Controls.Add(this.editRequest_button);
            this.Controls.Add(this.newRequest_button);
            this.Controls.Add(this.dgvRequests);
            this.Controls.Add(this.filter_comboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.search_textButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListRequests";
            this.Text = " ";
            this.Load += new System.EventHandler(this.ListRequests_Load);
            this.Shown += new System.EventHandler(this.ListRequests_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox search_textButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox filter_comboBox;
        private System.Windows.Forms.DataGridView dgvRequests;
        private System.Windows.Forms.Button newRequest_button;
        private System.Windows.Forms.Button editRequest_button;
        private System.Windows.Forms.Button createReport_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}