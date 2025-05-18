namespace Test
{
    public class A
    {
        public int ID { get; set; }

        public override string ToString()
        {
#if NETFRAMEWORK
      return $"A ID: {this.ID} [.net40]";
#elif NET9_0
      return $"A ID: {this.ID} [.net90]";
#elif NET6_0 && WINDOWS
      return $"A ID: {this.ID} [.net60 win]";
#elif NET6_0
      return $"A ID: {this.ID} [.net60]";
#else
    #error This code block does not match csproj TargetFrameworks list
#endif
        }
    }
}

