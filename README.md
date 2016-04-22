# FormattingExample
Есть класс, который занимается обработкой файлов разного формата. Предполагается, что будут добавляться новые форматы файлов. 
Какие вы видите проблемы в реализации?
Проанализируйте реализацию данного класса и предложите рефакторинг, позволяющий расширять форматы обрабатываемых файлов.

public class FileProcessor
    {
        enum FileType
        {
            Html,  Text
        }
 
        public void ProcessFile(string fileName)
        {
            StreamReader fileStream = new StreamReader(File.OpenRead(fileName));
            string fileContent = fileStream.ReadToEnd();
 
            if (fileContent.IndexOf("<html") != -1)
                ProcessHtmlFile(fileContent);
            else ProcessTextFile(fileContent);
 
            ProcessFile(fileContent,fileContent.IndexOf("<html")!= -1?FileType.Html:FileType.Text);
            fileStream.Close();
 
        }
 
        private void ProcessFile(string content,  FileType fileType)
        {
            switch(fileType)
            {
                case FileType.Html:
                    ProcessHtmlFile(content);
                    break;
                case FileType.Text:
                    ProcessTextFile(content);
                    break;
                default:
                    throw new Exception("Unknown file format");
            }
        }
 
        private void ProcessHtmlFile(string content)
        {
            ....            
        }
 
        private void ProcessTextFile(string content)
        {
            ....
        }
 
    }
