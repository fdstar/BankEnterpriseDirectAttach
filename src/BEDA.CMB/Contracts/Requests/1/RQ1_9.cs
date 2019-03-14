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
    /// 1.9.查询历史通知（新）
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ1_9 : CMBBase<RQINFO>, IRequest<RS1_9>
    {
        /// <summary>
        /// GetHisNoticeEX
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "GetHisNoticeEX";
        /// <summary>
        /// 1.9.查询历史通知（新）请求内容
        /// </summary>
        public DCHISMSGX DCHISMSGX { get; set; }
    }
    /// <summary>
    /// 1.9.查询历史通知（新）请求内容
    /// </summary>
    public class DCHISMSGX : FBDLRHMGX
    {
        /// <summary>
        /// 上次最大通知序号	C(18) 支持断点续传用
        /// </summary>
        public string LSTNBR { get; set; }
        /// <summary>
        /// 返回结果集上限	C (4) 为空或无效值时则取缺省值1000, 有效范围100-2000
        /// </summary>
        public string RECNUM { get; set; }
    }
}
