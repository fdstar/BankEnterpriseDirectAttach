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
    /// 12.1.2.支付机构上传结售汇申请项下结汇明细数据响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS12_1_2 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTBEXDTL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTBEXDTL";
        /// <summary>
        /// 12.1.2.支付机构上传结售汇申请项下结汇明细数据响应集合
        /// </summary>
        [XmlElement("NTPAYMSGZ1")]
        public List<NTPAYMSGZ1> List { get; set; }
    }
    /// <summary>
    /// 12.1.2.支付机构上传结售汇申请项下结汇明细数据响应内容
    /// </summary>
    public class NTPAYMSGZ1
    {
        /// <summary>
        /// 客户业务参考号	C(30)
        /// </summary>
        public string FATREF { get; set; }
        /// <summary>
        /// 轮次序号	C(6)
        /// </summary>
        public int LODSEQ { get; set; }
        /// <summary>
        /// 交易唯一序号	C(22)
        /// </summary>
        public string EVTSEQ { get; set; }
        /// <summary>
        /// 错误码	C(7)
        /// </summary>
        public string MSGCOD { get; set; }
        /// <summary>
        /// 错误信息	C(192)
        /// </summary>
        public string MSGTXT { get; set; }
        /// <summary>
        /// 保留字30	C(30)
        /// </summary>
        public string RSV30Z { get; set; }
    }
}
