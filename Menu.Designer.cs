
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
            this.InstrLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartGameBtn
            // 
            this.StartGameBtn.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartGameBtn.Location = new System.Drawing.Point(222, 88);
            this.StartGameBtn.Name = "StartGameBtn";
            this.StartGameBtn.Size = new System.Drawing.Size(324, 90);
            this.StartGameBtn.TabIndex = 0;
            this.StartGameBtn.Text = "Начать игру";
            this.StartGameBtn.UseVisualStyleBackColor = true;
            this.StartGameBtn.Click += new System.EventHandler(this.StartGameBtn_Click);
            // 
            // ExitGameBtn
            // 
            this.ExitGameBtn.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitGameBtn.Location = new System.Drawing.Point(222, 206);
            this.ExitGameBtn.Name = "ExitGameBtn";
            this.ExitGameBtn.Size = new System.Drawing.Size(324, 90);
            this.ExitGameBtn.TabIndex = 1;
            this.ExitGameBtn.Text = "Выход из игры";
            this.ExitGameBtn.UseVisualStyleBackColor = true;
            this.ExitGameBtn.Click += new System.EventHandler(this.ExitGameBtn_Click);
            // 
            // InstrLbl
            // 
            this.InstrLbl.AutoSize = true;
            this.InstrLbl.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstrLbl.Location = new System.Drawing.Point(552, 276);
            this.InstrLbl.Name = "InstrLbl";
            this.InstrLbl.Size = new System.Drawing.Size(236, 165);
            this.InstrLbl.TabIndex = 2;
            this.InstrLbl.Text = "Управление: \r\nW - двигаться вверх\r\nS - двигаться вниз\r\nА - двигаться влево\r\nD - д" +
    "вигаться вправо\r\n";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FirstGame.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InstrLbl);
            this.Controls.Add(this.ExitGameBtn);
            this.Controls.Add(this.StartGameBtn);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartGameBtn;
        private System.Windows.Forms.Button ExitGameBtn;
        private System.Windows.Forms.Label InstrLbl;
    }
}