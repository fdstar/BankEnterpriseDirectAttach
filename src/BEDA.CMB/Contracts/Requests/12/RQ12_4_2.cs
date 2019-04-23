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
    /// 12.4.2.支付机构确认汇入汇款属性请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ12_4_2 : CMBBase<RQINFO>, IRequest<RS12_4_2>
    {
        /// <summary>
        /// NTIRAOPR
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTIRAOPR";
        /// <summary>
        /// 12.4.2.支付机构确认汇入汇款属性请求内容
        /// </summary>
        public NTOPRMODX NTOPRMODX { get; set; }
        /// <summary>
        /// 12.4.2.支付机构确认汇入汇款属性请求集合
        /// </summary>
        [XmlElement("NTIRAOPRX")]
        public List<NTIRAOPRX> List { get; set; }
    }
    /// <summary>
    /// 12.4.2.支付机构确认汇入汇款属性请求内容
    /// </summary>
    public class NTIRAOPRX
    {
        /// <summary>
        /// 业务参考号 	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 分行号     	C(2)	附录A.1
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 客户号     	C(10)
        /// </summary>
        public string CLTNBR { get; set; }
        /// <summary>
        /// 汇入汇款编号	C(16)
        /// </summary>
        public string IRMNBR { get; set; }
        /// <summary>
        /// 汇入款性质 	C(1)	G:货物贸易 S:服务贸易 C:资本项目
        /// </summary>
        public string IRMTYP { get; set; }
        /// <summary>
        /// 交易编码   	C(6)    CFMFLG=Y时，必填 如果是支付机构的业务： 999999
        /// </summary>
        public string TRSCOD { get; set; }
        /// <summary>
        /// 同意标志   	C(1)	Y：同意入账 N：不同意，银行退回
        /// </summary>
        public string CFMFLG { get; set; }
        /// <summary>
        /// 保留字        	C(50)   第1位按如下定义输入： 1：支付机构跨境电商外汇集中收付 其他不是支付机构的业务
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
