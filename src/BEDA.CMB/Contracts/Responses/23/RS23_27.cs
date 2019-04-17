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
    /// 23.27.公司卡入金锁定状态查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS23_27 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTQRYLCK
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQRYLCK";
        /// <summary>
        /// 23.27.公司卡入金锁定状态查询响应内容
        /// </summary>
        public NTQRYLCKZ1 NTQRYLCKZ1 { get; set; }
    }
    /// <summary>
    /// 23.27.公司卡入金锁定状态查询响应内容
    /// </summary>
    public class NTQRYLCKZ1
    {
        /// <summary>
        /// 公司卡卡号	C(20)
        /// </summary>
        public string PSBNBR { get; set; }
        /// <summary>
        /// 是否存在中止	C(1)    Y：存在有效该类型中止 N：不存在有效该类型中止
        /// </summary>
        public string LCKFLG { get; set; }
        /// <summary>
        /// 特殊码 30	C(30) 
        /// </summary>
        public string RSV30Z { get; set; }
    }
}
