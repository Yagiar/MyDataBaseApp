namespace MyDataBaseApp
{
    partial class mainForm
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
            this.but_plan_ate = new System.Windows.Forms.Button();
            this.but_plan_workout = new System.Windows.Forms.Button();
            this.choose_day = new System.Windows.Forms.Button();
            this.days_collection = new System.Windows.Forms.ListBox();
            this.but_add_product = new System.Windows.Forms.Button();
            this.but_add_exersice = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // but_plan_ate
            // 
            this.but_plan_ate.Location = new System.Drawing.Point(166, 33);
            this.but_plan_ate.Name = "but_plan_ate";
            this.but_plan_ate.Size = new System.Drawing.Size(172, 45);
            this.but_plan_ate.TabIndex = 0;
            this.but_plan_ate.Text = "Составить план питания";
            this.but_plan_ate.UseVisualStyleBackColor = true;
            this.but_plan_ate.Click += new System.EventHandler(this.but_plan_ate_Click);
            // 
            // but_plan_workout
            // 
            this.but_plan_workout.Location = new System.Drawing.Point(417, 33);
            this.but_plan_workout.Name = "but_plan_workout";
            this.but_plan_workout.Size = new System.Drawing.Size(172, 45);
            this.but_plan_workout.TabIndex = 1;
            this.but_plan_workout.Text = "Составить план тренировки";
            this.but_plan_workout.UseVisualStyleBackColor = true;
            this.but_plan_workout.Click += new System.EventHandler(this.but_plan_workout_Click);
            // 
            // choose_day
            // 
            this.choose_day.Location = new System.Drawing.Point(292, 207);
            this.choose_day.Name = "choose_day";
            this.choose_day.Size = new System.Drawing.Size(172, 45);
            this.choose_day.TabIndex = 2;
            this.choose_day.Text = "Показать план";
            this.choose_day.UseVisualStyleBackColor = true;
            this.choose_day.Click += new System.EventHandler(this.choose_day_Click);
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
            this.days_collection.Location = new System.Drawing.Point(292, 165);
            this.days_collection.Name = "days_collection";
            this.days_collection.Size = new System.Drawing.Size(172, 36);
            this.days_collection.TabIndex = 3;
            // 
            // but_add_product
            // 
            this.but_add_product.Location = new System.Drawing.Point(166, 84);
            this.but_add_product.Name = "but_add_product";
            this.but_add_product.Size = new System.Drawing.Size(172, 45);
            this.but_add_product.TabIndex = 4;
            this.but_add_product.Text = "Добавить продукт";
            this.but_add_product.UseVisualStyleBackColor = true;
            this.but_add_product.Click += new System.EventHandler(this.but_add_product_Click);
            // 
            // but_add_exersice
            // 
            this.but_add_exersice.Location = new System.Drawing.Point(417, 84);
            this.but_add_exersice.Name = "but_add_exersice";
            this.but_add_exersice.Size = new System.Drawing.Size(172, 45);
            this.but_add_exersice.TabIndex = 5;
            this.but_add_exersice.Text = "Добавить упражнение";
            this.but_add_exersice.UseVisualStyleBackColor = true;
            this.but_add_exersice.Click += new System.EventHandler(this.but_add_exersice_Click);
            // 
            // butExit
            // 
            this.butExit.Location = new System.Drawing.Point(673, 369);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(110, 68);
            this.butExit.TabIndex = 6;
            this.butExit.Text = "Выход";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.but_add_exersice);
            this.Controls.Add(this.but_add_product);
            this.Controls.Add(this.days_collection);
            this.Controls.Add(this.choose_day);
            this.Controls.Add(this.but_plan_workout);
            this.Controls.Add(this.but_plan_ate);
            this.Name = "mainForm";
            this.Text = "mainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_plan_ate;
        private System.Windows.Forms.Button but_plan_workout;
        private System.Windows.Forms.Button choose_day;
        private System.Windows.Forms.ListBox days_collection;
        private System.Windows.Forms.Button but_add_product;
        private System.Windows.Forms.Button but_add_exersice;
        private System.Windows.Forms.Button butExit;
    }
}