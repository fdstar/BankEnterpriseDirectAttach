using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEDA.CITIC.Contracts.Requests;
using BEDA.CITIC.Contracts.Responses;
using BEDA.Utils;
using RestSharp;

namespace BEDA.CITIC
{
    /// <summary>
    /// 中信银行客户端
    /// </summary>
    public class CITICClient : Client, ICITICClient
    {
        /// <summary>
        /// 响应报文默认编码方式为GB18030，以解决GBK编码问题，如果赋值为null，则默认使用<see cref="RestClient.Encoding"/>
        /// </summary>
        public Encoding ResponseEncoding { get; set; }
        /// <summary>
        /// 中信银行调用构造
        /// </summary>
        /// <param name="host">ip地址或域名</param>
        /// <param name="port">端口号</param>
        /// <param name="scheme">请求协议，默认http</param>
        /// <param name="encoding">数据编码方式，默认gb2312</param>
        public CITICClient(string host, int port, string scheme = "http", string encoding = "gb2312")
            : base(host, port, scheme, encoding)
        {
            this.ResponseEncoding = Encoding.GetEncoding("GB18030");
        }
        /// <summary>
        /// 发起业务请求
        /// </summary>
        /// <typeparam name="Rs"></typeparam>
        /// <param name="request"></param>
        /// <param name="userName"></param>
        /// <returns></returns>
        public Rs Execute<Rs>(RqBase<Rs> request, string userName = null) where Rs : RsBase, new()
        {
            var restRequest = this.GetRestRequest(request, userName);
            var restResponse = this.RestClient.Execute(restRequest);
            return this.GetResponse<Rs>(restResponse);
        }
        /// <summary>
        /// 发起业务请求
        /// </summary>
        /// <typeparam name="Rs"></typeparam>
        /// <param name="request"></param>
        /// <param name="userName"></param>
        /// <returns></returns>
        public async Task<Rs> ExecuteAsync<Rs>(RqBase<Rs> request, string userName = null) where Rs : RsBase, new()
        {
            var restRequest = this.GetRestRequest(request, userName);
            var restResponse = await this.RestClient.ExecuteTaskAsync(restRequest).ConfigureAwait(false);
            return this.GetResponse<Rs>(restResponse);
        }
        private IRestRequest GetRestRequest<Rs>(RqBase<Rs> request, string userName)
             where Rs : IResponse
        {
            if (!string.IsNullOrWhiteSpace(userName))
            {
                request.UserName = userName;
            }
            var xml = XmlHelper.Serializer(request, encoding: this.RestClient.Encoding, showDeclaration: true, removeDefaultNameSpace: true);
            request.RequestContent = xml;
            var restRequest = new RestRequest(Method.POST);
            restRequest.AddParameter(new Parameter
            {
                Type = ParameterType.RequestBody,
                DataFormat = DataFormat.None,
                Value = xml,
                Name = ""
            });
            return restRequest;
        }
        private Rs GetResponse<Rs>(IRestResponse response)
            where Rs : RsBase, new()
        {
            response.SetResponseEncoding(this.ResponseEncoding ?? this.RestClient.Encoding);
            var rs = XmlHelper.Deserialize<Rs>(response.Content);
            if (rs == null)
            {
                rs = new Rs();
            }
            rs.ResponseContent = response.Content;
            return rs;
        }
    }
}
