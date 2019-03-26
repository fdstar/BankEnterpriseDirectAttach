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
    /// 6.10.订单列表查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS6_10 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTQRYORD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQRYORD";
        /// <summary>
        /// 6.10.订单列表查询响应集合
        /// </summary>
        [XmlElement("NTORDINQZ")]
        public List<NTORDINQZ> List { get; set; }
    }
    /// <summary>
    /// 6.10.订单列表查询响应内容
    /// </summary>
    public class NTORDINQZ
    {
        /// <summary>
        /// 流程事例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 业务类型	C(6)	附录A.4
        /// </summary>
        public string BUSCOD { get; set; }
        /// <summary>
        /// 业务模式	C(5)
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 经办日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime OPRDAT { get; set; }
        /// <summary>
        /// 经办日期	D, 对应<see cref="OPRDAT"/>
        /// </summary>
        [XmlElement("OPRDAT")]
        public string OPRDATStr
        {
            get
            {
                return this.OPRDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OPRDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 期望日期	D
        /// </summary>
        public string EPTDAT { get; set; }
        /// <summary>
        /// 期望时间	T
        /// </summary>
        public string EPTTIM { get; set; }
        /// <summary>
        /// 期望时间 由<see cref="EPTDAT"/>和<see cref="EPTTIM"/>组成
        /// </summary>
        [XmlIgnore]
        public DateTime? ExpectedTime
        {
            get
            {
                if (DateTime.TryParseExact(string.Format("{0}{1}", this.EPTDAT, this.EPTTIM),
                   new string[] { "yyyyMMdd", "yyyyMMddHHmmss" }, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    return tmp;
                }
                return null;
            }
        }
        /// <summary>
        /// 业务请求状态	C(3)	附录A.5
        /// </summary>
        public string REQSTA { get; set; }
        /// <summary>
        /// 业务请求结果	C(1)	附录 A.6
        /// </summary>
        public string RTNFLG { get; set; }
        /// <summary>
        /// 待处理操作步骤	C(6)
        /// </summary>
        public string OPRSTP { get; set; }
        /// <summary>
        /// 待处理操作序列	C(3)
        /// </summary>
        public string OPRSQN { get; set; }
        /// <summary>
        /// 操作别名	Z(32)
        /// </summary>
        public string OPRALS { get; set; }
        /// <summary>
        /// 商户号	C(10)
        /// </summary>
        public string MCHNBR { get; set; }
        /// <summary>
        /// 商户名称	Z(62)
        /// </summary>
        public string MCHNAM { get; set; }
        /// <summary>
        /// 订单号	C(10)
        /// </summary>
        public string SEQNBR { get; set; }
        /// <summary>
        /// 订单支付	C(10)
        /// </summary>
        public string SUBSEQ { get; set; }
        /// <summary>
        /// 币种	C(2)	附录A.3
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 订单金额	M
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 结帐金额	M
        /// </summary>
        public decimal ENDAMT { get; set; }
        /// <summary>
        /// 付款分行	C(2)	附录A.1
        /// </summary>
        public string PAYBBK { get; set; }
        /// <summary>
        /// 付款帐号	C(35)
        /// </summary>
        public string PAYACC { get; set; }
        /// <summary>
        /// 收方分行号	C (2) 	附录A.1
        /// </summary>
        public string CRTBBK { get; set; }
        /// <summary>
        /// 收方帐号	C(35)
        /// </summary>
        public string CRTACC { get; set; }
        /// <summary>
        /// 收方户名	Z(200)
        /// </summary>
        public string CRTNAM { get; set; }
        /// <summary>
        /// 订单种类	C(1) 	
        /// 1 水电费
        /// 2 税务缴费
        /// 3 网站购物
        /// 4 电话费
        /// 5 行政事业收费 
        /// 6 其他
        /// </summary>
        public string ORDTYP { get; set; }
        /// <summary>
        /// 对方商户号	C(10)
        /// </summary>
        public string REFMCH { get; set; }
        /// <summary>
        /// 对方订单号	C(40)
        /// </summary>
        public string REFORD { get; set; }
        /// <summary>
        /// 对方订单支付号	C(10)
        /// </summary>
        public string SUBORD { get; set; }
        /// <summary>
        /// 订单附件	C(1)    保留
        /// </summary>
        public string ORDATH { get; set; }
        /// <summary>
        /// 经办附件	C(1) 	Y 有附件 N 没有附件
        /// </summary>
        public string ATHFLG { get; set; }
        /// <summary>
        /// 产生渠道	C(3) 	
        /// CLT 客户端
        /// DRT 中间业务平台
        /// NCB 客服中心
        /// WEB 商务网站
        /// </summary>
        public string ORDCHN { get; set; }
        /// <summary>
        /// 支付渠道	C(3)	
        /// CLT 客户端
        /// DRT 中间业务平台
        /// NCB 客服中心
        /// WEB 商务网站
        /// </summary>
        public string PAYCHN { get; set; }
        /// <summary>
        /// 对方参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 状态	C(1)	A:正常    保留
        /// </summary>
        public string STSCOD { get; set; }
        /// <summary>
        /// 支付方式	C(30)	A:单笔直接支付 B:批量支付
        /// </summary>
        public string RSV30Z { get; set; }
    }
}
