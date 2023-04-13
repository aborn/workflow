using Microsoft.Win32;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using WorkFlow.Model;

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
