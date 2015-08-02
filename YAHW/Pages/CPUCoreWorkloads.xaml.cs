﻿using System.Windows.Controls;

namespace YAHW.Pages
{
    /// <summary>
    /// <para>
    /// Interaction logic for CPUCoreWorkloads.xaml
    /// </para>
    /// 
    /// <para>
    /// Class history:
    /// <list type="bullet">
    ///     <item>
    ///         <description>1.0: First release, working (Steffen Steinbrecher).</description>
    ///     </item>
    /// </list>
    /// </para>
    /// 
    /// <para>Author: Steffen Steinbrecher</para>
    /// <para>Date: 12.07.2015</para>
    /// </summary>
    public partial class CPUCoreWorkloads : UserControl
    {
        public CPUCoreWorkloads()
        {
            InitializeComponent();
            this.DataContext = new ViewModels.CPUCoreWorkloadsViewModel();
        }
    }
}