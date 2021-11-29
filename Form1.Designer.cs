namespace StoreClass
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Adress = new System.Windows.Forms.Label();
            this.label_WorkSchedule = new System.Windows.Forms.Label();
            this.label_NumberRooms = new System.Windows.Forms.Label();
            this.label_Delivery = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_WorkSchedule = new System.Windows.Forms.TextBox();
            this.textBox_Delivery = new System.Windows.Forms.TextBox();
            this.textBox_Adress = new System.Windows.Forms.TextBox();
            this.textBox_NumberRooms = new System.Windows.Forms.TextBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Find = new System.Windows.Forms.Button();
            this.textBoxFindAdress = new System.Windows.Forms.TextBox();
            this.label_FIndAdress = new System.Windows.Forms.Label();
            this.textBox_Answer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Name.Location = new System.Drawing.Point(12, 282);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(84, 21);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "Название";
            // 
            // label_Adress
            // 
            this.label_Adress.AutoSize = true;
            this.label_Adress.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Adress.Location = new System.Drawing.Point(12, 317);
            this.label_Adress.Name = "label_Adress";
            this.label_Adress.Size = new System.Drawing.Size(60, 21);
            this.label_Adress.TabIndex = 1;
            this.label_Adress.Text = "Адрес";
            // 
            // label_WorkSchedule
            // 
            this.label_WorkSchedule.AutoSize = true;
            this.label_WorkSchedule.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_WorkSchedule.Location = new System.Drawing.Point(12, 352);
            this.label_WorkSchedule.Name = "label_WorkSchedule";
            this.label_WorkSchedule.Size = new System.Drawing.Size(133, 21);
            this.label_WorkSchedule.TabIndex = 2;
            this.label_WorkSchedule.Text = "График работы";
            // 
            // label_NumberRooms
            // 
            this.label_NumberRooms.AutoSize = true;
            this.label_NumberRooms.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_NumberRooms.Location = new System.Drawing.Point(12, 422);
            this.label_NumberRooms.Name = "label_NumberRooms";
            this.label_NumberRooms.Size = new System.Drawing.Size(166, 21);
            this.label_NumberRooms.TabIndex = 6;
            this.label_NumberRooms.Text = "Количество комнат";
            // 
            // label_Delivery
            // 
            this.label_Delivery.AutoSize = true;
            this.label_Delivery.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Delivery.Location = new System.Drawing.Point(12, 387);
            this.label_Delivery.Name = "label_Delivery";
            this.label_Delivery.Size = new System.Drawing.Size(84, 21);
            this.label_Delivery.TabIndex = 4;
            this.label_Delivery.Text = "Доставка";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Name.Location = new System.Drawing.Point(277, 279);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(207, 31);
            this.textBox_Name.TabIndex = 7;
            // 
            // textBox_WorkSchedule
            // 
            this.textBox_WorkSchedule.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_WorkSchedule.Location = new System.Drawing.Point(277, 349);
            this.textBox_WorkSchedule.Name = "textBox_WorkSchedule";
            this.textBox_WorkSchedule.Size = new System.Drawing.Size(207, 31);
            this.textBox_WorkSchedule.TabIndex = 9;
            // 
            // textBox_Delivery
            // 
            this.textBox_Delivery.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Delivery.Location = new System.Drawing.Point(277, 384);
            this.textBox_Delivery.Name = "textBox_Delivery";
            this.textBox_Delivery.Size = new System.Drawing.Size(207, 31);
            this.textBox_Delivery.TabIndex = 11;
            // 
            // textBox_Adress
            // 
            this.textBox_Adress.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Adress.Location = new System.Drawing.Point(277, 314);
            this.textBox_Adress.Name = "textBox_Adress";
            this.textBox_Adress.Size = new System.Drawing.Size(207, 31);
            this.textBox_Adress.TabIndex = 12;
            // 
            // textBox_NumberRooms
            // 
            this.textBox_NumberRooms.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_NumberRooms.Location = new System.Drawing.Point(277, 419);
            this.textBox_NumberRooms.Name = "textBox_NumberRooms";
            this.textBox_NumberRooms.Size = new System.Drawing.Size(207, 31);
            this.textBox_NumberRooms.TabIndex = 13;
            // 
            // button_Add
            // 
            this.button_Add.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Add.Location = new System.Drawing.Point(16, 454);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(468, 38);
            this.button_Add.TabIndex = 14;
            this.button_Add.Text = "Создать магазин";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Find
            // 
            this.button_Find.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Find.Location = new System.Drawing.Point(123, 46);
            this.button_Find.Name = "button_Find";
            this.button_Find.Size = new System.Drawing.Size(269, 38);
            this.button_Find.TabIndex = 17;
            this.button_Find.Text = "Найти магазин";
            this.button_Find.UseVisualStyleBackColor = true;
            this.button_Find.Click += new System.EventHandler(this.button_Find_Click);
            // 
            // textBoxFindAdress
            // 
            this.textBoxFindAdress.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFindAdress.Location = new System.Drawing.Point(185, 12);
            this.textBoxFindAdress.Name = "textBoxFindAdress";
            this.textBoxFindAdress.Size = new System.Drawing.Size(207, 31);
            this.textBoxFindAdress.TabIndex = 16;
            // 
            // label_FIndAdress
            // 
            this.label_FIndAdress.AutoSize = true;
            this.label_FIndAdress.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_FIndAdress.Location = new System.Drawing.Point(119, 15);
            this.label_FIndAdress.Name = "label_FIndAdress";
            this.label_FIndAdress.Size = new System.Drawing.Size(60, 21);
            this.label_FIndAdress.TabIndex = 15;
            this.label_FIndAdress.Text = "Адрес";
            // 
            // textBox_Answer
            // 
            this.textBox_Answer.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Answer.Location = new System.Drawing.Point(9, 90);
            this.textBox_Answer.Multiline = true;
            this.textBox_Answer.Name = "textBox_Answer";
            this.textBox_Answer.Size = new System.Drawing.Size(475, 161);
            this.textBox_Answer.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 493);
            this.Controls.Add(this.textBox_Answer);
            this.Controls.Add(this.button_Find);
            this.Controls.Add(this.textBoxFindAdress);
            this.Controls.Add(this.label_FIndAdress);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.textBox_NumberRooms);
            this.Controls.Add(this.textBox_Adress);
            this.Controls.Add(this.textBox_Delivery);
            this.Controls.Add(this.textBox_WorkSchedule);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label_NumberRooms);
            this.Controls.Add(this.label_Delivery);
            this.Controls.Add(this.label_WorkSchedule);
            this.Controls.Add(this.label_Adress);
            this.Controls.Add(this.label_Name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Adress;
        private System.Windows.Forms.Label label_WorkSchedule;
        private System.Windows.Forms.Label label_NumberRooms;
        private System.Windows.Forms.Label label_Delivery;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_WorkSchedule;
        private System.Windows.Forms.TextBox textBox_Delivery;
        private System.Windows.Forms.TextBox textBox_Adress;
        private System.Windows.Forms.TextBox textBox_NumberRooms;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Find;
        private System.Windows.Forms.TextBox textBoxFindAdress;
        private System.Windows.Forms.Label label_FIndAdress;
        private System.Windows.Forms.TextBox textBox_Answer;
    }
}

