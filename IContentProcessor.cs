namespace FormatsExample
{
   public interface IContentProcessor
   {
      /// <summary>
      /// На самом деле лучше возвращать флаг (успех/неудача) или перечисление, показывающее статус
      /// </summary>
      void Process(string content);
   }
}