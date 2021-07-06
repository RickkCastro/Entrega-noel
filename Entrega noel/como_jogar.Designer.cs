
namespace Entrega_noel
{
    partial class como_jogar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(como_jogar));
            this.telas_box = new System.Windows.Forms.PictureBox();
            this.anterior_button = new System.Windows.Forms.Button();
            this.proximo_button = new System.Windows.Forms.Button();
            this.menu_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.telas_box)).BeginInit();
            this.SuspendLayout();
            // 
            // telas_box
            // 
            this.telas_box.Image = ((System.Drawing.Image)(resources.GetObject("telas_box.Image")));
            this.telas_box.Location = new System.Drawing.Point(226, 12);
            this.telas_box.Name = "telas_box";
            this.telas_box.Size = new System.Drawing.Size(592, 523);
            this.telas_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.telas_box.TabIndex = 0;
            this.telas_box.TabStop = false;
            // 
            // anterior_button
            // 
            this.anterior_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(79)))));
            this.anterior_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anterior_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.anterior_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.anterior_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.anterior_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.anterior_button.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anterior_button.ForeColor = System.Drawing.Color.Black;
            this.anterior_button.Location = new System.Drawing.Point(57, 275);
            this.anterior_button.Name = "anterior_button";
            this.anterior_button.Size = new System.Drawing.Size(109, 39);
            this.anterior_button.TabIndex = 3;
            this.anterior_button.Text = "Anterior";
            this.anterior_button.UseVisualStyleBackColor = false;
            this.anterior_button.Click += new System.EventHandler(this.anterior_button_Click);
            // 
            // proximo_button
            // 
            this.proximo_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(79)))));
            this.proximo_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.proximo_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.proximo_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.proximo_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.proximo_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.proximo_button.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proximo_button.ForeColor = System.Drawing.Color.Black;
            this.proximo_button.Location = new System.Drawing.Point(57, 221);
            this.proximo_button.Name = "proximo_button";
            this.proximo_button.Size = new System.Drawing.Size(109, 39);
            this.proximo_button.TabIndex = 3;
            this.proximo_button.Text = "Próximo";
            this.proximo_button.UseVisualStyleBackColor = false;
            this.proximo_button.Click += new System.EventHandler(this.proximo_button_Click);
            // 
            // menu_button
            // 
            this.menu_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menu_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menu_button.BackgroundImage")));
            this.menu_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menu_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menu_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.menu_button.FlatAppearance.BorderSize = 2;
            this.menu_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.menu_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.menu_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_button.Location = new System.Drawing.Point(12, 12);
            this.menu_button.Name = "menu_button";
            this.menu_button.Size = new System.Drawing.Size(51, 49);
            this.menu_button.TabIndex = 4;
            this.menu_button.UseVisualStyleBackColor = false;
            this.menu_button.Click += new System.EventHandler(this.menu_button_Click);
            // 
            // como_jogar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(830, 547);
            this.Controls.Add(this.menu_button);
            this.Controls.Add(this.proximo_button);
            this.Controls.Add(this.anterior_button);
            this.Controls.Add(this.telas_box);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "como_jogar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Entrega noel";
            ((System.ComponentModel.ISupportInitialize)(this.telas_box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox telas_box;
        private System.Windows.Forms.Button anterior_button;
        private System.Windows.Forms.Button proximo_button;
        private System.Windows.Forms.Button menu_button;
    }
}