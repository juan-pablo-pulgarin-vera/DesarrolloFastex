﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pedidos
{
    public partial class Formpe : Form 
    {
        public Formpe()
        {
            InitializeComponent();
           

        }

  
        
        
        private void nike1_Click(object sender, EventArgs e)
        {
            Carrito obj = new Carrito();

            obj.nike1();
            obj.Show();
            
        }

        private void Nike2_Click(object sender, EventArgs e)
        {
            Carrito obj = new Carrito();

            obj.nike2();
            obj.Show();
        }

        private void Nike3_Click(object sender, EventArgs e)
        {
            Carrito obj = new Carrito();

            obj.nike3();
            obj.Show();
        }

        private void Nike4_Click(object sender, EventArgs e)
        {
            Carrito obj = new Carrito();

            obj.nike4();
            obj.Show();
        }

        private void puma1_Click(object sender, EventArgs e)
        {
            Carrito obj = new Carrito();

            obj.puma1();
            obj.Show();
        }
    

     
       


      

      

     


        private void exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adidas4_Click_1(object sender, EventArgs e)
        {
            Carrito obj = new Carrito();

            obj.adidas4();
            obj.Show();
        }

        private void adidas3_Click(object sender, EventArgs e)
        {
            Carrito obj = new Carrito();

            obj.adidas3();
            obj.Show();
        }

        private void adidas2_Click_1(object sender, EventArgs e)
        {

            Carrito obj = new Carrito();

            obj.adidas2();
            obj.Show();
        }

        private void adidas1_Click_1(object sender, EventArgs e)
        {
            Carrito obj = new Carrito();

            obj.adidas1();
            obj.Show();
        }

        private void puma4_Click_1(object sender, EventArgs e)
        {
            Carrito obj = new Carrito();

            obj.puma3();
            obj.Show();
        }

        private void puma3_Click_1(object sender, EventArgs e)
        {
            Carrito obj = new Carrito();

            obj.puma3();
            obj.Show();
        }

        private void puma2_Click_1(object sender, EventArgs e)
        {
            Carrito obj = new Carrito();

            obj.puma2();
            obj.Show();
        }
    }
}
