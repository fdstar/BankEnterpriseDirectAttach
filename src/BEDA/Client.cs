using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace BEDA
{
    /// <summary>
    /// 银行客户端
    /// </summary>
    public abstract class Client : IClient
    {
#if NETSTANDARD2_0
        static Client()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }
#endif
        /// <summary>
        /// 银行调用构造
        /// </summary>
        /// <param name="host">ip地址或域名</param>
        /// <param name="port">端口号</param>
        /// <param name="scheme">请求协议，默认http</param>
        /// <param name="encoding">数据编码方式，默认gb2312</param>
        public Client(string host, int port, string scheme = "http", string encoding = "gb2312")
        {
            var url = string.Format("{0}://{1}:{2}", scheme, host, port);
            this.RestClient = new RestClient(url)
            {
                Encoding = Encoding.GetEncoding(encoding)
            };
        }
        /// <summary>
        /// <see cref="RestSharp.RestClient"/>
        /// </summary>
        public virtual IRestClient RestClient { get; protected set; }
    }
}
