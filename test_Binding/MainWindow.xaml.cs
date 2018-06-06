using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace test_Binding
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }

    public class MainWindowVM : INotifyPropertyChanged
    {

        #region TextInVM変更通知プロパティ
        private string _TextInVM;

        public string TextInVM
        {
            get
            { return _TextInVM; }
            set
            {
                if (_TextInVM == value)
                    return;
                _TextInVM = value;
                RaisePropertyChanged("TextInVM");
            }
        }
        #endregion

        public MainWindowVM()
        {
            TextInVM = "VM_TextInVM";
        } 


        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
