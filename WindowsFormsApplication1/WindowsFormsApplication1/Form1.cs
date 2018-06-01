using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleSection;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            goods_option.Items.Add("Meat");
            goods_option.Items.Add("Candy");
            goods_option.Items.Add("Vegetable");
        }


        Shop shop = new Shop(50);
        int i = 0,meatCount=1,candyCount=1,vegCount=1;

        private void add_button_Click(object sender, EventArgs e)
        {
            shop.AddArray[i] = new Product();
            shop.AddArray[i].Catagory = new Catagory();

            shop.AddArray[i].Name = name_textbox.Text;

            shop.AddArray[i].Weight = Convert.ToByte(this.weight_textBox.Text);

            shop.AddArray[i].Catagory.Name = goods_option.SelectedItem.ToString();

            shop.AddArray[i].Price =Convert.ToDouble(this.price_textbox.Text);

            shop.AddArray[i].Date = Convert.ToInt32(this.date_textBox.Text);

            product_count.Text = String.Format("Product Count In Stock:{0}",shop.AddArray[i].Count);

            if (goods_option.SelectedItem.ToString() == "Meat")
            {
                meat_txt.Text = String.Format("Meat:{0}", meatCount++);
            }
            else if(goods_option.SelectedItem.ToString() == "Candy")
            {
                candy_txt.Text = String.Format("Candy:{0}", candyCount++);
            }
            else if (goods_option.SelectedItem.ToString() == "Vegetable")
            {
                vegetable_txt.Text = String.Format("Vegetable:{0}", vegCount++);
            }
            else
            {
                MessageBox.Show("Please, Enter true options");
            }
            i++;
        }

        
    }
}
