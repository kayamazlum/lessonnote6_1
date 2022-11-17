using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6nDers2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // int pay , payda;
            // pay = 20;
            // payda = 0;


            // // HATA YAKALAMA
            // try
            // {
            //     int c = pay / payda;

            //     label1.Text = c.ToString();
            // }
            //// catch(ArithmeticException) hatanın sayısal olduğunu bilince böyle 
            // catch (Exception hata) // hatanın sebebini bilmiyorsak
            // {
            //     label1.Text ="hata ile karşılaşıldı : " + hata.ToString();
            // }

            // // hata olsa da olmasa da kod çalışsın
            // finally
            // {

            // }

            int[] dizi1 = { 10, 20, 30, 40 };
            try
            {
                for (int i = 1; i < 7; i++)
                {
                    listBox1.Items.Add(dizi1[i]);
                }
            }
            catch (Exception hata3)
            {
                label3.Text = "hata : " + hata3.ToString();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int not = Convert.ToInt16(textBox1.Text);
                label2.Text = not.ToString();
            }

            catch(Exception hata2)
            {
                label2.Text = "Hata var. " + hata2.ToString();
            }

            finally
            {
                MessageBox.Show("0-100 arasında sayı giriniz");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide(); // formu gizlemek için
        }
    }
}
