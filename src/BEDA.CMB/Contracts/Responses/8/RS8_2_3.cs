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
    /// 8.2.3.智能现金池定额定投计划列表查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_2_3 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTFNPPL1
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTFNPPL1";
        /// <summary>
        /// 8.2.3.智能现金池定额定投计划列表查询响应集合
        /// </summary>
        [XmlElement("NTFNPPLSZ")]
        public List<NTFNPPLSZ> List { get; set; }
    }
    /// <summary>
    /// 8.2.3.智能现金池定额定投计划列表查询响应内容
    /// </summary>
    public class NTFNPPLSZ
    {
        /// <summary>
        /// 计划编号	C(24)
        /// </summary>
        public string TAAAPP { get; set; }
        /// <summary>
        /// 基金代码	C(8) 
        /// </summary>
        public string FNDCOD { get; set; }
        /// <summary>
        /// 基金名称	Z(14)
        /// </summary>
        public string FNDNAM { get; set; }
        /// <summary>
        /// 交易代码	C(4) 	J022=智能投资 J024=智能赎回
        /// </summary>
        public string TRSCOD { get; set; }
        /// <summary>
        /// 执行类型	C(1) 	0 指定金额 1 智能保留金额
        /// </summary>
        public string TRSTYP { get; set; }
        /// <summary>
        /// 委托份额	M
        /// </summary>
        public decimal? ORDQTY { get; set; }
        /// <summary>
        /// 委托金额	M
        /// </summary>
        public decimal? ORDAMT { get; set; }
        /// <summary>
        /// 活期留存金额/补足活期金额	M
        /// </summary>
        public decimal? CURAMT { get; set; }
        /// <summary>
        /// 触发金额	M
        /// </summary>
        public decimal? LMTAMT { get; set; }
        /// <summary>
        /// 币种	C(2) 
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 周期	C(3)
        /// </summary>
        public string FNPTUN { get; set; }
        /// <summary>
        /// 周期单位	C(1) 
        /// </summary>
        public string FNPUNT { get; set; }
        /// <summary>
        /// 下一扣款日	C(8)
        /// </summary>
        [XmlIgnore]
        public DateTime? PAYDAT { get; set; }
        /// <summary>
        /// 下一扣款日	C(8), 对应<see cref="PAYDAT"/>
        /// </summary>
        [XmlElement("PAYDAT")]
        public string PAYDATStr
        {
            get
            {
                return this.PAYDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.PAYDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.PAYDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 累计回报次数	C(3)
        /// </summary>
        public int? SUMRTC { get; set; }
        /// <summary>
        /// 累计投资金额	M
        /// </summary>
        public decimal? SUMAMT { get; set; }
        /// <summary>
        /// 累计投资份额	M
        /// </summary>
        public decimal? SUMQTY { get; set; }
        /// <summary>
        /// 投资计划名称	Z(16)
        /// </summary>
        public string FNPNAM { get; set; }
        /// <summary>
        /// 投资计划状态	C(1) 	A-正常，B-暂停，C-关闭
        /// </summary>
        public string FNPSTA { get; set; }
    }
}
