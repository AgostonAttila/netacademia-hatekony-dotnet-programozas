using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
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
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace XmlProject
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



        //ha datasetbe olvasom be utána ki tudom írni SQL be
        //XMleket lehet indexelni SQLben 

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //XmlWriterSettings s = new XmlWriterSettings();

            using (XmlWriter writer = XmlWriter.Create(@"y:\adatok.xml"))
            {
                writer.WriteStartElement("adatok");
                writer.WriteAttributeString("ido", DateTime.Now.ToShortTimeString());

                writer.WriteElementString("adat", textBox1.Text);
                writer.WriteEndElement();

            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //XmlReaderSettings s = new XmlReaderSettings();

            using (XmlReader reader = XmlReader.Create(@"y:\adatok.xml"))
            {
                if (!reader.Read())
                    return;

                reader.Read();
                //reader.Move
                //reader.ReadTo

                if (reader.Name == "adatok")
                {
                    //reader.NodeType
                    textBlock1.Text = reader.GetAttribute("ido");

                    reader.Read();

                    // textBlock1.Text += reader.ReadString;
                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"y:\books_173733.xml");


            foreach (XmlNode book in doc.DocumentElement.ChildNodes)
            {
                //2.verzió
                XmlNode genreTipus = book.SelectSingleNode("genre[text()='Romance']");

                //3.verzió

                // // bármilyen mélységben keres    bookon belül genre keres     /.. szülőt jelöli
                var keresettek = doc.SelectNodes("//book/genre[text()=='Romance]/..'");

                //1.verzió
                XmlNode tipus = book.SelectSingleNode("genre");
                if (tipus != null && tipus.InnerText == "Romance")
                {
                    string id = ((XmlElement)book).GetAttribute("id");
                    string title = book.SelectSingleNode("title").InnerText;
                    textBox2.Text += String.Format("{0} {1}{2}", id, title, Environment.NewLine);
                }
                else
                {
                    book.Attributes["id"].Value += "hopp";
                }


                doc.Save(@"y:\modositott_books_173733.xml");
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            XDocument doc = XDocument.Load(@"y:\books_173733.xml");
            
            var books = from k in doc.Descendants()   //összes elem descendants
                        where k.Value == "Romance" && k.Name == "genre"
                        let titleElem = k.Parent.Elements().SingleOrDefault(f => f.Name == "title")
                        select new { id = k.Parent.Attribute("id").Value, title = titleElem == null ? "" : titleElem.Value };

            textBox2.Text = string.Join(Environment.NewLine, books);

            
            foreach (var book in doc.Descendants().Where(a=>a.HasElements)) //minden elemén amelyiknek van gyerek eleme
            {
                book.SetAttributeValue("mod", "ez megvolt");
            }

            doc.Save(@"y:\modositott_books_173733.xml");

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Konyv k = new Konyv()
            {
                Id = "id-01",
                Ar = 5.5M,
                KiadasDatuma = DateTime.Now,
                Leiras ="Ez egy demo",
                Mufaj = Mufajok.Horror,
                Szerzo = "JakabBea"
            };

            //<root xmlns: sd ="http://etc_">
            //<sd:elem></sd:elem>
            //</root>

            //xsd XML schema

            //Xml validálás --> névtér alapján

            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();//névtér lista
            ns.Add("", "");
            
            XmlSerializer ser = new XmlSerializer(typeof(Konyv));

            StringBuilder sb = new StringBuilder();            
            StringWriter writer = new StringWriter(sb);
            ser.Serialize(writer,k,ns);

            textBox3.Text = sb.ToString();


            //Visszaolvasni
            StringReader reader = new StringReader(textBox3.Text);
            Konyv k2 =(Konyv)ser.Deserialize(reader);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            label1.Content = ConfigurationManager.AppSettings["logoUrl"];
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            label2.Content =  Beallitasok.Default.X;

            Beallitasok.Default.X++;

            label2.Content = Beallitasok.Default.X;

            Beallitasok.Default.Save(); 
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            label3.Content = VeseConfig.Default.LogoUrl;

            //ConfigurationManager.OpenExeConfiguration() fájlt nyitja meg


        }
    }
}
