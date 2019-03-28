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
    /// 7.9.查询委托贷款业务响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS7_9 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// QueryALoan
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "QueryALoan";
        /// <summary>
        /// 7.9.查询委托贷款业务响应集合
        /// </summary>
        [XmlElement("NTQRYALNZ")]
        public List<NTQRYALNZ> List { get; set; }
    }
    /// <summary>
    /// 7.9.查询委托贷款业务响应内容
    /// </summary>
    public class NTQRYALNZ
    {
        /// <summary>
        /// 业务类型	C(6)
        /// </summary>
        public string BUSCOD { get; set; }
        /// <summary>
        /// 业务模式	C(5)
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 贷款业务号	C(10)
        /// </summary>
        public string BUSNUM { get; set; }
        /// <summary>
        /// 操作类型	C(3)	‘LND’：贷款；‘PYO’：还款
        /// </summary>
        public string SLNOPR { get; set; }
        /// <summary>
        /// 委托方分行号	C(2,2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 委托方账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 委托方名称	Z(62)
        /// </summary>
        public string LNRNAM { get; set; }
        /// <summary>
        /// 借款方分行号	C(2,2)
        /// </summary>
        public string BWRBBK { get; set; }
        /// <summary>
        /// 借款方账号	C(35)
        /// </summary>
        public string BWRACC { get; set; }
        /// <summary>
        /// 借款方名称	Z(62)
        /// </summary>
        public string BWRNAM { get; set; }
        /// <summary>
        /// 放款日	D
        /// </summary>
        [XmlIgnore]
        public DateTime LONDAT { get; set; }
        /// <summary>
        /// 放款日	D, 对应<see cref="LONDAT"/>
        /// </summary>
        [XmlElement("LONDAT")]
        public string LONDATStr
        {
            get
            {
                return this.LONDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.LONDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 到期日	D
        /// </summary>
        [XmlIgnore]
        public DateTime EXPDAT { get; set; }
        /// <summary>
        /// 到期日	D, 对应<see cref="EXPDAT"/>
        /// </summary>
        [XmlElement("EXPDAT")]
        public string EXPDATStr
        {
            get
            {
                return this.EXPDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EXPDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 币种	C(2,2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 放款金额	M
        /// </summary>
        public decimal LONAMT { get; set; }
        /// <summary>
        /// 利率	I
        /// </summary>
        public decimal INTRAT { get; set; }
        /// <summary>
        /// 贷款用途	C(5)	A.12 贷款用途
        /// </summary>
        public string LONUSG { get; set; }
        /// <summary>
        /// 经办日	D
        /// </summary>
        [XmlIgnore]
        public DateTime OPRDAT { get; set; }
        /// <summary>
        /// 经办日	D, 对应<see cref="OPRDAT"/>
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
        /// 对方参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 还款日	D
        /// </summary>
        [XmlIgnore]
        public DateTime PYODAT { get; set; }
        /// <summary>
        /// 还款日	D, 对应<see cref="PYODAT"/>
        /// </summary>
        [XmlElement("PYODAT")]
        public string PYODATStr
        {
            get
            {
                return this.PYODAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.PYODAT = tmp;
                }
            }
        }
        /// <summary>
        /// 余额	M   还款
        /// </summary>
        public decimal BLVAMT { get; set; }
        /// <summary>
        /// 占用天数	N(3,0)  还款
        /// </summary>
        public int? OCRDAY { get; set; }
        /// <summary>
        /// 利息	M   还款
        /// </summary>
        public decimal? INTAMT { get; set; }
        /// <summary>
        /// 业务请求状态	C(3,3)	A.5 业务请求状态
        /// </summary>
        public string REQSTA { get; set; }
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
        /// 用户名	Z(30)
        /// </summary>
        public string LGNNAM { get; set; }
        /// <summary>
        /// 用户姓名	Z(20)
        /// </summary>
        public string USRNAM { get; set; }
        /// <summary>
        /// 业务请求结果	C(1)	A.6 业务处理结果
        /// </summary>
        public string RTNFLG { get; set; }
        /// <summary>
        /// 结果摘要	Z(92)   如失败原因、退票原因
        /// </summary>
        public string RTNNAR { get; set; }
    }
}
