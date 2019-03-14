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
    /// 3.3.支付结果列表查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS3_3 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTQRYSTN
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQRYSTN";
        /// <summary>
        /// 3.3.支付结果列表查询响应集合
        /// </summary>
        [XmlElement("NTSTLLSTZ")]
        public List<NTSTLLSTZ> List { get; set; }
    }
    /// <summary>
    /// 3.3.支付结果列表查询响应内容
    /// </summary>
    public class NTSTLLSTZ
    {
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 业务编码  	C(6) 	附录A.4
        /// </summary>
        public string BUSCOD { get; set; }
        /// <summary>
        /// 业务模式  	C(5) 
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 转出分行号	C(2) 	附录A.1
        /// </summary>
        public string DBTBBK { get; set; }
        /// <summary>
        /// 付方帐号  	C(35)
        /// </summary>
        public string DBTACC { get; set; }
        /// <summary>
        /// 收方分行号	C(2) 	附录A.1
        /// </summary>
        public string CRTBBK { get; set; }
        /// <summary>
        /// 收方帐号  	C(35)
        /// </summary>
        public string CRTACC { get; set; }
        /// <summary>
        /// 收方名称  	Z(200)
        /// </summary>
        public string CRTNAM { get; set; }
        /// <summary>
        /// 币种      	C(2) 	附录A.3
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 交易金额  	M
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 期望日        	D
        /// </summary>
        public string EPTDAT { get; set; }
        /// <summary>
        /// 期望时间      	T
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
        /// 经办日        	D
        /// </summary>
        [XmlIgnore]
        public DateTime? OPRDAT { get; set; }
        /// <summary>
        /// 经办日        	D, 对应<see cref="OPRDAT"/>
        /// </summary>
        [XmlElement("OPRDAT")]
        public string OPRDATStr
        {
            get
            {
                return this.OPRDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.OPRDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OPRDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 对方参考号    	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 请求状态      	C(3)	附录A.5
        /// </summary>
        public string REQSTS { get; set; }
        /// <summary>
        /// 业务处理结果  	C(1)	附录 A.6
        /// </summary>
        public string RTNFLG { get; set; }
        /// <summary>
        /// 是否有附件信息	C(1)
        /// </summary>
        public string ATHFLG { get; set; }
        /// <summary>
        /// 保留字 30     	C(30)
        /// </summary>
        public string RSV30Z { get; set; }
    }
}
