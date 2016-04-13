using System;
using System.IO;

namespace FormatsExample
{
   public class FileContentProvider : IFileContentProvider
   {
      public string GetFileContent(string fileName)
      {
         Stream stream = null;

         try
         {
            stream = File.OpenRead(fileName);
            return getContent(stream);
         }
         catch (Exception exception)
         {
            //Пишем в лог исключение
            return string.Empty;
         }
         finally
         {
            stream?.Dispose();
         }
      }

      private static string getContent(Stream stream)
      {
         StreamReader streamReader = new StreamReader(stream);
         return streamReader.ReadToEnd();
      }
   }
}