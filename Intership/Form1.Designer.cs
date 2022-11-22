namespace Intership
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.Response = new System.Windows.Forms.Label();
            this.ShowCameras = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.TextBox();
            this.ShowPhotos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(174, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(422, 20);
            this.textBox1.TabIndex = 2;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(592, 37);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 3;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.button1_Click);
            // 
            // Response
            // 
            this.Response.AutoSize = true;
            this.Response.Location = new System.Drawing.Point(380, 62);
            this.Response.Name = "Response";
            this.Response.Size = new System.Drawing.Size(35, 13);
            this.Response.TabIndex = 4;
            this.Response.Text = "label2";
            // 
            // ShowCameras
            // 
            this.ShowCameras.Location = new System.Drawing.Point(116, 378);
            this.ShowCameras.Name = "ShowCameras";
            this.ShowCameras.Size = new System.Drawing.Size(91, 38);
            this.ShowCameras.TabIndex = 6;
            this.ShowCameras.Text = "ShowCameras";
            this.ShowCameras.UseVisualStyleBackColor = true;
            this.ShowCameras.Click += new System.EventHandler(this.ShowCameras_Click_1);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(84, 100);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(635, 237);
            this.Result.TabIndex = 7;
            // 
            // ShowPhotos
            // 
            this.ShowPhotos.Location = new System.Drawing.Point(576, 378);
            this.ShowPhotos.Name = "ShowPhotos";
            this.ShowPhotos.Size = new System.Drawing.Size(91, 38);
            this.ShowPhotos.TabIndex = 8;
            this.ShowPhotos.Text = "ShowPhotos";
            this.ShowPhotos.UseVisualStyleBackColor = true;
            this.ShowPhotos.Click += new System.EventHandler(this.ShowPhotos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShowPhotos);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.ShowCameras);
            this.Controls.Add(this.Response);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label Response;
        private System.Windows.Forms.Button ShowCameras;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Button ShowPhotos;
    }
}

