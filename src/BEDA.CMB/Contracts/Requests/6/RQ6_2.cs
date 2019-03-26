using BEDA.CMB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Requests
{
    /// <summary>
    /// 6.2.验证签名请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ6_2 : CMBBase<RQINFO>, IRequest<RS6_2>
    {
        /// <summary>
        /// VerifySignature
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "VerifySignature";
        /// <summary>
        /// 6.2.验证签名请求内容
        /// </summary>
        public SDKTRDVSX SDKTRDVSX { get; set; }
    }
    /// <summary>
    /// 6.2.验证签名请求内容
    /// </summary>
    public class SDKTRDVSX
    {
        /// <summary>
        /// 要验证签名的原文 原文如果是XML报文，则需要对特殊字符进行替换
        /// </summary>
        public string SRCDAT { get; set; }
        /// <summary>
        /// 公钥  为空时直接使用银行的公钥
        /// </summary>
        public string VERKEY { get; set; }
        /// <summary>
        /// 签名后的内容
        /// </summary>
        public string SIGDTA { get; set; }
    }
}
