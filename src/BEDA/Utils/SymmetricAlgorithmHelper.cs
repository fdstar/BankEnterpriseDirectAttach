using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BEDA.Utils
{
    using System.Security.Cryptography;
    /// <summary>
    /// 对称加密帮助类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SymmetricAlgorithmHelper<T>
        where T : SymmetricAlgorithm, new()
    {
        /// <summary>
        /// 加密 ECB PKCS7模式
        /// </summary>
        /// <param name="str">要加密的数据</param>
        /// <param name="key">秘钥（base64格式）</param>
        /// <returns>加密后的结果（base64格式）</returns>
        public static string EncryptWithECB(string str, string key)
        {
            return EncryptWithECB(str, Convert.FromBase64String(key));
        }
        /// <summary>
        /// 加密 ECB PKCS7模式
        /// </summary>
        /// <param name="str">要加密的数据</param>
        /// <param name="key">秘钥</param>
        /// <returns>加密后的结果（base64格式）</returns>
        public static string EncryptWithECB(string str, byte[] key)
        {
            var toEncryptArray = Encoding.UTF8.GetBytes(str);
            return Convert.ToBase64String(Encrypt(toEncryptArray, key, null, CipherMode.ECB, PaddingMode.PKCS7));
        }
        /// <summary>
        /// 解密 ECB PKCS7模式
        /// </summary>
        /// <param name="str">要解密的数据（base64格式）</param>
        /// <param name="key">秘钥（base64格式）</param>
        /// <returns>utf-8编码返回解密后得数据</returns>
        public static string DecryptWithECB(string str, string key)
        {
            return DecryptWithECB(str, Convert.FromBase64String(key));
        }
        /// <summary>
        ///  3DES 解密 ECB PKCS7模式
        /// </summary>
        /// <param name="str">要解密的数据（base64格式）</param>
        /// <param name="key">秘钥</param>
        /// <returns>utf-8编码返回解密后得数据</returns>
        public static string DecryptWithECB(string str, byte[] key)
        {
            var toDecryptArray = Convert.FromBase64String(str);
            return Encoding.UTF8.GetString(Decrypt(toDecryptArray, key, null, CipherMode.ECB, PaddingMode.PKCS7));
        }
        /// <summary>
        /// 加密 CBC PKCS7模式
        /// </summary>
        /// <param name="str">要加密的数据</param>
        /// <param name="key">秘钥（base64格式）</param>
        /// <param name="iv">向量（base64格式）</param>
        /// <returns>加密后的结果（base64格式）</returns>
        public static string EncryptWithCBC(string str, string key, string iv)
        {
            return EncryptWithCBC(str, Convert.FromBase64String(key), Convert.FromBase64String(iv));
        }
        /// <summary>
        /// 加密 CBC PKCS7模式
        /// </summary>
        /// <param name="str">要加密的数据</param>
        /// <param name="key">秘钥</param>
        /// <param name="iv">向量</param>
        /// <returns>加密后的结果（base64格式）</returns>
        public static string EncryptWithCBC(string str, byte[] key, byte[] iv)
        {
            var toEncryptArray = Encoding.UTF8.GetBytes(str);
            return Convert.ToBase64String(Encrypt(toEncryptArray, key, iv, CipherMode.CBC, PaddingMode.PKCS7));
        }
        /// <summary>
        /// 解密 CBC PKCS7模式
        /// </summary>
        /// <param name="str">要解密的数据（base64格式）</param>
        /// <param name="key">秘钥（base64格式）</param>
        /// <param name="iv">向量（base64格式）</param>
        /// <returns>utf-8编码返回解密后得数据</returns>
        public static string DecryptWithCBC(string str, string key, string iv)
        {
            return DecryptWithCBC(str, Convert.FromBase64String(key), Convert.FromBase64String(iv));
        }
        /// <summary>
        ///  解密 CBC PKCS7模式
        /// </summary>
        /// <param name="str">要解密的数据（base64格式）</param>
        /// <param name="key">秘钥</param>
        /// <param name="iv">向量</param>
        /// <returns>utf-8编码返回解密后得数据</returns>
        public static string DecryptWithCBC(string str, byte[] key, byte[] iv)
        {
            var toDecryptArray = Convert.FromBase64String(str);
            return Encoding.UTF8.GetString(Decrypt(toDecryptArray, key, iv, CipherMode.CBC, PaddingMode.PKCS7));
        }
        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="data">要加密的数据</param>
        /// <param name="key">秘钥</param>
        /// <param name="iv">向量</param>
        /// <param name="cipherMode">块模式</param>
        /// <param name="paddingMode">填充模式</param>
        /// <returns>加密后得到的数组</returns>
        public static byte[] Encrypt(byte[] data, byte[] key, byte[] iv, CipherMode cipherMode, PaddingMode paddingMode)
        {
            return Transform(data, cipherMode, paddingMode, algorithm => algorithm.CreateEncryptor(key, iv));
        }
        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="data">要解密的数据</param>
        /// <param name="key">秘钥</param>
        /// <param name="iv">向量</param>
        /// <param name="cipherMode">块模式</param>
        /// <param name="paddingMode">填充模式</param>
        /// <returns>解密后的到的数组</returns>
        public static byte[] Decrypt(byte[] data, byte[] key, byte[] iv, CipherMode cipherMode, PaddingMode paddingMode)
        {
            return Transform(data, cipherMode, paddingMode, algorithm => algorithm.CreateDecryptor(key, iv));
        }
        private static byte[] Transform(byte[] data, CipherMode cipherMode, PaddingMode paddingMode, Func<T, ICryptoTransform> func)
        {
            using (T algorithm = new T
            {
                Mode = cipherMode,
                Padding = paddingMode
            })
            {
                using (ICryptoTransform cTransform = func(algorithm))
                {
                    return cTransform.TransformFinalBlock(data, 0, data.Length);
                }
            }
        }
        /// <summary>
        /// 生成秘钥
        /// </summary>
        /// <param name="key">秘钥(base64格式)</param>
        /// <param name="iv">iv向量(base64格式)</param>
        /// <param name="keySize">要生成的KeySize</param>
        public static void Create(out string key, out string iv, int keySize)
        {
            KeyGenerator.CreateSymmetricAlgorithmKey<T>(out key, out iv, keySize);
        }
    }
    /// <summary>
    /// TripleDESHelper
    /// </summary>
    public class TripleDESHelper : SymmetricAlgorithmHelper<TripleDESCryptoServiceProvider>
    {
        /// <summary>
        /// 生成秘钥
        /// </summary>
        /// <param name="key">秘钥(base64格式)</param>
        /// <param name="iv">iv向量(base64格式)</param>
        /// <param name="keySize">要生成的KeySize，只支持128、192</param>
        public static new void Create(out string key, out string iv, int keySize = 192)
        {
            KeyGenerator.CreateSymmetricAlgorithmKey<TripleDESCryptoServiceProvider>(out key, out iv, keySize);
        }
    }
    /// <summary>
    /// AESHelper
    /// </summary>
    public class AESHelper : SymmetricAlgorithmHelper<AesCryptoServiceProvider>//RijndaelManaged
    {
        /// <summary>
        /// 生成秘钥
        /// </summary>
        /// <param name="key">秘钥(base64格式)</param>
        /// <param name="iv">iv向量(base64格式)</param>
        /// <param name="keySize">要生成的KeySize，只支持128、192、256，java一般生成的秘钥长度为128，所以这里默认也采用128</param>
        public static new void Create(out string key, out string iv, int keySize = 128)
        {
            KeyGenerator.CreateSymmetricAlgorithmKey<AesCryptoServiceProvider>(out key, out iv, keySize);
        }
    }
    /// <summary>
    /// DESHelper
    /// </summary>
    public class DESHelper : SymmetricAlgorithmHelper<DESCryptoServiceProvider>
    {
        /// <summary>
        /// 生成秘钥
        /// </summary>
        /// <param name="key">秘钥(base64格式)</param>
        /// <param name="iv">iv向量(base64格式)</param>
        /// <param name="keySize">要生成的KeySize，DES只支持64，所以此处切勿传其它值</param>
        public static new void Create(out string key, out string iv, int keySize = 64)
        {
            KeyGenerator.CreateSymmetricAlgorithmKey<DESCryptoServiceProvider>(out key, out iv, keySize);
        }
    }
    /// <summary>
    /// RC2Helper
    /// </summary>
    public class RC2Helper : SymmetricAlgorithmHelper<RC2CryptoServiceProvider>
    {
        /// <summary>
        /// 生成秘钥
        /// </summary>
        /// <param name="key">秘钥(base64格式)</param>
        /// <param name="iv">iv向量(base64格式)</param>
        /// <param name="keySize">要生成的KeySize，支持的MinSize:40 MaxSize:128 SkipSize:8</param>
        public static new void Create(out string key, out string iv, int keySize = 96)
        {
            KeyGenerator.CreateSymmetricAlgorithmKey<RC2CryptoServiceProvider>(out key, out iv, keySize);
        }
    }
}
