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
    /// 12.5.1.结售汇申请综合查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS12_5_1 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTLSTJSH
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTLSTJSH";
        /// <summary>
        /// 12.5.1.结售汇申请综合查询响应集合
        /// </summary>
        [XmlElement("NTWAUJSHZ")]
        public List<NTWAUJSHZ> List { get; set; }
    }
    /// <summary>
    /// 12.5.1.结售汇申请综合查询响应内容
    /// </summary>
    public class NTWAUJSHZ
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
        /// 申请人客户号	C(10)
        /// </summary>
        public string APPNBR { get; set; }
        /// <summary>
        /// 客户名称	Z(62)
        /// </summary>
        public string CLTNAM { get; set; }
        /// <summary>
        /// 网上业务编号	C(30)
        /// </summary>
        public string APPCNO { get; set; }
        /// <summary>
        /// 申请类型	C(4)    EXBY: 购汇申请
        /// </summary>
        public string JSHCOD { get; set; }
        /// <summary>
        /// 结售汇类型 	C(1)    0：实时交割即期 1：非实时交割即期 2：远期 3：择期
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
        /// 实际买入金额	M
        /// </summary>
        public decimal RCVAMT { get; set; }
        /// <summary>
        /// 实际卖出金额	M
        /// </summary>
        public decimal OUTAMT { get; set; }
        /// <summary>
        /// 实际成交汇率	F(11,7)
        /// </summary>
        public decimal EXGRAT { get; set; }
        /// <summary>
        /// 网点市价汇率	F(11,7)
        /// </summary>
        public decimal BRNRAT { get; set; }
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
        /// 期望日	D
        /// </summary>
        [XmlIgnore]
        public DateTime? EPTDAT { get; set; }
        /// <summary>
        /// 期望日	D, 对应<see cref="EPTDAT"/>
        /// </summary>
        [XmlElement("EPTDAT")]
        public string EPTDATStr
        {
            get
            {
                return this.EPTDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.EPTDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EPTDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 附件标志	C(1)
        /// </summary>
        public string ATHFLG { get; set; }
    }
}
