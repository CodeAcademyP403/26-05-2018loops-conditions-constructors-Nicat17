namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.name_txt = new System.Windows.Forms.Label();
            this.weight_txt = new System.Windows.Forms.Label();
            this.weight_textBox = new System.Windows.Forms.TextBox();
            this.goods_txt = new System.Windows.Forms.Label();
            this.goods_option = new System.Windows.Forms.ComboBox();
            this.price_textbox = new System.Windows.Forms.TextBox();
            this.price_txt = new System.Windows.Forms.Label();
            this.date_txt = new System.Windows.Forms.Label();
            this.date_textBox = new System.Windows.Forms.TextBox();
            this.add_button = new System.Windows.Forms.Button();
            this.product_count = new System.Windows.Forms.Label();
            this.catagory_section = new System.Windows.Forms.Label();
            this.meat_txt = new System.Windows.Forms.Label();
            this.candy_txt = new System.Windows.Forms.Label();
            this.vegetable_txt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(49, 43);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(305, 20);
            this.name_textbox.TabIndex = 0;
            // 
            // name_txt
            // 
            this.name_txt.AutoSize = true;
            this.name_txt.Location = new System.Drawing.Point(49, 24);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(38, 13);
            this.name_txt.TabIndex = 1;
            this.name_txt.Text = "Name:";
            // 
            // weight_txt
            // 
            this.weight_txt.AutoSize = true;
            this.weight_txt.Location = new System.Drawing.Point(49, 68);
            this.weight_txt.Name = "weight_txt";
            this.weight_txt.Size = new System.Drawing.Size(44, 13);
            this.weight_txt.TabIndex = 4;
            this.weight_txt.Text = "Weight:";
            // 
            // weight_textBox
            // 
            this.weight_textBox.Location = new System.Drawing.Point(49, 87);
            this.weight_textBox.Name = "weight_textBox";
            this.weight_textBox.Size = new System.Drawing.Size(305, 20);
            this.weight_textBox.TabIndex = 3;
            // 
            // goods_txt
            // 
            this.goods_txt.AutoSize = true;
            this.goods_txt.Location = new System.Drawing.Point(49, 111);
            this.goods_txt.Name = "goods_txt";
            this.goods_txt.Size = new System.Drawing.Size(41, 13);
            this.goods_txt.TabIndex = 7;
            this.goods_txt.Text = "Goods:";
            // 
            // goods_option
            // 
            this.goods_option.FormattingEnabled = true;
            this.goods_option.Location = new System.Drawing.Point(49, 133);
            this.goods_option.Name = "goods_option";
            this.goods_option.Size = new System.Drawing.Size(305, 21);
            this.goods_option.TabIndex = 9;
            // 
            // price_textbox
            // 
            this.price_textbox.Location = new System.Drawing.Point(49, 176);
            this.price_textbox.Name = "price_textbox";
            this.price_textbox.Size = new System.Drawing.Size(305, 20);
            this.price_textbox.TabIndex = 10;
            // 
            // price_txt
            // 
            this.price_txt.AutoSize = true;
            this.price_txt.Location = new System.Drawing.Point(49, 157);
            this.price_txt.Name = "price_txt";
            this.price_txt.Size = new System.Drawing.Size(34, 13);
            this.price_txt.TabIndex = 11;
            this.price_txt.Text = "Price:";
            // 
            // date_txt
            // 
            this.date_txt.AutoSize = true;
            this.date_txt.Location = new System.Drawing.Point(49, 207);
            this.date_txt.Name = "date_txt";
            this.date_txt.Size = new System.Drawing.Size(85, 13);
            this.date_txt.TabIndex = 14;
            this.date_txt.Text = "End Using Date:";
            // 
            // date_textBox
            // 
            this.date_textBox.Location = new System.Drawing.Point(49, 226);
            this.date_textBox.Name = "date_textBox";
            this.date_textBox.Size = new System.Drawing.Size(305, 20);
            this.date_textBox.TabIndex = 13;
            // 
            // add_button
            // 
            this.add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.add_button.Location = new System.Drawing.Point(73, 268);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(256, 39);
            this.add_button.TabIndex = 16;
            this.add_button.Text = "Add Product";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // product_count
            // 
            this.product_count.AutoSize = true;
            this.product_count.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.product_count.Location = new System.Drawing.Point(360, 68);
            this.product_count.Name = "product_count";
            this.product_count.Size = new System.Drawing.Size(121, 13);
            this.product_count.TabIndex = 17;
            this.product_count.Text = "Product Count In Stock:";
            // 
            // catagory_section
            // 
            this.catagory_section.AutoSize = true;
            this.catagory_section.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.catagory_section.Location = new System.Drawing.Point(376, 110);
            this.catagory_section.Name = "catagory_section";
            this.catagory_section.Size = new System.Drawing.Size(52, 13);
            this.catagory_section.TabIndex = 18;
            this.catagory_section.Text = "Catagory:";
            // 
            // meat_txt
            // 
            this.meat_txt.AutoSize = true;
            this.meat_txt.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.meat_txt.Location = new System.Drawing.Point(376, 141);
            this.meat_txt.Name = "meat_txt";
            this.meat_txt.Size = new System.Drawing.Size(34, 13);
            this.meat_txt.TabIndex = 19;
            this.meat_txt.Text = "Meat:";
            // 
            // candy_txt
            // 
            this.candy_txt.AutoSize = true;
            this.candy_txt.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.candy_txt.Location = new System.Drawing.Point(376, 166);
            this.candy_txt.Name = "candy_txt";
            this.candy_txt.Size = new System.Drawing.Size(40, 13);
            this.candy_txt.TabIndex = 20;
            this.candy_txt.Text = "Candy:";
            // 
            // vegetable_txt
            // 
            this.vegetable_txt.AutoSize = true;
            this.vegetable_txt.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.vegetable_txt.Location = new System.Drawing.Point(376, 194);
            this.vegetable_txt.Name = "vegetable_txt";
            this.vegetable_txt.Size = new System.Drawing.Size(58, 13);
            this.vegetable_txt.TabIndex = 21;
            this.vegetable_txt.Text = "Vegetable:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 332);
            this.Controls.Add(this.vegetable_txt);
            this.Controls.Add(this.candy_txt);
            this.Controls.Add(this.meat_txt);
            this.Controls.Add(this.catagory_section);
            this.Controls.Add(this.product_count);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.date_txt);
            this.Controls.Add(this.date_textBox);
            this.Controls.Add(this.price_txt);
            this.Controls.Add(this.price_textbox);
            this.Controls.Add(this.goods_option);
            this.Controls.Add(this.goods_txt);
            this.Controls.Add(this.weight_txt);
            this.Controls.Add(this.weight_textBox);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.name_textbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Label name_txt;
        private System.Windows.Forms.Label weight_txt;
        private System.Windows.Forms.TextBox weight_textBox;
        private System.Windows.Forms.Label goods_txt;
        private System.Windows.Forms.ComboBox goods_option;
        private System.Windows.Forms.TextBox price_textbox;
        private System.Windows.Forms.Label price_txt;
        private System.Windows.Forms.Label date_txt;
        private System.Windows.Forms.TextBox date_textBox;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Label product_count;
        private System.Windows.Forms.Label catagory_section;
        private System.Windows.Forms.Label meat_txt;
        private System.Windows.Forms.Label candy_txt;
        private System.Windows.Forms.Label vegetable_txt;
    }
}

