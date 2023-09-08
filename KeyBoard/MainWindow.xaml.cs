using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KeyBoard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string[] rows =
            {
                "QWERTYUIOP",
                "ASDFGHJKL",
                "ZXCVBNM"
            };
            foreach(string row in rows)
            {
                foreach(char c in row)
                {
                    Button btn = new Button();
                    btn.Content = c;
                    btn.Tag = c;
                    buttonPanel.Children.Add(btn);

                }
                    
            }
            Button backspaceBtn = new Button();
            backspaceBtn.Content = "Backspace";
            Button enterBtn = new Button();
            enterBtn.Content = "Enter";
            buttonPanel.Children.Add(backspaceBtn);
            buttonPanel.Children.Add(enterBtn);
        }
    }
}
