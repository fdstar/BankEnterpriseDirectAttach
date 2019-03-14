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
    /// 3.5.查询批量支付经办结果请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ3_5 : CMBBase<RQINFO>, IRequest<RS3_5>
    {
        /// <summary>
        /// GetBatchPayOprRes
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "GetBatchPayOprRes";
        /// <summary>
        /// 3.5.查询批量支付经办结果请求内容
        /// </summary>
        public SDQPYRSTX SDQPYRSTX { get; set; }
    }
    /// <summary>
    /// 3.5.查询批量支付经办结果请求内容
    /// </summary>
    public class SDQPYRSTX
    {
        /// <summary>
        /// 处理结果批号	C(10)   由取新的通知或查询历史通知获取
        /// </summary>
        public string RSTSET { get; set; }
        /// <summary>
        /// 保留字	C(50)
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
