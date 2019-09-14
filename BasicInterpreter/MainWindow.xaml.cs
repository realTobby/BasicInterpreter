using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BasicInterpreter
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ViewModels.MainViewModel viewModel;

        public MainWindow()
        {
            InitializeComponent();

            viewModel = new ViewModels.MainViewModel();
            this.DataContext = viewModel;

        }

        private void LoadTXTFile()
        {
            viewModel.BasicCode = System.IO.File.ReadAllText(viewModel.FilePath);
        }

        private void SaveTXTFile(string path, string content)
        {
            System.IO.File.WriteAllText(path, content);
        }

        private void ToolbarButton_open_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                viewModel.FilePath = dialog.FileName;
            }

            LoadTXTFile();

        }

        private void ToolbarButton_save_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                SaveTXTFile(dialog.FileName, viewModel.BasicCode);
            }
        }

        private void ToolbarButton_export_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ToolbarButton_new_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
