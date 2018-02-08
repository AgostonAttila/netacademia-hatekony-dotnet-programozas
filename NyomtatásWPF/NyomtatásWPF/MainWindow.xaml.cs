using System;
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

namespace NyomtatásWPF
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog dialog = new PrintDialog();
            if (dialog.ShowDialog() ?? false)
            {
                //dialog.PrintableAreaWidth
                Oldal o = new Oldal();
                o.Measure(new Size(dialog.PrintableAreaWidth, dialog.PrintableAreaHeight));
                o.Arrange(new Rect(0,0,dialog.PrintableAreaWidth, dialog.PrintableAreaHeight)); //újra rajzol/rendez
                dialog.PrintVisual(o, "nyomtatasi sor"); 

                //dialog.PrintVisual(panelova,"nyomtatasi sor");            
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
             PrintDialog dialog = new PrintDialog();
             if (dialog.ShowDialog() ?? false)
             {
                 //Documentum összeállitás
                 FixedDocument document = new FixedDocument();
                 document.DocumentPaginator.PageSize = new Size(dialog.PrintableAreaWidth, dialog.PrintableAreaHeight);
                 
                 FixedPage page1 = new FixedPage();
                 page1.Width = document.DocumentPaginator.PageSize.Width;
                 page1.Height = document.DocumentPaginator.PageSize.Height;


                 Rectangle rec = new Rectangle() { Width = 100, Height = 200, Fill = Brushes.LightGreen };
                 TextBlock tb = new TextBlock { Text = "Első oldal" };
                 tb.FontSize = 40;

                 page1.Children.Add(rec);
                 page1.Children.Add(tb);

                 PageContent p1c = new PageContent();
                 p1c.Child = page1;

                 document.Pages.Add(p1c);
                 //kész a document

                 documentViewer1.Document = document;

                 dialog.PrintDocument(document.DocumentPaginator,"desc");
             }
        }


    }
}
