
namespace Entrega_noel
{
    partial class mini_game
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mini_game));
            this.click_button = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textinho = new System.Windows.Forms.Label();
            this.num_cliques = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // click_button
            // 
            this.click_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.click_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.click_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.click_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.click_button.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.click_button.Location = new System.Drawing.Point(208, 381);
            this.click_button.Name = "click_button";
            this.click_button.Size = new System.Drawing.Size(103, 34);
            this.click_button.TabIndex = 0;
            this.click_button.Text = "Clique";
            this.click_button.UseVisualStyleBackColor = true;
            this.click_button.Click += new System.EventHandler(this.click_button_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer
            // 
            this.timer.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer.Location = new System.Drawing.Point(12, 69);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(80, 37);
            this.timer.TabIndex = 1;
            this.timer.Text = "30 seg";
            this.timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(481, 452);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // textinho
            // 
            this.textinho.BackColor = System.Drawing.Color.Transparent;
            this.textinho.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textinho.ForeColor = System.Drawing.Color.Black;
            this.textinho.Location = new System.Drawing.Point(12, 9);
            this.textinho.Name = "textinho";
            this.textinho.Size = new System.Drawing.Size(323, 49);
            this.textinho.TabIndex = 1;
            this.textinho.Text = "Clique para acelerar o trenó do papai noel antes que o tempo acabe";
            this.textinho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num_cliques
            // 
            this.num_cliques.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_cliques.Location = new System.Drawing.Point(189, 341);
            this.num_cliques.Name = "num_cliques";
            this.num_cliques.Size = new System.Drawing.Size(135, 37);
            this.num_cliques.TabIndex = 1;
            this.num_cliques.Text = "101 cliques";
            this.num_cliques.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mini_game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(480, 450);
            this.Controls.Add(this.textinho);
            this.Controls.Add(this.num_cliques);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.click_button);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "mini_game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.mini_game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button click_button;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label textinho;
        private System.Windows.Forms.Label num_cliques;
    }
}