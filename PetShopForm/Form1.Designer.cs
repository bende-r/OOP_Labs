namespace PetShopForm
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
            this.NameOfPet = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Wool = new System.Windows.Forms.RadioButton();
            this.Feathers = new System.Windows.Forms.RadioButton();
            this.Scales = new System.Windows.Forms.RadioButton();
            this.Cell = new System.Windows.Forms.RadioButton();
            this.Aquarium = new System.Windows.Forms.RadioButton();
            this.Terrarium = new System.Windows.Forms.RadioButton();
            this.Skin = new System.Windows.Forms.GroupBox();
            this.Detention = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.NameToFind = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Skin.SuspendLayout();
            this.Detention.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameOfPet
            // 
            this.NameOfPet.Location = new System.Drawing.Point(66, 45);
            this.NameOfPet.Name = "NameOfPet";
            this.NameOfPet.Size = new System.Drawing.Size(130, 22);
            this.NameOfPet.TabIndex = 1;
            this.NameOfPet.TextChanged += new System.EventHandler(this.NameOfPet_TextChanged);
            this.NameOfPet.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(66, 303);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(130, 27);
            this.Add.TabIndex = 2;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Wool
            // 
            this.Wool.AutoSize = true;
            this.Wool.Checked = true;
            this.Wool.Location = new System.Drawing.Point(6, 21);
            this.Wool.Name = "Wool";
            this.Wool.Size = new System.Drawing.Size(76, 20);
            this.Wool.TabIndex = 5;
            this.Wool.TabStop = true;
            this.Wool.Text = "Шерсть";
            this.Wool.UseVisualStyleBackColor = true;
            this.Wool.CheckedChanged += new System.EventHandler(this.Wool_CheckedChanged);
            this.Wool.Click += new System.EventHandler(this.Wool_Click);
            // 
            // Feathers
            // 
            this.Feathers.AutoSize = true;
            this.Feathers.Location = new System.Drawing.Point(6, 47);
            this.Feathers.Name = "Feathers";
            this.Feathers.Size = new System.Drawing.Size(68, 20);
            this.Feathers.TabIndex = 6;
            this.Feathers.Text = "Перья";
            this.Feathers.UseVisualStyleBackColor = true;
            this.Feathers.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            this.Feathers.Click += new System.EventHandler(this.Feathers_Click);
            // 
            // Scales
            // 
            this.Scales.AutoSize = true;
            this.Scales.Location = new System.Drawing.Point(6, 73);
            this.Scales.Name = "Scales";
            this.Scales.Size = new System.Drawing.Size(69, 20);
            this.Scales.TabIndex = 7;
            this.Scales.Text = "Чешуя";
            this.Scales.UseVisualStyleBackColor = true;
            this.Scales.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            this.Scales.Click += new System.EventHandler(this.Scales_Click);
            // 
            // Cell
            // 
            this.Cell.AutoSize = true;
            this.Cell.Checked = true;
            this.Cell.Location = new System.Drawing.Point(6, 26);
            this.Cell.Name = "Cell";
            this.Cell.Size = new System.Drawing.Size(74, 20);
            this.Cell.TabIndex = 8;
            this.Cell.TabStop = true;
            this.Cell.Text = "Клетка";
            this.Cell.UseVisualStyleBackColor = true;
            this.Cell.CheckedChanged += new System.EventHandler(this.Cell_CheckedChanged);
            this.Cell.Click += new System.EventHandler(this.Cell_Click);
            // 
            // Aquarium
            // 
            this.Aquarium.AutoSize = true;
            this.Aquarium.Location = new System.Drawing.Point(6, 52);
            this.Aquarium.Name = "Aquarium";
            this.Aquarium.Size = new System.Drawing.Size(93, 20);
            this.Aquarium.TabIndex = 9;
            this.Aquarium.Text = "Аквариум";
            this.Aquarium.UseVisualStyleBackColor = true;
            this.Aquarium.CheckedChanged += new System.EventHandler(this.Aquarium_CheckedChanged);
            this.Aquarium.Click += new System.EventHandler(this.Aquarium_Click);
            // 
            // Terrarium
            // 
            this.Terrarium.AutoSize = true;
            this.Terrarium.Location = new System.Drawing.Point(6, 78);
            this.Terrarium.Name = "Terrarium";
            this.Terrarium.Size = new System.Drawing.Size(102, 20);
            this.Terrarium.TabIndex = 10;
            this.Terrarium.Text = "Террариум";
            this.Terrarium.UseVisualStyleBackColor = true;
            this.Terrarium.CheckedChanged += new System.EventHandler(this.Terrarium_CheckedChanged);
            this.Terrarium.Click += new System.EventHandler(this.Terrarium_Click);
            // 
            // Skin
            // 
            this.Skin.Controls.Add(this.Wool);
            this.Skin.Controls.Add(this.Feathers);
            this.Skin.Controls.Add(this.Scales);
            this.Skin.Location = new System.Drawing.Point(66, 76);
            this.Skin.Name = "Skin";
            this.Skin.Size = new System.Drawing.Size(130, 100);
            this.Skin.TabIndex = 11;
            this.Skin.TabStop = false;
            this.Skin.Text = "Skin";
            // 
            // Detention
            // 
            this.Detention.Controls.Add(this.Cell);
            this.Detention.Controls.Add(this.Aquarium);
            this.Detention.Controls.Add(this.Terrarium);
            this.Detention.Location = new System.Drawing.Point(66, 182);
            this.Detention.Name = "Detention";
            this.Detention.Size = new System.Drawing.Size(130, 115);
            this.Detention.TabIndex = 12;
            this.Detention.TabStop = false;
            this.Detention.Text = "Detention";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 72);
            this.button1.TabIndex = 13;
            this.button1.Text = "Вывести всех зверей";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(347, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 57);
            this.button2.TabIndex = 14;
            this.button2.Text = "Вывести по месту содержания";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(449, 206);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 77);
            this.button3.TabIndex = 15;
            this.button3.Text = "Вывести по типу покрова";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(536, 212);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 58);
            this.button4.TabIndex = 16;
            this.button4.Text = "Вывести по наименованию";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // NameToFind
            // 
            this.NameToFind.Location = new System.Drawing.Point(536, 182);
            this.NameToFind.Name = "NameToFind";
            this.NameToFind.Size = new System.Drawing.Size(120, 22);
            this.NameToFind.TabIndex = 17;

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(533, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Наименование?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameToFind);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Detention);
            this.Controls.Add(this.Skin);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.NameOfPet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Skin.ResumeLayout(false);
            this.Skin.PerformLayout();
            this.Detention.ResumeLayout(false);
            this.Detention.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox NameOfPet;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.RadioButton Wool;
        private System.Windows.Forms.RadioButton Feathers;
        private System.Windows.Forms.RadioButton Scales;
        private System.Windows.Forms.RadioButton Cell;
        private System.Windows.Forms.RadioButton Aquarium;
        private System.Windows.Forms.RadioButton Terrarium;
        private System.Windows.Forms.GroupBox Skin;
        private System.Windows.Forms.GroupBox Detention;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox NameToFind;
        private System.Windows.Forms.Label label1;
    }
}

