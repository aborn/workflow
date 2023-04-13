using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WorkFlow.Model;
using static System.Reflection.Metadata.BlobBuilder;

namespace WorkFlow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        
        public DelegateCommand NewFlowCommand { get; private set; }
        public DelegateCommand OpenFlowCommand { get; private set; }
        public DelegateCommand SaveFlowCommand { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
            NewFlowCommand = new DelegateCommand(NewFlowCommandCallback);
            OpenFlowCommand = new DelegateCommand(OpenFlowCommandCallback);
            SaveFlowCommand = new DelegateCommand(SaveFlowCommandCallback);
        }

        private void NewFlowCommandCallback(object parameter)
        {
           
        }

        private void OpenFlowCommandCallback(object parameter)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XFlow files (*.xflow)|*.xflow";
            openFileDialog.FilterIndex = 1;

            if (openFileDialog.ShowDialog() != true)
                return;

            // Open(openFileDialog.FileName);
        }
        private void SaveFlowCommandCallback(object parameter)
        {
            //if (CurrentFlow != null)
            //    Save(CurrentFlow);
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string property = null)
        {
            if (property != null && PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }
}
