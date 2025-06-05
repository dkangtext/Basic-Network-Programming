using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using CollaborativeWhiteboard.Models;

namespace CollaborativeWhiteboard.Services
{
    public class SerializationService
    {
        public byte[] SerializeWhiteboardState(WhiteboardState state)
        {
            using (var memoryStream = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(memoryStream, state);
                return memoryStream.ToArray();
            }
        }

        public WhiteboardState DeserializeWhiteboardState(byte[] data)
        {
            using (var memoryStream = new MemoryStream(data))
            {
                var formatter = new BinaryFormatter();
                return (WhiteboardState)formatter.Deserialize(memoryStream);
            }
        }
    }
}