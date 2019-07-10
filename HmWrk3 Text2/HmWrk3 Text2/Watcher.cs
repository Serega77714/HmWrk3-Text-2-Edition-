using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace HmWrk3_Text2
{
    public class Watcher
    {

        public async void Run()
        {
            await Task.Run(() => Run1());
        }


        public string con = "y";
        public string NewPath;
        public void Run1()
        {
            
            string gotor = @"c:\Users\User\Desktop\Source";
            Console.WriteLine("Сatalog monitoring: {0}", gotor);
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = gotor;
            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            watcher.Filter = "*.*";

            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnDeleted);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);

            watcher.EnableRaisingEvents = true;
            
            while (con != "N" || con != "n");
           
        }
                private void OnChanged(object sender, FileSystemEventArgs e)
                {
                    NewPath = e.FullPath;
                    Console.WriteLine("Новый файл: " + e.Name + "\r\nДействие произведенное с ним: " + e.ChangeType + "\r\nПуть до файла: " + e.FullPath + "\r\n");
                    ReadWriter.sourceFilePath = e.FullPath;
                    ReadWriter.WriteWordsOrderByAlphabet();
                    Console.WriteLine($"Text from new file {e.Name} was splited on words and order by alphabet");
                    Console.WriteLine("and added to file TextWordOrderByAlphabet.txt");
                }
                private void OnDeleted(object sender, FileSystemEventArgs e)
                {
                    Console.WriteLine("Файл удален: " + e.Name + "\r\nДействие произведенное с ним: " + e.ChangeType + "\r\nФайл удален из: " + e.FullPath + "\r\n");
                }
                private void OnRenamed(object sender, RenamedEventArgs e)
                {
                    NewPath = e.FullPath;
                    Console.WriteLine("Файл {0} переименован в: {1}", e.OldFullPath, e.FullPath);
                }
    }
}
