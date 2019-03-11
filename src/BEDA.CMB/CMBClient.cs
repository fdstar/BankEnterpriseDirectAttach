using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEDA.CMB.Contracts;
using BEDA.CMB.Contracts.Requests;
using BEDA.CMB.Contracts.Responses;
using BEDA.Utils;
using RestSharp;

namespace BEDA.CMB
{
    /// <summary>
    /// 招商银行客户端
    /// </summary>
    public class CMBClient : Client, ICMBClient
    {
        /// <summary>
        /// 响应报文默认编码方式为GB18030，以解决GBK编码问题，如果赋值为null，则默认使用<see cref="RestClient.Encoding"/>
        /// </summary>
        public Encoding ResponseEncoding { get; set; }

        /// <summary>
        /// 招商银行调用构造,默认调用127.0.0.1:8080
        /// </summary>
        public CMBClient()
            : this("127.0.0.1", 8080)
        {
        }
        /// <summary>
        /// 招商银行调用构造
        /// </summary>
        /// <param name="host">ip地址或域名</param>
        /// <param name="port">端口号</param>
        /// <param name="scheme">请求协议，默认http</param>
        /// <param name="encoding">数据编码方式，默认gb2312</param>
        public CMBClient(string host, int port, string scheme = "http", string encoding = "GBK")
            : base(host, port, scheme, encoding)
        {
            this.ResponseEncoding = Encoding.GetEncoding("GB18030");
        }
        /// <summary>
        /// 发起业务请求 注意必定返回响应内容
        /// </summary>
        /// <typeparam name="TRq">业务请求类型</typeparam>
        /// <typeparam name="TRs">业务响应类型</typeparam>
        /// <param name="request">请求主体</param>
        /// <param name="loginName">要使用的账户名，如果传递，则将覆盖<see cref="RQINFO.LGNNAM"/></param>
        /// <returns></returns>
        public TRs Execute<TRq, TRs>(TRq request, string loginName = null)
            where TRq : CMBBase<RQINFO>, IRequest<TRs>
            where TRs : CMBBase<RSINFO>, IResponse, new()
        {
            var restRequest = this.GetRestRequest(request, loginName);
            var restResponse = this.RestClient.Execute(restRequest);
            return this.GetResponse<TRs>(restResponse);
        }
        /// <summary>
        /// 发起业务请求 注意必定返回响应内容
        /// </summary>
        /// <typeparam name="TRq">业务请求类型</typeparam>
        /// <typeparam name="TRs">业务响应类型</typeparam>
        /// <param name="request">请求主体</param>
        /// <param name="loginName">要使用的账户名，如果传递，则将覆盖<see cref="RQINFO.LGNNAM"/></param>
        /// <returns></returns>
        public async Task<TRs> ExecuteAsync<TRq, TRs>(TRq request, string loginName = null)
            where TRq : CMBBase<RQINFO>, IRequest<TRs>
            where TRs : CMBBase<RSINFO>, IResponse, new()
        {
            var restRequest = this.GetRestRequest(request, loginName);
            var restResponse = await this.RestClient.ExecuteTaskAsync(restRequest).ConfigureAwait(false);
            return this.GetResponse<TRs>(restResponse);
        }
        private IRestRequest GetRestRequest<TRq>(TRq request, string loginName)
             where TRq : CMBBase<RQINFO>
        {
            if (request.INFO == null)
            {
                request.INFO = new RQINFO();
            }
            request.INFO.FUNNAM = request.GetFUNNAM();
            if (!string.IsNullOrWhiteSpace(loginName))
            {
                request.INFO.LGNNAM = loginName;
            }
            var xml = XmlHelper.Serializer(request, encoding: this.RestClient.Encoding, showDeclaration: true, removeDefaultNameSpace: true);
            request.INFO.RequestContent = xml;
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
        private TRs GetResponse<TRs>(IRestResponse response)
            where TRs : CMBBase<RSINFO>, IResponse, new()
        {
            response.SetResponseEncoding(this.ResponseEncoding ?? this.RestClient.Encoding);
            var rs = XmlHelper.Deserialize<TRs>(response.Content);
            if (rs == null)
            {
                rs = new TRs();
                rs.INFO = new RSINFO();
            }
            rs.INFO.ResponseContent = response.Content;
            return rs;
        }
    }
}
