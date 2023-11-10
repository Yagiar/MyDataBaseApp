namespace MyDataBaseApp
{
    partial class addProdForm
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
            this.tbNameProd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbProteins = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFats = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbUgly = new System.Windows.Forms.TextBox();
            this.but_add_prod = new System.Windows.Forms.Button();
            this.but_return = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNameProd
            // 
            this.tbNameProd.Location = new System.Drawing.Point(24, 27);
            this.tbNameProd.Name = "tbNameProd";
            this.tbNameProd.Size = new System.Drawing.Size(249, 22);
            this.tbNameProd.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя продукта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Белки";
            // 
            // tbProteins
            // 
            this.tbProteins.Location = new System.Drawing.Point(24, 86);
            this.tbProteins.Name = "tbProteins";
            this.tbProteins.Size = new System.Drawing.Size(249, 22);
            this.tbProteins.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Жиры";
            // 
            // tbFats
            // 
            this.tbFats.Location = new System.Drawing.Point(24, 137);
            this.tbFats.Name = "tbFats";
            this.tbFats.Size = new System.Drawing.Size(249, 22);
            this.tbFats.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Углеводы";
            // 
            // tbUgly
            // 
            this.tbUgly.Location = new System.Drawing.Point(24, 182);
            this.tbUgly.Name = "tbUgly";
            this.tbUgly.Size = new System.Drawing.Size(249, 22);
            this.tbUgly.TabIndex = 6;
            // 
            // but_add_prod
            // 
            this.but_add_prod.Location = new System.Drawing.Point(24, 222);
            this.but_add_prod.Name = "but_add_prod";
            this.but_add_prod.Size = new System.Drawing.Size(155, 38);
            this.but_add_prod.TabIndex = 8;
            this.but_add_prod.Text = "Добавить продукт";
            this.but_add_prod.UseVisualStyleBackColor = true;
            this.but_add_prod.Click += new System.EventHandler(this.but_add_prod_Click);
            // 
            // but_return
            // 
            this.but_return.Location = new System.Drawing.Point(248, 309);
            this.but_return.Name = "but_return";
            this.but_return.Size = new System.Drawing.Size(122, 32);
            this.but_return.TabIndex = 9;
            this.but_return.Text = "Вернуться";
            this.but_return.UseVisualStyleBackColor = true;
            this.but_return.Click += new System.EventHandler(this.but_return_Click);
            // 
            // addProdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.but_return);
            this.Controls.Add(this.but_add_prod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbUgly);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbFats);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbProteins);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNameProd);
            this.Name = "addProdForm";
            this.Text = "Добавить продукт";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNameProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbProteins;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFats;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbUgly;
        private System.Windows.Forms.Button but_add_prod;
        private System.Windows.Forms.Button but_return;
    }
}