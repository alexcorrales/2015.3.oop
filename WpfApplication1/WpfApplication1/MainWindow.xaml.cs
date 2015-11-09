﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text.ToUpper();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (!this.textBox1.Text.Trim().Equals(""))
            {
                this.listBox1.Items.Add(this.textBox1.Text);
            }

            this.textBox1.Text = "";

            this.textBox1.Focus();
        }

        private void limpiarBtn_Click(object sender, RoutedEventArgs e)
        {
            this.listBox1.Items.Clear();
        }
    }
}
