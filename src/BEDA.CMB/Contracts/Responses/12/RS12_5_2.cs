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
    /// 12.5.2.实时购结汇综合查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS12_5_2 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTLSTEXC
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTLSTEXC";
        /// <summary>
        /// 12.5.2.实时购结汇综合查询响应集合
        /// </summary>
        [XmlElement("NTLSTEXCZ")]
        public List<NTLSTEXCZ> List { get; set; }
    }
    /// <summary>
    /// 12.5.2.实时购结汇综合查询响应内容
    /// </summary>
    public class NTLSTEXCZ
    {
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 业务模式	C(5)
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 客户名称	Z(62)
        /// </summary>
        public string CLTNAM { get; set; }
        /// <summary>
        /// 网上业务编号	C(30)
        /// </summary>
        public string APPCNO { get; set; }
        /// <summary>
        /// 申请类型	C(4)    EXST结汇 EXBT购汇
        /// </summary>
        public string JSHCOD { get; set; }
        /// <summary>
        /// 结售汇类型 	C(1)    0 即期
        /// </summary>
        public string JSHTYP { get; set; }
        /// <summary>
        /// 卖出货币	C(2)	A.3 货币代码表	
        /// </summary>
        public string SELCCY { get; set; }
        /// <summary>
        /// 卖出金额	M
        /// </summary>
        public decimal? SELAMT { get; set; }
        /// <summary>
        /// 客户卖出账号	C(35)
        /// </summary>
        public string SELACC { get; set; }
        /// <summary>
        /// 买入货币	C(2)	A.3 货币代码表
        /// </summary>
        public string BUYCCY { get; set; }
        /// <summary>
        /// 买入金额	M
        /// </summary>
        public decimal? BUYAMT { get; set; }
        /// <summary>
        /// 客户买入账号	C(35)
        /// </summary>
        public string BUYACC { get; set; }
        /// <summary>
        /// 请求状态	C(3)	A.5 业务请求状态
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
        /// 成交日期 	D
        /// </summary>
        [XmlIgnore]
        public DateTime? FINDAT { get; set; }
        /// <summary>
        /// 成交日期 	D, 对应<see cref="FINDAT"/>
        /// </summary>
        [XmlElement("FINDAT")]
        public string FINDATStr
        {
            get
            {
                return this.FINDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.FINDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.FINDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 结售汇编号 	C(10)
        /// </summary>
        public string EXCNBR { get; set; }
        /// <summary>
        /// 属性大类	C(4)
        /// </summary>
        public string EXRTYP { get; set; }
        /// <summary>
        /// 属性细分	C(4)
        /// </summary>
        public string EXRTY2 { get; set; }
        /// <summary>
        /// 外汇户交易码	C(6)
        /// </summary>
        public string TRSCOD { get; set; }
        /// <summary>
        /// 实际买入金额 	M
        /// </summary>
        public decimal RCVAMT { get; set; }
        /// <summary>
        /// 实际卖出金额 	M
        /// </summary>
        public decimal OUTAMT { get; set; }
        /// <summary>
        /// 实际成交汇率	F(11,7)
        /// </summary>
        public decimal EXGRAT { get; set; }
        /// <summary>
        /// 保留字     	C(30)
        /// </summary>
        public string RSV30Z { get; set; }
    }
}
