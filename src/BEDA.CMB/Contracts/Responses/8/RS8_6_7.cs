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
    /// 8.6.7.组合存款协议明细查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_6_7 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTCMAINF
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCMAINF";
        /// <summary>
        /// 8.6.7.组合存款协议明细查询响应内容
        /// </summary>
        public NTCMAINFZ1 NTCMAINFZ1 { get; set; }
        /// <summary>
        /// 8.6.7.组合存款协议明细查询响应集合
        /// </summary>
        [XmlElement("NTCMAINFZ2")]
        public List<NTCMAINFZ2> List { get; set; }
    }
    /// <summary>
    /// 8.6.7.组合存款协议明细查询响应内容
    /// </summary>
    public class NTCMAINFZ1
    {
        /// <summary>
        /// 协议号	C(8)
        /// </summary>
        public string PRDNBR { get; set; }
        /// <summary>
        /// 平台编号	C(10)
        /// </summary>
        public string PLTNBR { get; set; }
        /// <summary>
        /// 分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 活期帐号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 币种	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 留存金额	M
        /// </summary>
        public decimal RSVMIN { get; set; }
        /// <summary>
        /// 起存金额	M
        /// </summary>
        public decimal OPNMIN { get; set; }
        /// <summary>
        /// 最低支取金额	M
        /// </summary>
        public decimal DRWMIN { get; set; }
        /// <summary>
        /// 存期	C(6)
        /// </summary>
        public string TERDUM { get; set; }
        /// <summary>
        /// 协议利率	F(11,7)
        /// </summary>
        public decimal INTRAT { get; set; }
        /// <summary>
        /// 自动转存标志	C(1)
        /// 1-不转存
        /// 2-本息转存
        /// 3-本金转存，利息转活期
        /// </summary>
        public string MTUPRC { get; set; }
        /// <summary>
        /// 智能定期类型	C(1)    A-基础型 B-增强型
        /// </summary>
        public string ITGTYP { get; set; }
        /// <summary>
        /// 生效日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime BEGDAT { get; set; }
        /// <summary>
        /// 生效日期	D, 对应<see cref="BEGDAT"/>
        /// </summary>
        [XmlElement("BEGDAT")]
        public string BEGDATStr
        {
            get
            {
                return this.BEGDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.BEGDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 终止日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDAT { get; set; }
        /// <summary>
        /// 终止日期	D, 对应<see cref="ENDDAT"/>
        /// </summary>
        [XmlElement("ENDDAT")]
        public string ENDDATStr
        {
            get
            {
                return this.ENDDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ENDDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 透支额度	M
        /// </summary>
        public decimal OVRLMT { get; set; }
        /// <summary>
        /// 综合户余额	M
        /// </summary>
        public decimal TTLBAL { get; set; }
        /// <summary>
        /// 透支填平方式	C(1)    1-填平到零 2-填平到留存金额
        /// </summary>
        public string CTRMOD { get; set; }
        /// <summary>
        /// 预结息标志	C(1)    N-否 Y-是
        /// </summary>
        public string TTLFLG { get; set; }
        /// <summary>
        /// 延迟付息标志	C(1)    E-协议到期付息 N-否 Y-是
        /// </summary>
        public string PDRFLG { get; set; }
        /// <summary>
        /// 周期结息类型	C(1)
        /// H-半年付息
        /// M-按月付息
        /// S-按季付息
        /// Y-按年付息
        /// </summary>
        public string SETTYP { get; set; }
        /// <summary>
        /// 下次周期结息日	D
        /// </summary>
        [XmlIgnore]
        public DateTime? SETDAT { get; set; }
        /// <summary>
        /// 下次周期结息日	D, 对应<see cref="SETDAT"/>
        /// </summary>
        [XmlElement("SETDAT")]
        public string SETDATStr
        {
            get
            {
                return this.SETDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.SETDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.SETDAT = tmp;
                }
            }
        }
    }
    /// <summary>
    /// 8.6.7.组合存款协议明细查询响应内容
    /// </summary>
    public class NTCMAINFZ2
    {
        /// <summary>
        /// 分行号	C(2)
        /// </summary>
        public string FIXBBK { get; set; }
        /// <summary>
        /// 定期帐号	C(35)
        /// </summary>
        public string FIXACC { get; set; }
        /// <summary>
        /// 币种	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
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
        /// 利率	F(11,7)
        /// </summary>
        public decimal INTRAT { get; set; }
        /// <summary>
        /// 存期	C(6)
        /// </summary>
        public string TERDUM { get; set; }
        /// <summary>
        /// 自动转存标志	C(1)
        /// 1-不转存
        /// 2-本息转存
        /// 3-本金转存，利息转活期
        /// </summary>
        public string MTUPRC { get; set; }
        /// <summary>
        /// 账户余额	M
        /// </summary>
        public decimal FIXBAL { get; set; }
    }
}
