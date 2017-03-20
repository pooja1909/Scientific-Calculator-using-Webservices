using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class _Default : System.Web.UI.Page
    {
        public string no;
        int flag; 
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            flag = 0;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Addwebservice.WebService1 b = new Addwebservice.WebService1();
            Double i = Convert.ToDouble(TextBox1.Text);
            TextBox3.Text = b.Tan(i).ToString();
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Addwebservice.WebService1 b = new Addwebservice.WebService1();
            Double i = Convert.ToDouble(TextBox1.Text);
            TextBox3.Text = b.Acos(i).ToString();
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Addwebservice.WebService1 b = new Addwebservice.WebService1();
            Double i = Convert.ToDouble(TextBox1.Text);
            TextBox3.Text = b.Atan(i).ToString();
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Addwebservice.WebService1 b = new Addwebservice.WebService1();
            Double i = Convert.ToDouble(TextBox1.Text);
            TextBox3.Text = b.Log(i).ToString();
        }





        protected void Button2_Click1(object sender, EventArgs e)
        {
            Addwebservice.WebService1 b = new Addwebservice.WebService1();
            Double i = Convert.ToDouble(TextBox1.Text);
            TextBox3.Text = b.Sine(i).ToString();
        }

        protected void Button3_Click1(object sender, EventArgs e)
        {
            Addwebservice.WebService1 b = new Addwebservice.WebService1();
            Double i = Convert.ToDouble(TextBox1.Text);
            TextBox3.Text = b.Cos(i).ToString();

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Addwebservice.WebService1 b = new Addwebservice.WebService1();
            Double i = Convert.ToDouble(TextBox1.Text);
            TextBox3.Text = b.Asine(i).ToString();
        }

        protected void Button14_Click1(object sender, EventArgs e)
        {
            Addwebservice.WebService1 b = new Addwebservice.WebService1();
            int i = Convert.ToInt32(TextBox1.Text);
            TextBox3.Text = b.Fact(i).ToString();
        }

        protected void Button22_Click1(object sender, EventArgs e)
        {
            Addwebservice.WebService1 b = new Addwebservice.WebService1();
            Double i = Convert.ToDouble(TextBox1.Text);
            TextBox3.Text = b.Sqr(i).ToString();
        }

        protected void Button23_Click1(object sender, EventArgs e)
        {
            Addwebservice.WebService1 b = new Addwebservice.WebService1();
            Double i = Convert.ToDouble(TextBox1.Text);
            TextBox3.Text = b.Cube(i).ToString();
        }

        protected void Button38_Click1(object sender, EventArgs e)
        {
            Addwebservice.WebService1 b = new Addwebservice.WebService1();
            Double i = Convert.ToDouble(TextBox1.Text);
            TextBox3.Text = b.Sqrt(i).ToString();
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            no = TextBox1.Text;
            int n = no.Length;
            TextBox1.Text = (no.Substring(0, n - 1)); 
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "3.141592654"; 
        }


        protected void Button18_Click(object sender, EventArgs e)
        {
            TextBox1.Text += Convert.ToString(4);
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            if(flag==0)
                TextBox1.Text += Convert.ToString(7);
            else
                TextBox2.Text += Convert.ToString(7);    
 
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            TextBox1.Text += Convert.ToString(8);
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            TextBox1.Text += Convert.ToString(9);
        }

        protected void Button36_Click(object sender, EventArgs e)
        {

        }

        protected void Button20_Click(object sender, EventArgs e)
        {
            TextBox1.Text += Convert.ToString(6);
        }

        protected void Button19_Click(object sender, EventArgs e)
        {
            TextBox1.Text += Convert.ToString(5);
        }

        protected void Button34_Click(object sender, EventArgs e)
        {
            TextBox1.Text += Convert.ToString(0);
        }

        protected void Button35_Click(object sender, EventArgs e)
        {
            TextBox1.Text += Button35.Text;
        }

        protected void Button28_Click(object sender, EventArgs e)
        {
            TextBox1.Text += Convert.ToString(3);
        }

        protected void Button27_Click(object sender, EventArgs e)
        {
            TextBox1.Text += Convert.ToString(2);
        }

        protected void Button33_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "0";
            TextBox2.Text = "0";
            TextBox3.Text = "0";
        }

        protected void Button25_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
        }

        protected void Button30_Click(object sender, EventArgs e)
        {
            TextBox1.Text = Convert.ToString(-Convert.ToInt32(TextBox1.Text));
        }

        protected void Button37_Click(object sender, EventArgs e)
        {
            Addwebservice.WebService1 b = new Addwebservice.WebService1();
            int i = Convert.ToInt32(TextBox1.Text);
            int j = Convert.ToInt32(TextBox2.Text);
            TextBox3.Text = b.add(i,j).ToString();
        }

        protected void Button29_Click(object sender, EventArgs e)
        {
            Addwebservice.WebService1 b = new Addwebservice.WebService1();
            int i = Convert.ToInt32(TextBox1.Text);
            int j = Convert.ToInt32(TextBox2.Text);
            TextBox3.Text = b.sub(i, j).ToString();
        }

        protected void Button32_Click(object sender, EventArgs e)
        {
            Addwebservice.WebService1 b = new Addwebservice.WebService1();
            Double i = Convert.ToDouble(TextBox1.Text);
            TextBox3.Text = b.reci(i).ToString();
        }

        protected void Button24_Click(object sender, EventArgs e)
        {
            Addwebservice.WebService1 b = new Addwebservice.WebService1();
            int i = Convert.ToInt32(TextBox1.Text);
            int j = Convert.ToInt32(TextBox2.Text);
            TextBox3.Text = b.xn(i, j).ToString(); 

        }

        protected void Button31_Click(object sender, EventArgs e)
        {
            Addwebservice.WebService1 b = new Addwebservice.WebService1();
            int i = Convert.ToInt32(TextBox1.Text);
            int j = Convert.ToInt32(TextBox2.Text);
            TextBox3.Text = b.mod(i, j).ToString(); 
        }

        protected void Button39_Click(object sender, EventArgs e)
        {
            Addwebservice.WebService1 b = new Addwebservice.WebService1();
            Double i = Convert.ToDouble(TextBox1.Text);
            TextBox3.Text = b.Ln(i).ToString();
        }



        protected void Button21_Click(object sender, EventArgs e)
        {
            Addwebservice.WebService1 b = new Addwebservice.WebService1();
            int i = Convert.ToInt32(TextBox1.Text);
            int j = Convert.ToInt32(TextBox2.Text);
            TextBox3.Text = b.mul(i, j).ToString();
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            Addwebservice.WebService1 b = new Addwebservice.WebService1();
            int i = Convert.ToInt32(TextBox1.Text);
            int j = Convert.ToInt32(TextBox2.Text);
            TextBox3.Text = b.div(i, j).ToString();
        }

        protected void Button26_Click(object sender, EventArgs e)
        {
            TextBox1.Text += Convert.ToString(1);
            
        }

        protected void Button16_Click(object sender, EventArgs e)
        {
            Addwebservice.WebService1 b = new Addwebservice.WebService1();
            int i = Convert.ToInt32(TextBox1.Text);
            int j = Convert.ToInt32(TextBox2.Text);
            TextBox3.Text = (b.Fact(i)/((b.Fact(i-j))*(b.Fact(j)))).ToString();

        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            Addwebservice.WebService1 b = new Addwebservice.WebService1();
            int i = Convert.ToInt32(TextBox1.Text);
            int j = Convert.ToInt32(TextBox2.Text);
            TextBox3.Text = (b.Fact(i) / b.Fact(j)).ToString();
        }

    }
}

