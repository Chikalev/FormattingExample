using System;
using Funq;

namespace FormatsExample
{
   class Program
   {
      private static readonly Container Container = new Container();

      static void Main(string[] args)
      {
         Configure();
         //Test(fileName);
         Console.ReadLine();
      }

      /// <summary>
      /// Используется простой IoC-контейнер из библиотеки Funq (для примера)
      /// </summary>
      private static void Configure()
      {
         Container.Register<IContentProcessorFactory>(new ContentProcessorFactory());
         Container.Register<IFileContentProvider>(new FileContentProvider());
      }

      private static void Test(string fileName)
      {
         var provider = Container.Resolve<IFileContentProvider>();
         var content = provider.GetFileContent(fileName);
         
         var processorFactory = Container.Resolve<IContentProcessorFactory>();
         var contentProcessor = processorFactory.CreateContentProcessor(content);
         contentProcessor.Process(content);
      }
   }
}
