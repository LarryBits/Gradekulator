using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gradeculator
{
    
    public partial class GradeKulator : Telerik.WinControls.UI.ShapedForm
    {
        Functions obj;
        Total total;
        
        string resulty;
        double bxres;
        decimal spres;
        const string Z = "0";


        void Clear ()
        {
            Box1.Text = Z; Box7.Text = Z; Box16.Text = Z; SpinEditor7.Value = 0;
            Box2.Text = Z; Box8.Text = Z; Box17.Text = Z; SpinEditor8.Value = 0;
            Box3.Text = Z; Box9.Text = Z; Box18.Text = Z; SpinEditor9.Value = 0;
            Box2.Text = Z; Box10.Text = Z; SpinEditor1.Value = 0;
            Box2.Text = Z; Box11.Text = Z; SpinEditor2.Value = 0;
            Box3.Text = Z; Box12.Text = Z; SpinEditor3.Value = 0;
            Box4.Text = Z; Box13.Text = Z; SpinEditor4.Value = 0;
            Box5.Text = Z; Box14.Text = Z; SpinEditor5.Value = 0;
            Box6.Text = Z; Box15.Text = Z; SpinEditor6.Value = 0;
            radTextBox1.Text = "YOUR RESULT HERE"; Box20.Text = String.Empty; Box19.Text = String.Empty;
        }
        public GradeKulator()
        {
            InitializeComponent();
        }

        private void spb1(object sender, EventArgs e)
        {
            
            obj.Func1(Box1.Text, SpinEditor1.Value,out resulty);
            Box10.Text = resulty;
        }

        private void spb2(object sender, EventArgs e)
        {
            
            obj.Func1(Box2.Text, SpinEditor2.Value, out resulty);
            Box11.Text = resulty;

        }

        private void spb3(object sender, EventArgs e)
        {
            
            obj.Func1(Box3.Text, SpinEditor3.Value, out resulty);
            Box12.Text = resulty;

        }

        private void spb4(object sender, EventArgs e)
        {
           
            obj.Func1(Box4.Text, SpinEditor4.Value, out resulty);
            Box13.Text = resulty;

        }

        private void spb5(object sender, EventArgs e)
        {
            
            obj.Func1(Box5.Text, SpinEditor5.Value, out resulty);
            Box14.Text = resulty;

        }

        private void spb6(object sender, EventArgs e)
        {
            
            obj.Func1(Box6.Text, SpinEditor6.Value, out resulty);
            Box15.Text = resulty;

        }

        private void spb7(object sender, EventArgs e)
        {
            
            obj.Func1(Box7.Text, SpinEditor7.Value, out resulty);
            Box16.Text = resulty;

        }

        private void spb8(object sender, EventArgs e)
        {
            
            obj.Func1(Box8.Text, SpinEditor8.Value, out resulty);
            Box17.Text = resulty;

        }

        private void spb9(object sender, EventArgs e)
        {
            
            obj.Func1(Box9.Text, SpinEditor9.Value, out resulty);
            Box18.Text = resulty;

        }

        private void Calculate(object sender, EventArgs e)
        {
            
            total.Calkulate(SpinEditor1.Value, SpinEditor2.Value, SpinEditor3.Value, SpinEditor4.Value, SpinEditor5.Value, SpinEditor6.Value, SpinEditor7.Value, SpinEditor8.Value,SpinEditor9.Value,out spres);
            Box20.Text = spres.ToString();
            double total1 = double.Parse(Box20.Text);
            //----------------------------------
            total.Calkulate(Box10.Text, Box11.Text, Box12.Text, Box13.Text, Box14.Text, Box15.Text, Box16.Text, Box17.Text,Box18.Text,out bxres);
            Box19.Text = bxres.ToString();
            double total2 = double.Parse(Box19.Text);
            double Total = (total2 / total1);
            string reslt=String.Format("{0:0.00}",Total);
            radTextBox1.Text = reslt;
        }

        private void clear(object sender, EventArgs e)
        {
            Clear();
        }

        private void radGroupBox2_Click(object sender, EventArgs e)
        {

        }

        private void radGroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed By: DYT(08131871049)\n (olanlokunlanre@gmail.com).", "ABOUT", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
