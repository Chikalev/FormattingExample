namespace FormatsExample
{
   public interface IContentProcessorFactory
   {
      IContentProcessor CreateContentProcessor(string fileContent);
   }
}