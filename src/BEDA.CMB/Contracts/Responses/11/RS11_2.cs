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
    /// 11.2.查询所有代理清算申请响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS11_2 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTAGPLST
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTAGPLST";
        /// <summary>
        /// 11.2.查询所有代理清算申请响应集合
        /// </summary>
        [XmlElement("NTAGPLSTZ1")]
        public List<NTAGPLSTZ1> List { get; set; }
    }
    /// <summary>
    /// 11.2.查询所有代理清算申请响应内容
    /// </summary>
    public class NTAGPLSTZ1
    {
        /// <summary>
        /// 流程实例号	C(10)	
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 业务类型	C(6)
        /// </summary>
        public string BUSCOD { get; set; }
        /// <summary>
        /// 业务模式	C(5)
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 汇款人账号	C(35)
        /// </summary>
        public string RMTACC { get; set; }
        /// <summary>
        /// 转出分行号	C(2)
        /// </summary>
        public string DBTBBK { get; set; }
        /// <summary>
        /// 转出帐号	C(35)
        /// </summary>
        public string DBTACC { get; set; }
        /// <summary>
        /// 币种	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 交易金额	M
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 收方分行号	C(2)
        /// </summary>
        public string CRTBBK { get; set; }
        /// <summary>
        /// 收方帐号	C(35)
        /// </summary>
        public string CRTACC { get; set; }
        /// <summary>
        /// 收方户名	Z(62)	
        /// </summary>
        public string CRTNAM { get; set; }
        /// <summary>
        /// 请求状态	C(3)    A.5 业务请求状态
        /// </summary>
        public string REQSTS { get; set; }
        /// <summary>
        /// 业务处理结果	C(1)	A.6 业务处理结果
        /// </summary>
        public string RTNFLG { get; set; }
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
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 是否有附件	C(1)    Y：有 N：无
        /// </summary>
        public string ATHFLG { get; set; }
    }
}
