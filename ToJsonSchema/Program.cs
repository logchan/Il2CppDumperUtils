using System.IO;
using Newtonsoft.Json.Schema.Generation;

namespace ToJsonSchema {
    class Program {
        static void Main(string[] args) {
            var generator = new JSchemaGenerator();
            var schema = generator.Generate(typeof(Something));
            File.WriteAllText("R:/schema.json", schema.ToString());
        }
    }
}
