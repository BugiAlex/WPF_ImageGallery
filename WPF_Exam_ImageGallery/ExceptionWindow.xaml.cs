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
using System.Windows.Shapes;

namespace WPF_Exam_ImageGallery
{
    /// <summary>
    /// Interaction logic for ExceptionWindow.xaml
    /// </summary>
    public partial class ExceptionWindow : Window
    {

        public ExceptionWindow( string message_)
        {
            InitializeComponent();
            ExceptionMassage.Text = message_;
           
        }

        private void Clic_Ok(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
