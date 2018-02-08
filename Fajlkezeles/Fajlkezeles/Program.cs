using Ionic.Zip;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Fajlkezeles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] files = Directory.GetFiles(@"y:\vmi\", "*.txt", SearchOption.AllDirectories);

            // Directory.GetFileSystemEntries() mindent visszaad

            //Directory.Exists();

            //File.Copy

            //File.Move renamenel is ez kell

            foreach (var file in files)
            {
                Console.WriteLine(file);

                // string fileTartalom = File.ReadAllText(file);
                // Console.WriteLine(fileTartalom);

                //var fileTartalom = File.ReadAllLines(file);
                //Console.WriteLine(fileTartalom.FirstOrDefault());

                //var secList = File.GetAccessControl(file).GetAccessRules(true,true,typeof(NTAccount));
                //foreach (var item in secList)
                //{

                //}
                string dir = Path.GetDirectoryName(file);
                string fileName = Path.GetFileNameWithoutExtension(file);
                string ext = Path.GetExtension(file);

                Console.WriteLine("{0}{1}{2}", dir, Path.DirectorySeparatorChar, fileName);
                Console.WriteLine(Path.Combine(dir, fileName));

                //Console.WriteLine(Path.ChangeExtension(Path.Combine(dir, fileName),"alma")+ext);

                //File.Move(,"")


                FileInfo fi = new FileInfo(file);
                Int64 length = fi.Length;
            }

            DirectoryInfo di = new DirectoryInfo(@"c:\cucc");

            //DriveInfo.GetDrives()[0].AvailableFreeSpace;


            //Streamek

            FileStream fs = File.Open(@"y:\cucc\vmi.txt", FileMode.Open, FileAccess.Read);

            //Stream s;
            //s.Read();

            StreamReader sr = new StreamReader(fs);

            //fs.Read(fs,)
            sr.ReadLine();

            using (FileStream fs2 = File.Open(@"y:\vmi.txt", FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs2))
                {
                    sw.WriteLine("Heloo Leo");
                }
            }
            //sw.Dispose();            
            //fs.Close();



            //using (FileStream fs3 = File.Open(@"y:\cucc\vmi.txt", FileMode.Open, FileAccess.Read))
            //{
            //    using (var ds = File.OpenWrite(@"c:\cucc\masolat.zip"))
            //    {
            //        using (GZipStream zip = new GZipStream(ds, CompressionMode.Compress))
            //        {
            //            fs.CopyTo(zip);
            //        }
            //    }
            //}


            using (ZipFile zip = new ZipFile())
            {
                //zip.MaxOutputSegmentSize();  darabolás

                zip.AddFile("klklklk","");
                zip.AddDirectory("klklklk");
                zip.AddFile("klklklk");

                zip.Save(@"y:\zippeltem.zip");
            }




            PdfDocument document = new PdfDocument();
            PdfPage page = document.AddPage();

            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Verdana", 20, XFontStyle.Bold);


            gfx.DrawString("Hello Lailo", font, XBrushes.Red, new System.Drawing.PointF(100, 100));

            MemoryStream ms = new MemoryStream();
            document.Save(ms);

            //File(ms, "application/pdf");
        }
    }
}
