
namespace WordToJpg
{
    partial class Word2JpgFrm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.WordPathTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ImageFolderTextBox = new System.Windows.Forms.TextBox();
            this.SelectFileBtn = new System.Windows.Forms.Button();
            this.SelectFoldBtn = new System.Windows.Forms.Button();
            this.ConvertBtn = new System.Windows.Forms.Button();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(50, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "PDF文件路径";
            // 
            // WordPathTextBox
            // 
            this.WordPathTextBox.Location = new System.Drawing.Point(130, 26);
            this.WordPathTextBox.Multiline = true;
            this.WordPathTextBox.Name = "WordPathTextBox";
            this.WordPathTextBox.Size = new System.Drawing.Size(484, 35);
            this.WordPathTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(47, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "图片输出目录";
            // 
            // ImageFolderTextBox
            // 
            this.ImageFolderTextBox.Location = new System.Drawing.Point(130, 80);
            this.ImageFolderTextBox.Multiline = true;
            this.ImageFolderTextBox.Name = "ImageFolderTextBox";
            this.ImageFolderTextBox.Size = new System.Drawing.Size(484, 35);
            this.ImageFolderTextBox.TabIndex = 3;
            // 
            // SelectFileBtn
            // 
            this.SelectFileBtn.BackColor = System.Drawing.Color.White;
            this.SelectFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectFileBtn.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SelectFileBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.SelectFileBtn.Location = new System.Drawing.Point(620, 26);
            this.SelectFileBtn.Name = "SelectFileBtn";
            this.SelectFileBtn.Size = new System.Drawing.Size(80, 35);
            this.SelectFileBtn.TabIndex = 4;
            this.SelectFileBtn.Text = "选择文件";
            this.SelectFileBtn.UseVisualStyleBackColor = false;
            this.SelectFileBtn.Click += new System.EventHandler(this.SelectFileBtn_Click);
            // 
            // SelectFoldBtn
            // 
            this.SelectFoldBtn.BackColor = System.Drawing.Color.White;
            this.SelectFoldBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectFoldBtn.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SelectFoldBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.SelectFoldBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SelectFoldBtn.Location = new System.Drawing.Point(620, 80);
            this.SelectFoldBtn.Name = "SelectFoldBtn";
            this.SelectFoldBtn.Size = new System.Drawing.Size(80, 35);
            this.SelectFoldBtn.TabIndex = 5;
            this.SelectFoldBtn.Text = "选择目录";
            this.SelectFoldBtn.UseVisualStyleBackColor = false;
            this.SelectFoldBtn.Click += new System.EventHandler(this.SelectFoldBtn_Click);
            // 
            // ConvertBtn
            // 
            this.ConvertBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.ConvertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConvertBtn.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ConvertBtn.ForeColor = System.Drawing.Color.White;
            this.ConvertBtn.Location = new System.Drawing.Point(130, 137);
            this.ConvertBtn.Name = "ConvertBtn";
            this.ConvertBtn.Size = new System.Drawing.Size(149, 53);
            this.ConvertBtn.TabIndex = 6;
            this.ConvertBtn.Text = "开始转换";
            this.ConvertBtn.UseVisualStyleBackColor = false;
            this.ConvertBtn.Click += new System.EventHandler(this.ConvertBtn_Click);
            // 
            // LogTextBox
            // 
            this.LogTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LogTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LogTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.LogTextBox.Location = new System.Drawing.Point(130, 207);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogTextBox.Size = new System.Drawing.Size(570, 354);
            this.LogTextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(71, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 14);
            this.label3.TabIndex = 9;
            this.label3.Text = "输入日志";
            // 
            // Word2JpgFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 561);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LogTextBox);
            this.Controls.Add(this.ConvertBtn);
            this.Controls.Add(this.SelectFoldBtn);
            this.Controls.Add(this.SelectFileBtn);
            this.Controls.Add(this.ImageFolderTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WordPathTextBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Word2JpgFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDF导出图片工具";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox WordPathTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ImageFolderTextBox;
        private System.Windows.Forms.Button SelectFileBtn;
        private System.Windows.Forms.Button SelectFoldBtn;
        private System.Windows.Forms.Button ConvertBtn;
        private System.Windows.Forms.TextBox LogTextBox;
        private System.Windows.Forms.Label label3;
    }
}

