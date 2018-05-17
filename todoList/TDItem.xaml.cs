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

namespace todoList
{
    /// <summary>
    /// TDItem.xaml 的互動邏輯
    /// </summary>
    public partial class TDItem : UserControl
    {
        public TDItem()
        {
            InitializeComponent();
        }

        public string GetTaskName()
        {
            return TaskName.Text;
        }
    }
}
