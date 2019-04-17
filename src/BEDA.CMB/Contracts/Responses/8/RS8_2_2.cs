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
    /// 8.2.2.基金份额查询（持仓基金查询）响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_2_2 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTFNPPOS
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTFNPPOS";
        /// <summary>
        /// 8.2.2.基金份额查询（持仓基金查询）响应集合
        /// </summary>
        [XmlElement("NTFNDPLSZ")]
        public List<NTFNDPLSZ> List { get; set; }
    }
    /// <summary>
    /// 8.2.2.基金份额查询（持仓基金查询）响应内容
    /// </summary>
    public class NTFNDPLSZ
    {
        /// <summary>
        /// 账户状态	C(1)	A-正常，B-冻结
        /// </summary>
        public string STSCOD { get; set; }
        /// <summary>
        /// SA代码	C(3)
        /// </summary>
        public string SAACOD { get; set; }
        /// <summary>
        /// 基金代码	C(8)
        /// </summary>
        public string FNDCOD { get; set; }
        /// <summary>
        /// 登记机构	C(3)
        /// </summary>
        public string TAACOD { get; set; }
        /// <summary>
        /// 管理公司	C(3)	
        /// </summary>
        public string CRPCOD { get; set; }
        /// <summary>
        /// 基金中文简称	Z(42)
        /// </summary>
        public string CHNABR { get; set; }
        /// <summary>
        /// 基金子类	C(1)    备用，缺省为空
        /// </summary>
        public string FNDSHR { get; set; }
        /// <summary>
        /// 报价货币	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 货币市场	C(1)	Y-现汇，N-现钞
        /// </summary>
        public string CCYMKT { get; set; }
        /// <summary>
        /// 代理协议编号	C(10)
        /// </summary>
        public string TACNBR { get; set; }
        /// <summary>
        /// 基金分类	C(1)	A-货币基金， N/空格-普通基金
        /// </summary>
        public string FNDMOD { get; set; }
        /// <summary>
        /// 份额明细展示标志	C(1)	Y-展示、 N-不展示
        /// </summary>
        public string FNDDTL { get; set; }
        /// <summary>
        /// 账面余额	M
        /// </summary>
        public decimal? FACBAL { get; set; }
        /// <summary>
        /// 可用余额	M
        /// </summary>
        public decimal? AVABAL { get; set; }
        /// <summary>
        /// 冻结余额	M
        /// </summary>
        public decimal? HLDBAL { get; set; }
        /// <summary>
        /// 浮动盈亏	M   	±金额
        /// </summary>
        public decimal? FACPNL { get; set; }
        /// <summary>
        /// 单位成本	F(11,7)
        /// </summary>
        public decimal? CUMPRC { get; set; }
        /// <summary>
        /// 总成本	M
        /// </summary>
        public decimal? CUMCST { get; set; }
        /// <summary>
        /// 累计收益	M   卖出部分盈亏（包括现金分红），有正负
        /// </summary>
        public decimal? CUMPNL { get; set; }
        /// <summary>
        /// 基金市值	M
        /// </summary>
        public decimal? MKTVAL { get; set; }
        /// <summary>
        /// 收益率	F(5,2)  %
        /// </summary>
        public decimal? EARRAT { get; set; }
        /// <summary>
        /// 预期收益率	F(5,2)  用于固定收益类产品%
        /// </summary>
        public decimal? EXPRAT { get; set; }
        /// <summary>
        /// 分红	M
        /// </summary>
        public decimal? CUMBNS { get; set; }
        /// <summary>
        /// 净值日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? NAVDAT { get; set; }
        /// <summary>
        /// 净值日期	D, 对应<see cref="NAVDAT"/>
        /// </summary>
        [XmlElement("NAVDAT")]
        public string NAVDATStr
        {
            get
            {
                return this.NAVDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.NAVDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.NAVDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 基金净值	F(11,7)
        /// </summary>
        public decimal? NAVVAL { get; set; }
        /// <summary>
        /// 起息日	D   用于固定收益类产品
        /// </summary>
        [XmlIgnore]
        public DateTime? RUNDAT { get; set; }
        /// <summary>
        /// 起息日	D, 对应<see cref="RUNDAT"/>
        /// </summary>
        [XmlElement("RUNDAT")]
        public string RUNDATStr
        {
            get
            {
                return this.RUNDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.RUNDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.RUNDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 到期日	D   用于固定收益类产品
        /// </summary>
        [XmlIgnore]
        public DateTime? RUNXDT { get; set; }
        /// <summary>
        /// 到期日	D, 对应<see cref="RUNXDT"/>
        /// </summary>
        [XmlElement("RUNXDT")]
        public string RUNXDTStr
        {
            get
            {
                return this.RUNXDT?.ToString("yyyyMMdd");
            }
            set
            {
                this.RUNXDT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.RUNXDT = tmp;
                }
            }
        }
        /// <summary>
        /// 下一开放日	D   	用于阳光私募,一对多,集合理财(含封闭期)
        /// </summary>
        [XmlIgnore]
        public DateTime? OPNDAT { get; set; }
        /// <summary>
        /// 下一开放日	D, 对应<see cref="OPNDAT"/>
        /// </summary>
        [XmlElement("OPNDAT")]
        public string OPNDATStr
        {
            get
            {
                return this.OPNDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.OPNDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OPNDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 权证账户号码	C(6)
        /// </summary>
        public string RIPACT { get; set; }
        /// <summary>
        /// 资金账户号码	C(15)
        /// </summary>
        public string ACTNBR { get; set; }
    }
}
