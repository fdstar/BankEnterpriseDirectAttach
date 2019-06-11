using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEDA.Utils
{
    /// <summary>
    /// GZip压缩辅助类
    /// </summary>
    public class GZipHelper
    {
        /// <summary>
        /// Gzip压缩
        /// </summary>
        /// <param name="data">待压缩数据</param>
        /// <returns></returns>
        public static byte[] Compress(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                var stream = new GZipStream(ms, CompressionMode.Compress, true);
                stream.Write(data, 0, data.Length);
                stream.Close();
                return ms.ToArray();
            }
        }
        /// <summary>
        /// GZip解压缩
        /// </summary>
        /// <param name="data">待解压数据</param>
        /// <returns></returns>
        public static byte[] Decompress(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                using (Stream inStream = new GZipStream(ms, CompressionMode.Decompress))
                using (MemoryStream outStream = new MemoryStream())
                {
                    byte[] buffer = new byte[4096];
                    int size = inStream.Read(buffer, 0, (int)buffer.Length);
                    while (size > 0)
                    {
                        outStream.Write(buffer, 0, size);
                        size = inStream.Read(buffer, 0, (int)buffer.Length);
                    }
                    return outStream.ToArray();
                }
            }
        }
    
    }
}
