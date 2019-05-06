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
    /// 27.5.划拨关系明细查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS27_5 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTMTLQR3
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTMTLQR3";
        /// <summary>
        /// 27.5.划拨关系明细查询响应内容
        /// </summary>
        public NTMTLQR3Z1 NTMTLQR3Z1 { get; set; }
        /// <summary>
        /// 27.5.划拨关系明细查询响应内容
        /// </summary>
        public NTMTLQR3Z2 NTMTLQR3Z2 { get; set; }
    }
    /// <summary>
    /// 27.5.划拨关系明细查询响应内容
    /// </summary>
    public class NTMTLQR3Z1
    {
        /// <summary>
        /// 产品编号	C(8)
        /// </summary>
        public string PRDNBR { get; set; }
        /// <summary>
        /// 划拨关系编号	C(5)
        /// </summary>
        public string RLTNBR { get; set; }
        /// <summary>
        /// 上级账号分行号	C(2)
        /// </summary>
        public string TOPBBK { get; set; }
        /// <summary>
        /// 上级账号	C(35)
        /// </summary>
        public string TOPEAC { get; set; }
        /// <summary>
        /// 上级账号币种	C(2)
        /// </summary>
        public string TOPCCY { get; set; }
        /// <summary>
        /// 上级账号名称	Z(62)
        /// </summary>
        public string TOPNAM { get; set; }
        /// <summary>
        /// 下级账号分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 下级账号   	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 下级账号币种	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 下级账号名称	Z(62)
        /// </summary>
        public string EACNAM { get; set; }
        /// <summary>
        /// 内部户	C(10)
        /// </summary>
        public string INNACC { get; set; }
        /// <summary>
        /// 内部户名称	Z(100)
        /// </summary>
        public string INANAM { get; set; }
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
        /// 失效日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDAT { get; set; }
        /// <summary>
        /// 失效日期	D, 对应<see cref="ENDDAT"/>
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
        /// 实时头寸余额	F(17,2)
        /// </summary>
        public decimal AVLNOM { get; set; }
        /// <summary>
        /// 上日头寸余额	F(17,2)
        /// </summary>
        public decimal NOMLMT { get; set; }
        /// <summary>
        /// 累计上划余额	F(17,2)
        /// </summary>
        public decimal TTLUAM { get; set; }
        /// <summary>
        /// 累计下拨余额	F(17,2)
        /// </summary>
        public decimal TTLDAM { get; set; }
        /// <summary>
        /// 平台编号	C(10)
        /// </summary>
        public string PLTNBR { get; set; }
        /// <summary>
        /// 平台描述	Z(100)
        /// </summary>
        public string PLTDEC { get; set; }
        /// <summary>
        /// 状态	C(1)
        /// </summary>
        public string STSCOD { get; set; }
        /// <summary>
        /// 母回单类型	C(1)
        /// </summary>
        public string MUMPRT { get; set; }
        /// <summary>
        /// 母回单汇总方式	C(1)
        /// </summary>
        public string MUMPRF { get; set; }
        /// <summary>
        /// 子回单类型	C(1)
        /// </summary>
        public string SONPRT { get; set; }
        /// <summary>
        /// 子回单汇总方式	C(1)
        /// </summary>
        public string SONPRF { get; set; }
        /// <summary>
        /// 计价标志	C(1)    Y表示存在计价协议 N表示不存在计价协议  计价标志为Y时，才取接口NTMTLQR3Z2
        /// </summary>
        public string INTFLG { get; set; }
        /// <summary>
        /// 未结息标志	C(1)
        /// </summary>
        public string INPFLG { get; set; }
    }
    /// <summary>
    /// 27.5.划拨关系明细查询响应内容
    /// </summary>
    public class NTMTLQR3Z2
    {
        /// <summary>
        /// 产品编号	C(8)
        /// </summary>
        public string PRDNBR { get; set; }
        /// <summary>
        /// 币种	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 分段标志	C(1)
        /// </summary>
        public string SUBFLG { get; set; }
        /// <summary>
        /// 上次结息日	C(8)
        /// </summary>
        [XmlIgnore]
        public DateTime LSTDAT { get; set; }
        /// <summary>
        /// 上次结息日	C(8), 对应<see cref="LSTDAT"/>
        /// </summary>
        [XmlElement("LSTDAT")]
        public string LSTDATStr
        {
            get
            {
                return this.LSTDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.LSTDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 计价模式１	C(1)    U：上存头寸 空：未设置
        /// </summary>
        public string IT1MOD { get; set; }
        /// <summary>
        /// 计价模式1利率	F(11,7)
        /// </summary>
        public decimal? IT1VAL { get; set; }
        /// <summary>
        /// 计价模式2	C(1)    D：下借头寸空：未设置
        /// </summary>
        public string IT2MOD { get; set; }
        /// <summary>
        /// 计价模式2利率	F(11,7)
        /// </summary>
        public decimal? IT2VAL { get; set; }
        /// <summary>
        /// 计价生效日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime INTBEG { get; set; }
        /// <summary>
        /// 计价生效日期	D, 对应<see cref="INTBEG"/>
        /// </summary>
        [XmlElement("INTBEG")]
        public string INTBEGStr
        {
            get
            {
                return this.INTBEG.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.INTBEG = tmp;
                }
            }
        }
        /// <summary>
        /// 计价失效日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime INTEND { get; set; }
        /// <summary>
        /// 计价失效日期	D, 对应<see cref="INTEND"/>
        /// </summary>
        [XmlElement("INTEND")]
        public string INTENDStr
        {
            get
            {
                return this.INTEND.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.INTEND = tmp;
                }
            }
        }
    }
}
