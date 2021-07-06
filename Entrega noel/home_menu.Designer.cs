
namespace Entrega_noel
{
    partial class home_menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home_menu));
            this.play_buttom = new System.Windows.Forms.Button();
            this.sair_button = new System.Windows.Forms.Button();
            this.como_jogar_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // play_buttom
            // 
            this.play_buttom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(79)))));
            this.play_buttom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.play_buttom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.play_buttom.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play_buttom.Location = new System.Drawing.Point(550, 240);
            this.play_buttom.Name = "play_buttom";
            this.play_buttom.Size = new System.Drawing.Size(178, 43);
            this.play_buttom.TabIndex = 0;
            this.play_buttom.Text = "Jogar";
            this.play_buttom.UseVisualStyleBackColor = false;
            this.play_buttom.Click += new System.EventHandler(this.play_buttom_Click);
            // 
            // sair_button
            // 
            this.sair_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(79)))));
            this.sair_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sair_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sair_button.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sair_button.Location = new System.Drawing.Point(550, 338);
            this.sair_button.Name = "sair_button";
            this.sair_button.Size = new System.Drawing.Size(178, 43);
            this.sair_button.TabIndex = 0;
            this.sair_button.Text = "Sair";
            this.sair_button.UseVisualStyleBackColor = false;
            this.sair_button.Click += new System.EventHandler(this.sair_button_Click);
            // 
            // como_jogar_button
            // 
            this.como_jogar_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(79)))));
            this.como_jogar_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.como_jogar_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.como_jogar_button.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.como_jogar_button.Location = new System.Drawing.Point(550, 289);
            this.como_jogar_button.Name = "como_jogar_button";
            this.como_jogar_button.Size = new System.Drawing.Size(178, 43);
            this.como_jogar_button.TabIndex = 0;
            this.como_jogar_button.Text = "Como Jogar";
            this.como_jogar_button.UseVisualStyleBackColor = false;
            this.como_jogar_button.Click += new System.EventHandler(this.como_jogar_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(736, 456);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(73, 206);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(375, 200);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // home_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(830, 547);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sair_button);
            this.Controls.Add(this.como_jogar_button);
            this.Controls.Add(this.play_buttom);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "home_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrega Noel";
            this.Load += new System.EventHandler(this.home_menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button play_buttom;
        private System.Windows.Forms.Button sair_button;
        private System.Windows.Forms.Button como_jogar_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

