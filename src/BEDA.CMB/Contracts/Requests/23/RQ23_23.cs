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
    /// 22.23.取公司结算户下面所有公司卡信息(续传)请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ23_23 : CMBBase<RQINFO>, IRequest<RS23_23>
    {
        /// <summary>
        /// NTCPRLSC
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCPRLSC";
        /// <summary>
        /// 22.23.取公司结算户下面所有公司卡信息(续传)请求内容
        /// </summary>
        public NTCPRLSCX1 NTCPRLSCX1 { get; set; }
    }
    /// <summary>
    /// 22.23.取公司结算户下面所有公司卡信息(续传)请求内容
    /// </summary>
    public class NTCPRLSCX1
    {
        /// <summary>
        /// 分行号     	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 公司结算户 	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 上次查询最后卡号	C(20)   初始查询时为空；断点续传时以上一次查询返回的最后公司卡卡号填入查询
        /// </summary>
        public string PSBNBR { get; set; }
    }
}
