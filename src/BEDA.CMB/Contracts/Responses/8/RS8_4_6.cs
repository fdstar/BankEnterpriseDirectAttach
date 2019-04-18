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
    /// 8.4.6.业务明细查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_4_6 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTFNCDTL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTFNCDTL";
        /// <summary>
        /// 8.4.6.业务明细查询响应内容
        /// </summary>
        public NTDTLFNCZ NTDTLFNCZ { get; set; }
        /// <summary>
        /// 8.4.6.业务明细查询响应集合
        /// </summary>
        [XmlElement("NTDTLFNCZ1")]
        public List<NTDTLFNCZ1> List { get; set; }
    }
    /// <summary>
    /// 8.4.6.业务明细查询响应内容
    /// </summary>
    public class NTDTLFNCZ
    {
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 操作类型	C(3)
        /// </summary>
        public string OPRTYP { get; set; }
        /// <summary>
        /// 活期账号分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 活期账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 账号名称	Z(62)
        /// </summary>
        public string ACCNAM { get; set; }
        /// <summary>
        /// 公司名称	Z(62)
        /// </summary>
        public string CLTNAM { get; set; }
        /// <summary>
        /// 定期账号的分行号	C(2)
        /// </summary>
        public string FIXBBK { get; set; }
        /// <summary>
        /// 定期账号	C(35)
        /// </summary>
        public string FIXACC { get; set; }
        /// <summary>
        /// 币种	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 通知存款类型	C(2)	01: 1 天通知存款 07: 7 天通知存款
        /// </summary>
        public string INFTYP { get; set; }
        /// <summary>
        /// 开户行	Z(62)
        /// </summary>
        public string BRNNAM { get; set; }
        /// <summary>
        /// 存期	N(3,0)
        /// 006: 半年
        /// 003: 三个月
        /// 024: 两年
        /// 012: 一年
        /// </summary>
        public string TERDUM { get; set; }
        /// <summary>
        /// 离岸存期	N(6,0)	A.9离岸存期代码
        /// </summary>
        public string TERDUR { get; set; }
        /// <summary>
        /// 到期处理方式	C(1)
        /// 1：不转存；
        /// 2：本息转存；
        /// 3：本金转存，利息转活期
        /// </summary>
        public string ATOFLG { get; set; }
        /// <summary>
        /// 起息日	D
        /// </summary>
        [XmlIgnore]
        public DateTime INTDAT { get; set; }
        /// <summary>
        /// 起息日	D, 对应<see cref="INTDAT"/>
        /// </summary>
        [XmlElement("INTDAT")]
        public string INTDATStr
        {
            get
            {
                return this.INTDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.INTDAT = tmp;
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
        /// 利率	I
        /// </summary>
        public decimal INTRAT { get; set; }
        /// <summary>
        /// 利息金额	M
        /// </summary>
        public decimal INTAMT { get; set; }
        /// <summary>
        /// 交易金额	M
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 请求状态	C(3)
        /// </summary>
        public string REQSTA { get; set; }
        /// <summary>
        /// 业务处理结果	C(1)
        /// </summary>
        public string RTNFLG { get; set; }
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
        /// 保留字段	C(30)
        /// </summary>
        public string RSV30Z { get; set; }
    }
    /// <summary>
    /// 8.4.6.业务明细查询响应内容
    /// </summary>
    public class NTDTLFNCZ1
    {
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 任务编码	C(8)	附录A.46
        /// </summary>
        public string TSKCOD { get; set; }
        /// <summary>
        /// 支取日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime TRSDAT { get; set; }
        /// <summary>
        /// 支取日期	D, 对应<see cref="TRSDAT"/>
        /// </summary>
        [XmlElement("TRSDAT")]
        public string TRSDATStr
        {
            get
            {
                return this.TRSDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.TRSDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 交易金额	M
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 利率	I
        /// </summary>
        public decimal INTRAT { get; set; }
        /// <summary>
        /// 利息金额	M
        /// </summary>
        public decimal INTAMT { get; set; }
        /// <summary>
        /// 利息税金额	M
        /// </summary>
        public decimal TAXAMT { get; set; }
        /// <summary>
        /// 保留字段	C(30)
        /// </summary>
        public string RSV30Z { get; set; }
    }
}
