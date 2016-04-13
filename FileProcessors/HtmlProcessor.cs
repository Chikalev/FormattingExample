using System;

namespace FormatsExample.FileProcessors
{
   class HtmlProcessor : IContentProcessor
   {
      public void Process(string content)
      {
         Console.WriteLine("HTML");
      }
   }
}