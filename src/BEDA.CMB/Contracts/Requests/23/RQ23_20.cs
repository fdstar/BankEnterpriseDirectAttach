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
    /// 23.20.自定义业务信息设置请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ23_20 : CMBBase<RQINFO>, IRequest<RS23_20>
    {
        /// <summary>
        /// NTCPRMNT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCPRMNT";
        /// <summary>
        /// 23.20.自定义业务信息设置请求内容
        /// </summary>
        public NTCPRMNTX1 NTCPRMNTX1 { get; set; }
    }
    /// <summary>
    /// 23.20.自定义业务信息设置请求内容
    /// </summary>
    public class NTCPRMNTX1
    {
        /// <summary>
        /// 业务模式   	C(5)
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 分行号     	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 公司结算户 	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 公司卡卡号 	C(20)
        /// </summary>
        public string PSBNBR { get; set; }
        /// <summary>
        /// 业务参考号 	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 卡备注     	Z(62)
        /// </summary>
        public string REMARK { get; set; }
        /// <summary>
        /// 资金用途编码	C(4)	A.52 资金用途编码
        /// </summary>
        public string FNDUSC { get; set; }
        /// <summary>
        /// 相对营收日期	C(2)
        /// 00：交易日当天
        /// 01：交易日前一天
        /// 02：交易日前两天
        /// 03：交易日前三天
        /// 04：交易日前四天
        /// 05：交易日前五天
        /// 06：交易日前六天
        /// 07：交易日前七天
        /// </summary>
        public string REVDAT { get; set; }
    }
}
