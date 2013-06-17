using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Windows.Forms;

namespace WpfPixelPerfect
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.loadButton.Click += (o, e) =>
            {
                var dialog = new OpenFileDialog();

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var source = new BitmapImage();

                    source.BeginInit();
                    source.UriSource = new Uri(dialog.FileName, UriKind.Absolute);
                    source.EndInit();

                    this.screen.Source = source;
                }

            
            };

            this.screen.MouseLeftButtonDown += (o, e) => this.DragMove();
            this.controlPanel.MouseLeftButtonDown += (o, e) => this.DragMove();
            this.close.Click += (o, e) => this.Close();
        }
    }
}
