namespace TestApp
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.открытьВторуюФормуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxform1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьВторуюФормуToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // открытьВторуюФормуToolStripMenuItem
            // 
            this.открытьВторуюФормуToolStripMenuItem.BackColor = System.Drawing.Color.Bisque;
            this.открытьВторуюФормуToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.открытьВторуюФормуToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.открытьВторуюФормуToolStripMenuItem.Image = global::TestApp.Properties.Resources.icons8_open_box_64px1;
            this.открытьВторуюФормуToolStripMenuItem.Name = "открытьВторуюФормуToolStripMenuItem";
            this.открытьВторуюФормуToolStripMenuItem.Size = new System.Drawing.Size(214, 24);
            this.открытьВторуюФормуToolStripMenuItem.Text = "открыть вторую форму ";
            this.открытьВторуюФормуToolStripMenuItem.Click += new System.EventHandler(this.открытьВторуюФормуToolStripMenuItem_Click);
            // 
            // textBoxform1
            // 
            this.textBoxform1.Location = new System.Drawing.Point(445, 5);
            this.textBoxform1.Name = "textBoxform1";
            this.textBoxform1.Size = new System.Drawing.Size(343, 20);
            this.textBoxform1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(251, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите путь к файлу ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxform1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem открытьВторуюФормуToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxform1;
        private System.Windows.Forms.Label label1;
    }
}

