namespace Test
{
      public class B
      {
            private readonly A _a;
            public B(A a)
            {
                  this._a = a;
            }

            public int Number { get; set; }

            public override string ToString()
            {
#if NETFRAMEWORK
      return $"B Number: {this.Number}, A ID: {this._a.ID} [.net40]";
#elif NET9_0
      return $"B Number: {this.Number}, A ID: {this._a.ID} [.net90]";
#elif NET6_0 && WINDOWS
      return $"B Number: {this.Number}, A ID: {this._a.ID} [.net60 win]";
#elif NET6_0
      return $"B Number: {this.Number}, A ID: {this._a.ID} [.net60]";
#else
#error This code block does not match csproj TargetFrameworks list
#endif
            }
      }
}

