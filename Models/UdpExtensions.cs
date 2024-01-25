using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace PolyhydraSoftware.Core.UDP;
public static class UdpExtensions
{
    // Convert an object to a JSON string
    public static string ObjectToJsonString<T>(this T obj)
    {
        DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
        using MemoryStream ms = new MemoryStream();
        serializer.WriteObject(ms, obj);
        return Encoding.UTF8.GetString(ms.ToArray());
    }

    // Convert a JSON string to an object
    public static T JsonStringToObject<T>(this string jsonString)
    {
        DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
        using MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonString));
        return (T)serializer.ReadObject(ms);
    }
}