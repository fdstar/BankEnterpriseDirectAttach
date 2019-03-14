using BEDA.Utils;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Responses
{
    /// <summary>
    /// 4.2.直接代发代扣响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS4_2 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// AgentRequest
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "AgentRequest";
        /// <summary>
        /// 4.2.直接代发代扣响应集合
        /// </summary>
        public NTREQNBRY NTREQNBRY { get; set; }
    }
    /// <summary>
    /// 4.2.直接代发代扣响应内容
    /// </summary>
    public class NTREQNBRY
    {
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 保留字段	C(50)
        /// 若输入接口SDKATSRQX字段 GRTFLG为“Y”, 则经办成功时本字段前3位返回:数据接收中“OPR”；
        /// 若输入接口SDKATSRQX字段 GRTFLG值非“Y”，则经办成功时本字段前3位返回:银行处理中“BNK”
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
