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
    /// 8.3.5.当前持仓信息查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_3_5 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTQDIACT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQDIACT";
        /// <summary>
        /// 8.3.5.当前持仓信息查询响应集合
        /// </summary>
        [XmlElement("NTQDIACCZ")]
        public List<NTQDIACCZ> List { get; set; }
    }
    /// <summary>
    /// 8.3.5.当前持仓信息查询响应内容
    /// </summary>
    public class NTQDIACCZ
    {
        /// <summary>
        /// 产品代码	C(8)
        /// </summary>
        public string RIPCOD { get; set; }
        /// <summary>
        /// 产品简称	Z(22)
        /// </summary>
        public string NAMSNM { get; set; }
        /// <summary>
        /// 币种	C(2)	A.3 货币代码表
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 购入成本价格	F(11,7)
        /// </summary>
        public decimal BUYPRC { get; set; }
        /// <summary>
        /// 可用数量	M
        /// </summary>
        public decimal AVIQTY { get; set; }
        /// <summary>
        /// 帐户数量	M
        /// </summary>
        public decimal ACTQTY { get; set; }
        /// <summary>
        /// 当前市值	M
        /// </summary>
        public decimal VALAMT { get; set; }
        /// <summary>
        /// 浮动盈亏	M
        /// </summary>
        public decimal FPLAMT { get; set; }
        /// <summary>
        /// 资金帐号	C(15)
        /// </summary>
        public string ACTNBR { get; set; }
        /// <summary>
        /// 证券帐户	C(6)
        /// </summary>
        public string RIPACT { get; set; }
        /// <summary>
        /// 小数位数	C(1)
        /// </summary>
        public int PRCDEC { get; set; }
        /// <summary>
        /// 累积收益	M
        /// </summary>
        public decimal RTNAMT { get; set; }
        /// <summary>
        /// 钞汇标志	C(1)
        /// </summary>
        public string CCYMKY { get; set; }
        /// <summary>
        /// 赎回标记	C(1)
        /// </summary>
        public string REDCTL { get; set; }
        /// <summary>
        /// 起息日	D
        /// </summary>
        [XmlIgnore]
        public DateTime? INTVAL { get; set; }
        /// <summary>
        /// 起息日	D, 对应<see cref="INTVAL"/>
        /// </summary>
        [XmlElement("INTVAL")]
        public string INTVALStr
        {
            get
            {
                return this.INTVAL?.ToString("yyyyMMdd");
            }
            set
            {
                this.INTVAL = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.INTVAL = tmp;
                }
            }
        }
        /// <summary>
        /// 到期日	D
        /// </summary>
        [XmlIgnore]
        public DateTime? INTMAT { get; set; }
        /// <summary>
        /// 到期日	D, 对应<see cref="INTMAT"/>
        /// </summary>
        [XmlElement("INTMAT")]
        public string INTMATStr
        {
            get
            {
                return this.INTMAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.INTMAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.INTMAT = tmp;
                }
            }
        }
        /// <summary>
        /// 到期收益率	F(11,7)
        /// </summary>
        public decimal? RTNRAT { get; set; }
        /// <summary>
        /// 预估赎回费率	F(11,7)
        /// </summary>
        public decimal? REDCRT { get; set; }
        /// <summary>
        /// 产品类型	C(5)    第1位为“I”表示步步为赢
        /// </summary>
        public string RIPTYP { get; set; }
    }
}
