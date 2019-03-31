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
    /// 11.4.查询代理清算批量经办处理结果请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ11_4 : CMBBase<RQINFO>, IRequest<RS11_4>
    {
        /// <summary>
        /// NTQAPRST
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQAPRST";
        /// <summary>
        /// 11.4.查询代理清算批量经办处理结果请求内容
        /// </summary>
        public NTQPYRSTX NTQPYRSTX { get; set; }
    }
    /// <summary>
    /// 11.4.查询代理清算批量经办处理结果请求内容
    /// </summary>
    public class NTQPYRSTX
    {
        /// <summary>
        /// 处理结果批号	C(10)   由取新的通知或查询历史通知获取
        /// </summary>
        public string RSTSET { get; set; }
    }
}
