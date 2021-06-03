
namespace FirstGame
{
    partial class Menu
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
            this.StartGameBtn = new System.Windows.Forms.Button();
            this.ExitGameBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartGameBtn
            // 
            this.StartGameBtn.BackgroundImage = global::FirstGame.Properties.Resources.darkbackground;
            this.StartGameBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartGameBtn.Font = new System.Drawing.Font("Impact", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartGameBtn.Location = new System.Drawing.Point(203, 55);
            this.StartGameBtn.Name = "StartGameBtn";
            this.StartGameBtn.Size = new System.Drawing.Size(366, 92);
            this.StartGameBtn.TabIndex = 0;
            this.StartGameBtn.Text = "Начать игру";
            this.StartGameBtn.UseVisualStyleBackColor = true;
            this.StartGameBtn.Click += new System.EventHandler(this.StartGameBtn_Click);
            // 
            // ExitGameBtn
            // 
            this.ExitGameBtn.BackgroundImage = global::FirstGame.Properties.Resources.darkbackground;
            this.ExitGameBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitGameBtn.Font = new System.Drawing.Font("Impact", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitGameBtn.Location = new System.Drawing.Point(203, 303);
            this.ExitGameBtn.Name = "ExitGameBtn";
            this.ExitGameBtn.Size = new System.Drawing.Size(366, 92);
            this.ExitGameBtn.TabIndex = 1;
            this.ExitGameBtn.Text = "Выход из игры";
            this.ExitGameBtn.UseVisualStyleBackColor = true;
            this.ExitGameBtn.Click += new System.EventHandler(this.ExitGameBtn_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Impact", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Image = global::FirstGame.Properties.Resources.darkbackground;
            this.button1.Location = new System.Drawing.Point(203, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(366, 92);
            this.button1.TabIndex = 2;
            this.button1.Text = "Управление";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FirstGame.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ExitGameBtn);
            this.Controls.Add(this.StartGameBtn);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartGameBtn;
        private System.Windows.Forms.Button ExitGameBtn;
        private System.Windows.Forms.Button button1;
    }
}