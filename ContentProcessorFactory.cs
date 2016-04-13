using FormatsExample.FileProcessors;

namespace FormatsExample
{
   class ContentProcessorFactory : IContentProcessorFactory
   {
      /// <summary>
      /// При добавлении нового формата файла здесь нужно создавать обработчик нового типа
      /// </summary>
      /// <param name="fileContent"></param>
      /// <returns></returns>
      public IContentProcessor CreateContentProcessor(string fileContent)
      {
         if (string.IsNullOrEmpty(fileContent))
            return new EmptyContentProcessor();

         if (fileContent.IndexOf("<html") != -1)
            return new HtmlProcessor();

         return new TextProcessor();
      }
   }
}
