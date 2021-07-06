
namespace Entrega_noel
{
    partial class perguntas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(perguntas));
            this.perguntas_box = new System.Windows.Forms.RichTextBox();
            this.label_pergunta = new System.Windows.Forms.Label();
            this.resposta1 = new System.Windows.Forms.RadioButton();
            this.resposta2 = new System.Windows.Forms.RadioButton();
            this.resposta3 = new System.Windows.Forms.RadioButton();
            this.resposta4 = new System.Windows.Forms.RadioButton();
            this.confirmar_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // perguntas_box
            // 
            this.perguntas_box.Location = new System.Drawing.Point(552, 12);
            this.perguntas_box.Name = "perguntas_box";
            this.perguntas_box.Size = new System.Drawing.Size(472, 523);
            this.perguntas_box.TabIndex = 0;
            this.perguntas_box.Text = "";
            // 
            // label_pergunta
            // 
            this.label_pergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pergunta.Location = new System.Drawing.Point(40, 9);
            this.label_pergunta.Name = "label_pergunta";
            this.label_pergunta.Size = new System.Drawing.Size(453, 179);
            this.label_pergunta.TabIndex = 1;
            this.label_pergunta.Text = resources.GetString("label_pergunta.Text");
            this.label_pergunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resposta1
            // 
            this.resposta1.AutoSize = true;
            this.resposta1.Checked = true;
            this.resposta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resposta1.Location = new System.Drawing.Point(45, 215);
            this.resposta1.Name = "resposta1";
            this.resposta1.Size = new System.Drawing.Size(366, 24);
            this.resposta1.TabIndex = 2;
            this.resposta1.TabStop = true;
            this.resposta1.Text = "China, Índia, Estados Unidos, Indonésia e Brasil";
            this.resposta1.UseVisualStyleBackColor = true;
            // 
            // resposta2
            // 
            this.resposta2.AutoSize = true;
            this.resposta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resposta2.Location = new System.Drawing.Point(45, 245);
            this.resposta2.Name = "resposta2";
            this.resposta2.Size = new System.Drawing.Size(366, 24);
            this.resposta2.TabIndex = 2;
            this.resposta2.TabStop = true;
            this.resposta2.Text = "China, Índia, Estados Unidos, Indonésia e Brasil";
            this.resposta2.UseVisualStyleBackColor = true;
            // 
            // resposta3
            // 
            this.resposta3.AutoSize = true;
            this.resposta3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resposta3.Location = new System.Drawing.Point(45, 275);
            this.resposta3.Name = "resposta3";
            this.resposta3.Size = new System.Drawing.Size(366, 24);
            this.resposta3.TabIndex = 2;
            this.resposta3.TabStop = true;
            this.resposta3.Text = "China, Índia, Estados Unidos, Indonésia e Brasil";
            this.resposta3.UseVisualStyleBackColor = true;
            // 
            // resposta4
            // 
            this.resposta4.AutoSize = true;
            this.resposta4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resposta4.Location = new System.Drawing.Point(45, 305);
            this.resposta4.Name = "resposta4";
            this.resposta4.Size = new System.Drawing.Size(366, 24);
            this.resposta4.TabIndex = 2;
            this.resposta4.TabStop = true;
            this.resposta4.Text = "China, Índia, Estados Unidos, Indonésia e Brasil";
            this.resposta4.UseVisualStyleBackColor = true;
            // 
            // confirmar_button
            // 
            this.confirmar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmar_button.Location = new System.Drawing.Point(223, 346);
            this.confirmar_button.Name = "confirmar_button";
            this.confirmar_button.Size = new System.Drawing.Size(102, 32);
            this.confirmar_button.TabIndex = 3;
            this.confirmar_button.Text = "Confirmar";
            this.confirmar_button.UseVisualStyleBackColor = true;
            this.confirmar_button.Click += new System.EventHandler(this.confirmar_button_Click);
            // 
            // perguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(537, 408);
            this.Controls.Add(this.confirmar_button);
            this.Controls.Add(this.resposta4);
            this.Controls.Add(this.resposta3);
            this.Controls.Add(this.resposta2);
            this.Controls.Add(this.resposta1);
            this.Controls.Add(this.label_pergunta);
            this.Controls.Add(this.perguntas_box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "perguntas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Entrega Noel";
            this.Load += new System.EventHandler(this.perguntas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox perguntas_box;
        private System.Windows.Forms.Label label_pergunta;
        private System.Windows.Forms.RadioButton resposta1;
        private System.Windows.Forms.RadioButton resposta2;
        private System.Windows.Forms.RadioButton resposta3;
        private System.Windows.Forms.RadioButton resposta4;
        private System.Windows.Forms.Button confirmar_button;
    }
}