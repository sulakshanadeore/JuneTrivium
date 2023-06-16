using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //File.Create("hello.txt");

            //File.Create("D:\\NewDrive\\TriviumDemos\\secondfile.txt");

            //File.Copy("hello.txt", "D:\\NewDrive\\TriviumDemos\\hello.txt");

            //File.Delete("D:\\NewDrive\\TriviumDemos\\hello.txt");
            //File.Move("D:\\NewDrive\\TriviumDemos\\secondfile.txt", "secondfilecopy.txt");
            //File.WriteAllText("secondfilecopy.txt", "This is a demo showing overWriting of file using WriteAllText");
            //File.AppendAllText("secondfilecopy.txt", "      This is the appended content");

            // Directory.CreateDirectory("Folder1");

            //FileInfo fi = new FileInfo("secondfilecopy.txt");
            //string dirname=fi.DirectoryName;
            //Console.WriteLine(dirname);
            //bool a=fi.Exists;
            //Console.WriteLine(a);

            //DirectoryInfo directoryInfo = new DirectoryInfo(dirname);
            Console.WriteLine("enter choice \n 1.Write \n 2. Read \n 3.Append \n 4. Exit");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {

                case 1:

  CreateFile();

                 break;
                    case 2:
                    ReadFile();
                    break;
                    case 3:
                    AppendFile();
                    break;
                case 4:
                    Environment.Exit(1);
                    break;

                default:
                    break;
            }
          

            


            Console.Read();

        }

        private static void AppendFile()
        {
            // throw new NotImplementedException();
            FileStream fs = null;
            StreamWriter sw = null;
            try
            {
                fs = new FileStream("custdata.txt", FileMode.Append, FileAccess.Write);
                sw = new StreamWriter(fs);
                sw.Write("Thsis is appended content using Mode Append and File Access as Write");
                    sw.Flush();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {

                sw.Close();
                fs.Close();
                sw.Dispose();
                fs.Dispose();
            }



        }

        private static void ReadFile()
        {
            // throw new NotImplementedException();
            FileStream fs = null;
            StreamReader sr = null;
            try
            {
                fs = new FileStream("custdata.txt", FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);
              string s = sr.ReadToEnd();
                Console.WriteLine(s);

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {

                sr.Close();
                fs.Close();
                sr.Dispose();
                fs.Dispose();
            }

        }

        private static void CreateFile()
        {
            #region CreateAndWriteToFile
            FileStream fs = null;
            StreamWriter sw = null;
            try
            {
                Console.WriteLine("Enter file name");
                string fname=Console.ReadLine();
                fs = new FileStream(fname, FileMode.Create, FileAccess.Write);
                sw = new StreamWriter(fs);
                Console.WriteLine("enter the content u want to write to the file");
                string contents=Console.ReadLine();
                sw.Write(contents);
                sw.Flush();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {

                sw.Close();
                fs.Close();
                sw.Dispose();
                fs.Dispose();
            }
            #endregion
        }
    }
}
