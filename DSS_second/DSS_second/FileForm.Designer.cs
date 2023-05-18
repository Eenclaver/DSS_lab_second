namespace DSS_second
{
    partial class FileForm
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
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_upload = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.returnButton = new System.Windows.Forms.Button();
            this.bt_result = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(128, 14);
            this.bt_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(108, 53);
            this.bt_save.TabIndex = 24;
            this.bt_save.Text = "Сохранить данные";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_upload
            // 
            this.bt_upload.Location = new System.Drawing.Point(15, 14);
            this.bt_upload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_upload.Name = "bt_upload";
            this.bt_upload.Size = new System.Drawing.Size(108, 53);
            this.bt_upload.TabIndex = 23;
            this.bt_upload.Text = "Загрузить данные";
            this.bt_upload.UseVisualStyleBackColor = true;
            this.bt_upload.Click += new System.EventHandler(this.bt_upload_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // saveFile
            // 
            this.saveFile.DefaultExt = "txt";
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(356, 14);
            this.returnButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(108, 53);
            this.returnButton.TabIndex = 25;
            this.returnButton.Text = "Вернуться";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // bt_result
            // 
            this.bt_result.Location = new System.Drawing.Point(242, 14);
            this.bt_result.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_result.Name = "bt_result";
            this.bt_result.Size = new System.Drawing.Size(108, 53);
            this.bt_result.TabIndex = 26;
            this.bt_result.Text = "Сохранить результат";
            this.bt_result.UseVisualStyleBackColor = true;
            this.bt_result.Click += new System.EventHandler(this.bt_result_Click);
            // 
            // FileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 75);
            this.ControlBox = false;
            this.Controls.Add(this.bt_result);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.bt_upload);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FileForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Работа с файлами";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_upload;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button bt_result;
    }
}