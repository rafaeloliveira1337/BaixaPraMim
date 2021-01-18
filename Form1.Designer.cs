
namespace BaixaPraMim
{
    partial class form_BaixaPraMim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_BaixaPraMim));
            this.btnDownload = new System.Windows.Forms.Button();
            this.input_videoUrl = new System.Windows.Forms.TextBox();
            this.lbl_VideoUrl = new System.Windows.Forms.Label();
            this.label_appTitle = new System.Windows.Forms.Label();
            this.label_example = new System.Windows.Forms.Label();
            this.label_developedBy = new System.Windows.Forms.Label();
            this.groupBox_downloadType = new System.Windows.Forms.GroupBox();
            this.rb_mp3 = new System.Windows.Forms.RadioButton();
            this.rb_video = new System.Windows.Forms.RadioButton();
            this.groupBox_downloadType.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDownload
            // 
            this.btnDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.Location = new System.Drawing.Point(322, 358);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(149, 48);
            this.btnDownload.TabIndex = 0;
            this.btnDownload.Text = "Baixar";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // input_videoUrl
            // 
            this.input_videoUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_videoUrl.Location = new System.Drawing.Point(99, 155);
            this.input_videoUrl.MaxLength = 1000;
            this.input_videoUrl.Name = "input_videoUrl";
            this.input_videoUrl.Size = new System.Drawing.Size(592, 26);
            this.input_videoUrl.TabIndex = 1;
            // 
            // lbl_VideoUrl
            // 
            this.lbl_VideoUrl.AutoSize = true;
            this.lbl_VideoUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VideoUrl.Location = new System.Drawing.Point(95, 131);
            this.lbl_VideoUrl.Name = "lbl_VideoUrl";
            this.lbl_VideoUrl.Size = new System.Drawing.Size(110, 20);
            this.lbl_VideoUrl.TabIndex = 2;
            this.lbl_VideoUrl.Text = "URL do vídeo";
            // 
            // label_appTitle
            // 
            this.label_appTitle.AutoSize = true;
            this.label_appTitle.Font = new System.Drawing.Font("MV Boli", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_appTitle.Location = new System.Drawing.Point(77, 11);
            this.label_appTitle.Name = "label_appTitle";
            this.label_appTitle.Size = new System.Drawing.Size(603, 105);
            this.label_appTitle.TabIndex = 3;
            this.label_appTitle.Text = "Baixa Pra Mim";
            // 
            // label_example
            // 
            this.label_example.AutoSize = true;
            this.label_example.Location = new System.Drawing.Point(99, 190);
            this.label_example.Name = "label_example";
            this.label_example.Size = new System.Drawing.Size(388, 17);
            this.label_example.TabIndex = 4;
            this.label_example.Text = "Exemplo: https://www.youtube.com/watch?v=dQw4w9WgXcQ";
            // 
            // label_developedBy
            // 
            this.label_developedBy.AutoSize = true;
            this.label_developedBy.Font = new System.Drawing.Font("Arial Unicode MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_developedBy.Location = new System.Drawing.Point(562, 417);
            this.label_developedBy.Name = "label_developedBy";
            this.label_developedBy.Size = new System.Drawing.Size(220, 19);
            this.label_developedBy.TabIndex = 5;
            this.label_developedBy.Text = "Desenvolvido por: Rafael Oliveira";
            // 
            // groupBox_downloadType
            // 
            this.groupBox_downloadType.Controls.Add(this.rb_video);
            this.groupBox_downloadType.Controls.Add(this.rb_mp3);
            this.groupBox_downloadType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_downloadType.Location = new System.Drawing.Point(99, 221);
            this.groupBox_downloadType.Name = "groupBox_downloadType";
            this.groupBox_downloadType.Size = new System.Drawing.Size(592, 114);
            this.groupBox_downloadType.TabIndex = 6;
            this.groupBox_downloadType.TabStop = false;
            this.groupBox_downloadType.Text = "Tipo de download";
            // 
            // rb_mp3
            // 
            this.rb_mp3.AutoSize = true;
            this.rb_mp3.Checked = true;
            this.rb_mp3.Location = new System.Drawing.Point(14, 32);
            this.rb_mp3.Name = "rb_mp3";
            this.rb_mp3.Size = new System.Drawing.Size(84, 24);
            this.rb_mp3.TabIndex = 0;
            this.rb_mp3.TabStop = true;
            this.rb_mp3.Text = "Música";
            this.rb_mp3.UseVisualStyleBackColor = true;
            // 
            // rb_video
            // 
            this.rb_video.AutoSize = true;
            this.rb_video.Location = new System.Drawing.Point(14, 63);
            this.rb_video.Name = "rb_video";
            this.rb_video.Size = new System.Drawing.Size(72, 24);
            this.rb_video.TabIndex = 1;
            this.rb_video.TabStop = true;
            this.rb_video.Text = "Vídeo";
            this.rb_video.UseVisualStyleBackColor = true;
            // 
            // form_BaixaPraMim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox_downloadType);
            this.Controls.Add(this.label_developedBy);
            this.Controls.Add(this.label_example);
            this.Controls.Add(this.label_appTitle);
            this.Controls.Add(this.lbl_VideoUrl);
            this.Controls.Add(this.input_videoUrl);
            this.Controls.Add(this.btnDownload);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_BaixaPraMim";
            this.Text = "Baixa Pra Mim v1.0";
            this.groupBox_downloadType.ResumeLayout(false);
            this.groupBox_downloadType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.TextBox input_videoUrl;
        private System.Windows.Forms.Label lbl_VideoUrl;
        private System.Windows.Forms.Label label_appTitle;
        private System.Windows.Forms.Label label_example;
        private System.Windows.Forms.Label label_developedBy;
        private System.Windows.Forms.GroupBox groupBox_downloadType;
        private System.Windows.Forms.RadioButton rb_mp3;
        private System.Windows.Forms.RadioButton rb_video;
    }
}

