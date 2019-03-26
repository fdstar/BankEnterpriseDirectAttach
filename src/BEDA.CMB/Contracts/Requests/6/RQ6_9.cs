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
    /// 6.9.批量支付数据确认经办/撤销请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ6_9 : CMBBase<RQINFO>, IRequest<RS6_9>
    {
        /// <summary>
        /// NTGRTBTH
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTGRTBTH";
        /// <summary>
        /// 6.9.批量支付数据确认经办/撤销请求内容
        /// 可通过ListMode接口查询（业务代码N02032），或在前置机上查看
        /// </summary>
        public NTBUSMODY NTBUSMODY { get; set; }
        /// <summary>
        /// 6.9.批量支付数据确认经办/撤销请求内容
        /// </summary>
        public NTGRTBTHX NTGRTBTHX { get; set; }
    }
    /// <summary>
    /// 6.9.批量支付数据确认经办/撤销请求内容
    /// </summary>
    public class NTGRTBTHX
    {
        /// <summary>
        /// 商户编号   	C(10)
        /// </summary>
        public string MCHNBR { get; set; }
        /// <summary>
        /// 订单号	C(40)
        /// </summary>
        public string REFORD { get; set; }
        /// <summary>
        /// 订单支付号	C(10)   生成订单的时候如果有订单支付号则必填
        /// </summary>
        public string SUBORD { get; set; }
        /// <summary>
        /// 结算通道 	C(1) 	F：快速 N：普通   确认支付时必输。只对跨行交易有效
        /// </summary>
        public string STLCHN { get; set; }
        /// <summary>
        /// 用途     	Z(62)   若使用NTQRYBTH查询未返回用途，则该字段必输
        /// </summary>
        public string NUSAGE { get; set; }
        /// <summary>
        /// 对方参考号	C(30)   确认支付时必输；建议使用NTQRYBTH查询返回RCVNBR接收流程
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 业务摘要 	Z(200)
        /// </summary>
        public string BUSNAR { get; set; }
        /// <summary>
        /// 通知方式一	C(40)
        /// </summary>
        public string NTFCH1 { get; set; }
        /// <summary>
        /// 通知方式二	C(20)
        /// </summary>
        public string NTFCH2 { get; set; }
        /// <summary>
        /// 业务种类	C(6) 	100001：普通汇兑 101001：慈善捐款 101002：其他
        /// 确认支付时为空则默认为100001普通汇兑
        /// </summary>
        public string TRSTYP { get; set; }
        /// <summary>
        /// 确认标志	C(1)	Y：确认 N：撤销
        /// </summary>
        public string GRTFLG { get; set; }
        /// <summary>
        /// 审批意见	Z(62)
        /// </summary>
        public string GRTDSP { get; set; }
        /// <summary>
        /// 转出分行号	C(2)	附录A.1   确认时必输
        /// </summary>
        public string DBTBBK { get; set; }
        /// <summary>
        /// 转出帐号  	C(35)   确认时必输
        /// </summary>
        public string DBTACC { get; set; }
        /// <summary>
        /// 期望日	D   未填入则默认为当前日期
        /// </summary>
        [XmlIgnore]
        public DateTime? ExpectedTime { get; set; }
        /// <summary>
        /// 期望日	D
        /// </summary>
        [XmlElement("EPTDAT")]
        public string EPTDATStr
        {
            get
            {
                return this.ExpectedTime?.ToString("yyyyMMdd");
            }
            set { }
        }
        /// <summary>
        /// 期望时间	T
        /// </summary>
        [XmlElement("EPTTIM")]
        public string EPTTIMStr
        {
            get
            {
                return this.ExpectedTime?.ToString("HHmmss");
            }
            set { }
        }
        /// <summary>
        /// 保留字段	C(50)
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
