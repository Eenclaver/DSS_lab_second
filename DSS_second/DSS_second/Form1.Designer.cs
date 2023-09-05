namespace DSS_second
{
    partial class StartForm
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
            this.bt_Create = new System.Windows.Forms.Button();
            this.tb_lines = new System.Windows.Forms.TextBox();
            this.cb_welcome = new System.Windows.Forms.CheckBox();
            this.tb_columns = new System.Windows.Forms.TextBox();
            this.dgw_Matrix = new System.Windows.Forms.DataGridView();
            this.bt_del = new System.Windows.Forms.Button();
            this.bt_fileWork = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Matrix)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Create
            // 
            this.bt_Create.Location = new System.Drawing.Point(242, 92);
            this.bt_Create.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Create.Name = "bt_Create";
            this.bt_Create.Size = new System.Drawing.Size(89, 47);
            this.bt_Create.TabIndex = 0;
            this.bt_Create.Text = "создать массив";
            this.bt_Create.UseVisualStyleBackColor = true;
            this.bt_Create.Click += new System.EventHandler(this.bt_Create_Click);
            // 
            // tb_lines
            // 
            this.tb_lines.Location = new System.Drawing.Point(99, 57);
            this.tb_lines.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_lines.Name = "tb_lines";
            this.tb_lines.Size = new System.Drawing.Size(100, 22);
            this.tb_lines.TabIndex = 1;
            this.tb_lines.TextChanged += new System.EventHandler(this.tb_TextChanged);
            this.tb_lines.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputMask);
            // 
            // cb_welcome
            // 
            this.cb_welcome.AutoSize = true;
            this.cb_welcome.Location = new System.Drawing.Point(12, 12);
            this.cb_welcome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_welcome.Name = "cb_welcome";
            this.cb_welcome.Size = new System.Drawing.Size(114, 20);
            this.cb_welcome.TabIndex = 2;
            this.cb_welcome.Text = "приветствие";
            this.cb_welcome.UseVisualStyleBackColor = true;
            this.cb_welcome.CheckedChanged += new System.EventHandler(this.cb_Welcome_CheckedChanged);
            // 
            // tb_columns
            // 
            this.tb_columns.Location = new System.Drawing.Point(231, 57);
            this.tb_columns.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_columns.Name = "tb_columns";
            this.tb_columns.Size = new System.Drawing.Size(100, 22);
            this.tb_columns.TabIndex = 4;
            this.tb_columns.TextChanged += new System.EventHandler(this.tb_TextChanged);
            this.tb_columns.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputMask);
            // 
            // dgw_Matrix
            // 
            this.dgw_Matrix.AllowUserToAddRows = false;
            this.dgw_Matrix.AllowUserToDeleteRows = false;
            this.dgw_Matrix.AllowUserToOrderColumns = true;
            this.dgw_Matrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Matrix.Location = new System.Drawing.Point(385, 15);
            this.dgw_Matrix.Margin = new System.Windows.Forms.Padding(4);
            this.dgw_Matrix.Name = "dgw_Matrix";
            this.dgw_Matrix.RowHeadersWidth = 51;
            this.dgw_Matrix.Size = new System.Drawing.Size(353, 227);
            this.dgw_Matrix.TabIndex = 5;
            // 
            // bt_del
            // 
            this.bt_del.Location = new System.Drawing.Point(12, 153);
            this.bt_del.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_del.Name = "bt_del";
            this.bt_del.Size = new System.Drawing.Size(168, 89);
            this.bt_del.TabIndex = 6;
            this.bt_del.Text = "Удалить все повторяющиеся элементы";
            this.bt_del.UseVisualStyleBackColor = true;
            this.bt_del.Click += new System.EventHandler(this.bt_del_Click);
            // 
            // bt_fileWork
            // 
            this.bt_fileWork.Location = new System.Drawing.Point(206, 153);
            this.bt_fileWork.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_fileWork.Name = "bt_fileWork";
            this.bt_fileWork.Size = new System.Drawing.Size(172, 89);
            this.bt_fileWork.TabIndex = 7;
            this.bt_fileWork.Text = "Сохранить/Загрузить данные";
            this.bt_fileWork.UseVisualStyleBackColor = true;
            this.bt_fileWork.Click += new System.EventHandler(this.bt_fileWork_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 255);
            this.ControlBox = false;
            this.Controls.Add(this.bt_fileWork);
            this.Controls.Add(this.bt_del);
            this.Controls.Add(this.dgw_Matrix);
            this.Controls.Add(this.tb_columns);
            this.Controls.Add(this.cb_welcome);
            this.Controls.Add(this.tb_lines);
            this.Controls.Add(this.bt_Create);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Matrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Create;
        private System.Windows.Forms.TextBox tb_lines;
        private System.Windows.Forms.CheckBox cb_welcome;
        private System.Windows.Forms.TextBox tb_columns;
        private System.Windows.Forms.DataGridView dgw_Matrix;
        private System.Windows.Forms.Button bt_del;
        private System.Windows.Forms.Button bt_fileWork;
    }
}

