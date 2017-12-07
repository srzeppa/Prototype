using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Prototype.Extension
{
    public static class DeepCloneExtension
    {

        public static T DeepClone<T>(this T obj)
        {
            if (obj == null)
            {
                return default(T);
            }
            var bf = new BinaryFormatter();

            using (var ms = new MemoryStream())
            {
                bf.Serialize(ms, obj);
                ms.Seek(0, SeekOrigin.Begin);
                return (T) bf.Deserialize(ms);
            }
        }

    }
}
