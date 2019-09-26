namespace FileReadAndWrite
{
    partial class FormFile
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.tabRead = new System.Windows.Forms.TabPage();
            this.tabWrite = new System.Windows.Forms.TabPage();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDlg = new System.Windows.Forms.SaveFileDialog();
            this.txtReadFile = new System.Windows.Forms.TextBox();
            this.btnReadFileSelect = new System.Windows.Forms.Button();
            this.btnReadText = new System.Windows.Forms.Button();
            this.txtReadText = new System.Windows.Forms.TextBox();
            this.txtWriteFile = new System.Windows.Forms.TextBox();
            this.btnWriteFileSelect = new System.Windows.Forms.Button();
            this.btnWriteText = new System.Windows.Forms.Button();
            this.txtWriteText = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.tabRead.SuspendLayout();
            this.tabWrite.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 232);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(333, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(168, 17);
            this.toolStripStatusLabel1.Text = "3509 윤수영 - 파일 읽고 쓰기";
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.tabRead);
            this.tabMenu.Controls.Add(this.tabWrite);
            this.tabMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMenu.Location = new System.Drawing.Point(0, 0);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(333, 232);
            this.tabMenu.TabIndex = 1;
            // 
            // tabRead
            // 
            this.tabRead.Controls.Add(this.txtReadText);
            this.tabRead.Controls.Add(this.btnReadText);
            this.tabRead.Controls.Add(this.btnReadFileSelect);
            this.tabRead.Controls.Add(this.txtReadFile);
            this.tabRead.Location = new System.Drawing.Point(4, 22);
            this.tabRead.Name = "tabRead";
            this.tabRead.Padding = new System.Windows.Forms.Padding(3);
            this.tabRead.Size = new System.Drawing.Size(312, 206);
            this.tabRead.TabIndex = 0;
            this.tabRead.Text = "파일 읽기";
            this.tabRead.UseVisualStyleBackColor = true;
            // 
            // tabWrite
            // 
            this.tabWrite.Controls.Add(this.txtWriteText);
            this.tabWrite.Controls.Add(this.btnWriteText);
            this.tabWrite.Controls.Add(this.btnWriteFileSelect);
            this.tabWrite.Controls.Add(this.txtWriteFile);
            this.tabWrite.Location = new System.Drawing.Point(4, 22);
            this.tabWrite.Name = "tabWrite";
            this.tabWrite.Padding = new System.Windows.Forms.Padding(3);
            this.tabWrite.Size = new System.Drawing.Size(325, 206);
            this.tabWrite.TabIndex = 1;
            this.tabWrite.Text = "파일 쓰기";
            this.tabWrite.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDlg";
            this.openFileDialog1.Filter = "텍스트 파일(*.txt)|*.txt|모든파일 (*.*)|*.*";
            // 
            // saveFileDlg
            // 
            this.saveFileDlg.Filter = "텍스트 파일(*.txt)|*.txt";
            // 
            // txtReadFile
            // 
            this.txtReadFile.Location = new System.Drawing.Point(9, 7);
            this.txtReadFile.Name = "txtReadFile";
            this.txtReadFile.ReadOnly = true;
            this.txtReadFile.Size = new System.Drawing.Size(150, 21);
            this.txtReadFile.TabIndex = 0;
            // 
            // btnReadFileSelect
            // 
            this.btnReadFileSelect.Location = new System.Drawing.Point(165, 4);
            this.btnReadFileSelect.Name = "btnReadFileSelect";
            this.btnReadFileSelect.Size = new System.Drawing.Size(68, 23);
            this.btnReadFileSelect.TabIndex = 1;
            this.btnReadFileSelect.Text = "파일 선택";
            this.btnReadFileSelect.UseVisualStyleBackColor = true;
            // 
            // btnReadText
            // 
            this.btnReadText.Location = new System.Drawing.Point(238, 5);
            this.btnReadText.Name = "btnReadText";
            this.btnReadText.Size = new System.Drawing.Size(65, 23);
            this.btnReadText.TabIndex = 2;
            this.btnReadText.Text = "불러오기";
            this.btnReadText.UseVisualStyleBackColor = true;
            // 
            // txtReadText
            // 
            this.txtReadText.Location = new System.Drawing.Point(9, 45);
            this.txtReadText.Multiline = true;
            this.txtReadText.Name = "txtReadText";
            this.txtReadText.ReadOnly = true;
            this.txtReadText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtReadText.Size = new System.Drawing.Size(294, 155);
            this.txtReadText.TabIndex = 3;
            // 
            // txtWriteFile
            // 
            this.txtWriteFile.Location = new System.Drawing.Point(9, 7);
            this.txtWriteFile.Name = "txtWriteFile";
            this.txtWriteFile.ReadOnly = true;
            this.txtWriteFile.Size = new System.Drawing.Size(143, 21);
            this.txtWriteFile.TabIndex = 0;
            // 
            // btnWriteFileSelect
            // 
            this.btnWriteFileSelect.Location = new System.Drawing.Point(159, 4);
            this.btnWriteFileSelect.Name = "btnWriteFileSelect";
            this.btnWriteFileSelect.Size = new System.Drawing.Size(75, 23);
            this.btnWriteFileSelect.TabIndex = 1;
            this.btnWriteFileSelect.Text = "파일 선택";
            this.btnWriteFileSelect.UseVisualStyleBackColor = true;
            // 
            // btnWriteText
            // 
            this.btnWriteText.Location = new System.Drawing.Point(241, 4);
            this.btnWriteText.Name = "btnWriteText";
            this.btnWriteText.Size = new System.Drawing.Size(75, 23);
            this.btnWriteText.TabIndex = 2;
            this.btnWriteText.Text = "저장하기";
            this.btnWriteText.UseVisualStyleBackColor = true;
            // 
            // txtWriteText
            // 
            this.txtWriteText.Location = new System.Drawing.Point(9, 35);
            this.txtWriteText.Multiline = true;
            this.txtWriteText.Name = "txtWriteText";
            this.txtWriteText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtWriteText.Size = new System.Drawing.Size(307, 165);
            this.txtWriteText.TabIndex = 3;
            // 
            // FormFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 254);
            this.Controls.Add(this.tabMenu);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FormFile";
            this.Text = "3509 윤수영";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabMenu.ResumeLayout(false);
            this.tabRead.ResumeLayout(false);
            this.tabRead.PerformLayout();
            this.tabWrite.ResumeLayout(false);
            this.tabWrite.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage tabRead;
        private System.Windows.Forms.TextBox txtReadText;
        private System.Windows.Forms.Button btnReadText;
        private System.Windows.Forms.Button btnReadFileSelect;
        private System.Windows.Forms.TextBox txtReadFile;
        private System.Windows.Forms.TabPage tabWrite;
        private System.Windows.Forms.TextBox txtWriteText;
        private System.Windows.Forms.Button btnWriteText;
        private System.Windows.Forms.Button btnWriteFileSelect;
        private System.Windows.Forms.TextBox txtWriteFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDlg;
    }
}

