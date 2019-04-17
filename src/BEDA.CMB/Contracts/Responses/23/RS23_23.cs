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
    /// 22.23.取公司结算户下面所有公司卡信息(续传)响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS23_23 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTCPRLSC
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCPRLSC";
        /// <summary>
        /// 22.23.取公司结算户下面所有公司卡信息(续传)响应集合
        /// </summary>
        [XmlElement("NTCPRLSTZ")]
        public List<NTCPRLSTZ> List { get; set; }
        /// <summary>
        /// 22.23.取公司结算户下面所有公司卡信息(续传)响应内容 续传标志
        /// </summary>
        public NTCPRLSCZ1 NTCPRLSCZ1 { get; set; }
    }
    /// <summary>
    /// 22.23.取公司结算户下面所有公司卡信息(续传)响应内容 续传标志
    /// </summary>
    public class NTCPRLSCZ1
    {
        /// <summary>
        /// 续传标志	C(1)    Y:有续传，后续还有卡号数据，表示尚未传送完毕 N：无续传，表示已传送完毕
        /// </summary>
        public string CTNFLG { get; set; }
        /// <summary>
        /// 最后卡号	C(20)   本次查询返回的最后一个公司卡卡号
        /// </summary>
        public string PSBNBR { get; set; }
    }
}
