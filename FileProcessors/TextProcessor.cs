using System;

namespace FormatsExample.FileProcessors
{
   internal class TextProcessor : IContentProcessor
   {
      public void Process(string fileContent)
      {
         Console.WriteLine("Text");
      }
   }
}