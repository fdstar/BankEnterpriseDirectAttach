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
    /// 6.1.查询订单状态信息响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS6_1 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// GetOrderStatus
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "GetOrderStatus";
        /// <summary>
        /// 6.1.查询订单状态信息响应集合
        /// </summary>
        [XmlElement("NTQTRDQYZ")]
        public List<NTQTRDQYZ> List { get; set; }
    }
    /// <summary>
    /// 6.1.查询订单状态信息响应内容
    /// </summary>
    public class NTQTRDQYZ
    {
        /// <summary>
        /// 订单币种代码	C(2)	附录A.3
        /// </summary>
        public string ORDCCYNBR { get; set; }
        /// <summary>
        /// 订单结账金额	M
        /// </summary>
        public decimal ORDENDAMT { get; set; }
        /// <summary>
        /// 对方订单号	C(40)
        /// </summary>
        public string ORDREFORD { get; set; }
        /// <summary>
        /// 对方订单支付号	C(10)
        /// </summary>
        public string ORDSUBORD { get; set; }
        /// <summary>
        /// 订单完成日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? ORDENDDAT { get; set; }
        /// <summary>
        /// 订单完成日期	D, 对应<see cref="ORDENDDAT"/>
        /// </summary>
        [XmlElement("ORDENDDAT")]
        public string ORDENDDATStr
        {
            get
            {
                return this.ORDENDDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.ORDENDDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ORDENDDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 订单请求状态	C(3)	
        /// MRV=多收方处理中 
        /// WCF=等待商户确认
        /// OPR = 企业银行缴费经办
        /// INP=待缴费
        /// CFM = 确认完毕
        /// FIN=订单处理完成
        /// </summary>
        public string ORDORDSTA { get; set; }
        /// <summary>
        /// 结果	C(1)	ORDORDSTA=FIN才有效
        /// S=订单支付成功 
        /// F=失败
        /// H = 订单过期作废
        /// INP=待缴费
        /// E = 企业（买方）撤销订单
        /// D = 商户（卖方）撤销订单
        /// B = 多收方支付不成功
        /// T=退款
        /// </summary>
        public string ORDSTSCOD { get; set; }
        /// <summary>
        /// 订单结果描述	Z(92)
        /// </summary>
        public string ORDERRDSP { get; set; }
        /// <summary>
        /// 订单成功支付流水号	C(10)
        /// </summary>
        public string ORDSUCSEQ { get; set; }
        /// <summary>
        /// 收方序号	C(5)    票据无值
        /// </summary>
        public string RCVNBR { get; set; }
        /// <summary>
        /// 收方帐户所在的分行号	C(2)
        /// </summary>
        public string RCVBBK { get; set; }
        /// <summary>
        /// 收方帐户	C(35)
        /// </summary>
        public string RCVACC { get; set; }
        /// <summary>
        /// 收方户名	Z(200)
        /// </summary>
        public string RCVNAM { get; set; }
        /// <summary>
        /// 收方行名称	Z(62)   票据无值
        /// </summary>
        public string RCVBNK { get; set; }
        /// <summary>
        /// 收方行地址	Z(62)   票据无值
        /// </summary>
        public string RCVADR { get; set; }
        /// <summary>
        /// 结算通路	C(1)	F：快速；N：普通   票据无值
        /// </summary>
        public string STLCHN { get; set; }
        /// <summary>
        /// 多收方中间节点帐户	C(1)	Y/N 票据无值
        /// </summary>
        public string KEYACC { get; set; }
        /// <summary>
        /// 币种代码	C(2)	附录A.3
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 金额	M
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 期望日	D
        /// </summary>
        [XmlIgnore]
        public DateTime? EPTDAT { get; set; }
        /// <summary>
        /// 期望日	D, 对应<see cref="EPTDAT"/>
        /// </summary>
        [XmlElement("EPTDAT")]
        public string EPTDATStr
        {
            get
            {
                return this.EPTDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.EPTDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EPTDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 结束日	D
        /// </summary>
        [XmlIgnore]
        public DateTime? ENDDAT { get; set; }
        /// <summary>
        /// 结束日	D, 对应<see cref="ENDDAT"/>
        /// </summary>
        [XmlElement("ENDDAT")]
        public string ENDDATStr
        {
            get
            {
                return this.ENDDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.ENDDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ENDDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 结果	C(1)	附录A.6   ORDORDSTA=FIN才有效
        /// </summary>
        public string STSCOD { get; set; }
        /// <summary>
        /// 结果描述	Z(92)
        /// </summary>
        public string ERRDSP { get; set; }
        /// <summary>
        /// 结算方式	C(1)	
        /// 1：现金支付
        /// 2：电票出票
        /// 3：电票背书
        /// </summary>
        public string STLTYP { get; set; }
        /// <summary>
        /// 人行票据号	C(30)
        /// </summary>
        public string BILBILNBR { get; set; }
        /// <summary>
        /// 查询账号	C(35)
        /// </summary>
        public string BILACCNBR { get; set; }
        /// <summary>
        /// 合同号	C(40)
        /// </summary>
        public string BILCTRNBR { get; set; }
        /// <summary>
        /// 合同描述	Z(402 )
        /// </summary>
        public string BILCTRDSP { get; set; }
    }
}
