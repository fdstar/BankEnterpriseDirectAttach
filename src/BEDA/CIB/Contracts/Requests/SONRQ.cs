using BEDA.Utils;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 登录请求消息实体
    /// </summary>
    public class SONRQ
    {
        /// <summary>
        /// 是否加密
        /// </summary>
        private bool _isEncryption;
        /// <summary>
        /// 字符串编码方式
        /// </summary>
        private string _encoding;
        /// <summary>
        /// 用户密码
        /// </summary>
        private string _userPass;
        /// <summary>
        /// 用户密码加密秘钥
        /// </summary>
        private static readonly byte[] _enKey = new byte[] { 1, 16, 2, 32, 51, 103, 256 - 119, 256 - 17 };
        /// <summary>
        /// 构造函数，默认用户密码加密
        /// </summary>
        public SONRQ()
            : this(true)
        {
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="isEncryption">是否加密，true表示加密</param>
        /// <param name="encoding">字符串编码方式，之所以提供该参数是因为可能存在服务端与客户端实际语言环境不一致的问题，默认为null，代表使用当前系统语言编码方式</param>
        public SONRQ(bool isEncryption, string encoding = null)
        {
            this._isEncryption = isEncryption;
            this._encoding = encoding;
        }
        /// <summary>
        /// 客户端日期时间，yyyy-MM-dd HH:mm:ss，必输
        /// </summary>
        [XmlElement(Order = 0)]
        public string DTCLIENT { get; set; } = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        /// <summary>
        /// 企业网银客户号，10位数字字符，必输
        /// </summary>
        [XmlElement(Order = 1)]
        public long CID { get; set; }
        /// <summary>
        /// 登录用户名，最长：20位，必输
        /// </summary>
        [XmlElement(Order = 2)]
        public string USERID { get; set; }
        /// <summary>
        /// 登录密码，最长：30位，必输
        /// 提供登录密码采用明文和密文两种方式，两者兼容；
        /// 如果采用密文方式，需使用银行提供的加密包cibFoxDesUtil.jar
        /// </summary>
        [XmlElement(Order = 3)]
        public string USERPASS
        {
            get
            {
                return this._userPass;
            }
            set
            {
                if (this._isEncryption && value != null)
                {
                    var enc = Encoding.Default;
                    if (!string.IsNullOrWhiteSpace(this._encoding))
                    {
                        enc = Encoding.GetEncoding(this._encoding);
                    }
                    var data = DESHelper.Encrypt(enc.GetBytes(value), _enKey, null, CipherMode.ECB, PaddingMode.PKCS7);
                    this._userPass = "{DES}" + Convert.ToBase64String(data);
                }
                else
                {
                    this._userPass = value;
                }
            }
        }
        /// <summary>
        /// USERKEY与(USERID和USERPASS)不同时出现，
        /// 由服务器在上一次请求响应中提供，建议使用(USERID和USERPASS)，必输
        /// </summary>
        [XmlElement(Order = 4)]
        public string USERKEY { get; set; }
        /// <summary>
        /// 是否需要服务器产生USERKEY，填Y、N，必输
        /// </summary>
        [XmlElement(Order = 5)]
        public string GENUSERKEY { get; set; } = "N";
        /// <summary>
        /// 希望服务器响应信息使用的语言，目前仅支持CHS(中文简体) ,非必输
        /// </summary>
        [XmlElement(Order = 6)]
        public string LANGUAGE { get; set; }
        /// <summary>
        /// 客户端应用程序编码，五个字符,非必输
        /// </summary>
        [XmlElement(Order = 7)]
        public string APPID { get; set; }
        /// <summary>
        /// 客户端应用程序版本nnnn,非必输
        /// </summary>
        [XmlElement(Order = 8)]
        public string APPVER { get; set; }
    }
}