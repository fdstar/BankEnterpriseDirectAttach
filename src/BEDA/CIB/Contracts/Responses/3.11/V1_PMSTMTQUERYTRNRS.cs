using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.11.1.6出入金明细查询响应主体
    /// </summary>
    public class V1_PMSTMTQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 3.11.1.6出入金明细查询响应主体
        /// </summary>
        public PMSTMTQUERYTRNRS PMSTMTQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 3.11.1.6出入金明细查询响应主体
    /// </summary>
    public class PMSTMTQUERYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.11.1.6出入金明细查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public PMSTMTQUERYTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.11.1.6出入金明细查询响应内容
    /// </summary>
    public class PMSTMTQUERYTRN_RSBODY : BANKACCT
    {
        /// <summary>
        /// MORE是否有下一页，Y有，N无
        /// </summary>
        [XmlAttribute]
        public string MORE { get; set; }
        /// <summary>
        /// 3.11.1.6出入金明细查询响应集合
        /// </summary>
        [XmlElement("CONTENT", Order = 10)]
        public List<PMSTMTQUERYTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.11.1.6出入金明细查询响应内容
    /// </summary>
    public class PMSTMTQUERYTRN_CONTENT
    {
        /// <summary>
        /// 贵金属交易流水号，16位	必回
        /// </summary>
        [XmlElement(Order = 3)]
        public string SEQ { get; set; }
        /// <summary>
        /// 交易日期 YYYY-MM-DD 必回
        /// </summary>
        [XmlIgnore]
        public DateTime DTTRN { get; set; }
        /// <summary>
        /// 交易日期 YYYY-MM-DD, 对应<see cref="DTTRN"/> 必回
        /// </summary>
        [XmlElement("DTTRN", Order = 4)]
        public string DTTRNStr
        {
            get
            {
                return this.DTTRN.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DTTRN = tmp;
                }
            }
        }
        /// <summary>
        /// 交易金额，decimal(17,2)，即整数位最长15位，小数位2位	必回
        /// </summary>
        [XmlElement(Order = 5)]
        public decimal TRNAMT { get; set; }
        /// <summary>
        /// 资金方向 必回
        /// 0 出金           
        /// 1 入金           
        /// 5 保证金出金     
        /// 6 保证金入金     
        /// 7 利息发放
        /// b 开户手续费扣账
        /// c 销户结息       
        /// 8 黄金入金
        /// </summary>
        [XmlElement(Order = 6)]
        public string TRNTYPE { get; set; }
        /// <summary>
        /// 资金状态 必回
        /// 0 成功             
        /// 1 失败             
        /// 2 未处理           
        /// 3 银行处理成功     
        /// 4 柜台处理成功     
        /// 5 冲正成功         
        /// 6 冻结交易已作解冻
        /// </summary>
        [XmlElement(Order = 7)]
        public int STATUS { get; set; }
    }
}
