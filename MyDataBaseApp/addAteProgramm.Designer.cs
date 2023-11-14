namespace MyDataBaseApp
{
    partial class addAteProgramm
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
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.days_collection = new System.Windows.Forms.ListBox();
            this.butAddProgramm = new System.Windows.Forms.Button();
            this.butReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.ItemHeight = 16;
            this.listBoxProducts.Location = new System.Drawing.Point(46, 66);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(211, 68);
            this.listBoxProducts.TabIndex = 0;
            // 
            // days_collection
            // 
            this.days_collection.FormattingEnabled = true;
            this.days_collection.ItemHeight = 16;
            this.days_collection.Items.AddRange(new object[] {
            "Понедельник",
            "Вторник",
            "Среда",
            "Четверг",
            "Пятница",
            "Суббота",
            "Воскресенье"});
            this.days_collection.Location = new System.Drawing.Point(46, 155);
            this.days_collection.Name = "days_collection";
            this.days_collection.Size = new System.Drawing.Size(211, 68);
            this.days_collection.TabIndex = 1;
            // 
            // butAddProgramm
            // 
            this.butAddProgramm.Location = new System.Drawing.Point(46, 247);
            this.butAddProgramm.Name = "butAddProgramm";
            this.butAddProgramm.Size = new System.Drawing.Size(211, 23);
            this.butAddProgramm.TabIndex = 2;
            this.butAddProgramm.Text = "Добавить";
            this.butAddProgramm.UseVisualStyleBackColor = true;
            this.butAddProgramm.Click += new System.EventHandler(this.butAddProgramm_Click);
            // 
            // butReturn
            // 
            this.butReturn.Location = new System.Drawing.Point(182, 285);
            this.butReturn.Name = "butReturn";
            this.butReturn.Size = new System.Drawing.Size(75, 23);
            this.butReturn.TabIndex = 3;
            this.butReturn.Text = "Назад";
            this.butReturn.UseVisualStyleBackColor = true;
            this.butReturn.Click += new System.EventHandler(this.butReturn_Click);
            // 
            // addAteProg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 342);
            this.Controls.Add(this.butReturn);
            this.Controls.Add(this.butAddProgramm);
            this.Controls.Add(this.days_collection);
            this.Controls.Add(this.listBoxProducts);
            this.Name = "addAteProg";
            this.Text = "addAteProg";
            this.Load += new System.EventHandler(this.addAteProg_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxProducts;
        private System.Windows.Forms.ListBox days_collection;
        private System.Windows.Forms.Button butAddProgramm;
        private System.Windows.Forms.Button butReturn;
    }
}