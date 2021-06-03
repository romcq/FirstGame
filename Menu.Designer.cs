
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
            this.StartGameBtn.BackgroundImage = global::FirstGame.Properties.Resources.darkbackground;
            this.StartGameBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartGameBtn.Font = new System.Drawing.Font("Impact", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartGameBtn.Location = new System.Drawing.Point(90, 63);
            this.StartGameBtn.Name = "StartGameBtn";
            this.StartGameBtn.Size = new System.Drawing.Size(366, 135);
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
            this.ExitGameBtn.Location = new System.Drawing.Point(90, 243);
            this.ExitGameBtn.Name = "ExitGameBtn";
            this.ExitGameBtn.Size = new System.Drawing.Size(366, 135);
            this.ExitGameBtn.TabIndex = 1;
            this.ExitGameBtn.Text = "Выход из игры";
            this.ExitGameBtn.UseVisualStyleBackColor = true;
            this.ExitGameBtn.Click += new System.EventHandler(this.ExitGameBtn_Click);
            // 
            // InstrLbl
            // 
            this.InstrLbl.AutoSize = true;
            this.InstrLbl.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InstrLbl.Image = global::FirstGame.Properties.Resources.darkbackground;
            this.InstrLbl.Location = new System.Drawing.Point(495, 201);
            this.InstrLbl.Name = "InstrLbl";
            this.InstrLbl.Size = new System.Drawing.Size(293, 240);
            this.InstrLbl.TabIndex = 2;
            this.InstrLbl.Text = "Управление: \r\nW - двигаться вверх\r\nS - двигаться вниз\r\nА - двигаться влево\r\nD - д" +
    "вигаться вправо\r\nM - выход из игры";
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