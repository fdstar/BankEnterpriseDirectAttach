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
    /// 6.8.批量支付数据列表查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS6_8 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTQRYBTH
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQRYBTH";
        /// <summary>
        /// 6.8.批量支付数据列表查询响应集合
        /// </summary>
        [XmlElement("NTQRYBTHZ")]
        public List<NTQRYBTHZ> List { get; set; }
    }
    /// <summary>
    /// 6.8.批量支付数据列表查询响应内容
    /// </summary>
    public class NTQRYBTHZ
    {
        /// <summary>
        /// 订单接收流水	C(10)
        /// </summary>
        public string RCVNBR { get; set; }
        /// <summary>
        /// 商户编号	C(10)
        /// </summary>
        public string MCHNBR { get; set; }
        /// <summary>
        /// 商户名称	Z(62)
        /// </summary>
        public string MCHNAM { get; set; }
        /// <summary>
        /// 币种	C(2)	附录A.3
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 交易金额	M
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 订单提交日	D
        /// </summary>
        [XmlIgnore]
        public DateTime RCVDAT { get; set; }
        /// <summary>
        /// 订单提交日	D, 对应<see cref="RCVDAT"/>
        /// </summary>
        [XmlElement("RCVDAT")]
        public string RCVDATStr
        {
            get
            {
                return this.RCVDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.RCVDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 订单失效日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime CNLDAT { get; set; }
        /// <summary>
        /// 订单失效日期	D, 对应<see cref="CNLDAT"/>
        /// </summary>
        [XmlElement("CNLDAT")]
        public string CNLDATStr
        {
            get
            {
                return this.CNLDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.CNLDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 订单号	C(40)
        /// </summary>
        public string REFORD { get; set; }
        /// <summary>
        /// 订单支付号	C(10)
        /// </summary>
        public string SUBORD { get; set; }
        /// <summary>
        /// 收方帐号	C(35)	
        /// </summary>
        public string CRTACC { get; set; }
        /// <summary>
        /// 收方户名	Z(200)
        /// </summary>
        public string CRTNAM { get; set; }
        /// <summary>
        /// 收方行名称	Z(62)
        /// </summary>
        public string CRTBNK { get; set; }
        /// <summary>
        /// 收方行地址	Z(62)
        /// </summary>
        public string CRTADR { get; set; }
        /// <summary>
        /// 请求状态	C(3) 	OPR：接收成功 FIN：提交成功
        /// </summary>
        public string REQSTA { get; set; }
        /// <summary>
        /// 通知方式一	C(40)
        /// </summary>
        public string NTFCH1 { get; set; }
        /// <summary>
        /// 通知方式二	C(20)
        /// </summary>
        public string NTFCH2 { get; set; }
        /// <summary>
        /// 用途	Z(62)
        /// </summary>
        public string NUSAGE { get; set; }
        /// <summary>
        /// 业务摘要	Z(200)
        /// </summary>
        public string BUSNAR { get; set; }
        /// <summary>
        /// 保留字段	C(30)
        /// </summary>
        public string RSV30Z { get; set; }
    }
}
