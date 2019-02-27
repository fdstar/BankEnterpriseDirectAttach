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
    /// 3.12.5.5定活互转智能通知存款资金支取响应主体
    /// </summary>
    public class V1_ICWITHDRAWALTRNRS : IResponse
    {
        /// <summary>
        /// 3.12.5.5定活互转智能通知存款资金支取响应主体
        /// </summary>
        public ICWITHDRAWALTRNRS ICWITHDRAWALTRNRS { get; set; }
    }
    /// <summary>
    /// 3.12.5.5定活互转智能通知存款资金支取响应主体
    /// </summary>
    public class ICWITHDRAWALTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.12.5.5定活互转智能通知存款资金支取响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public ICWITHDRAWALTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.12.5.5定活互转智能通知存款资金支取响应内容
    /// </summary>
    public class ICWITHDRAWALTRN_RSBODY
    {
        /// <summary>
        /// 通知账户信息
        /// </summary>
        [XmlElement(Order = 1)]
        public ACCTAMT CALLACCTINFO { get; set; }
        /// <summary>
        /// 开户日期 YYYY-MM-DD
        /// </summary>
        [XmlIgnore]
        public DateTime OPENDATE { get; set; }
        /// <summary>
        /// 开户日期 YYYY-MM-DD ,对应<see cref="OPENDATE"/>
        /// </summary>
        [XmlElement("OPENDATE", Order = 2)]
        public string OPENDATEStr
        {
            get
            {
                return this.OPENDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OPENDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 存期 D01 一天通知 D07 七天通知
        /// </summary>
        [XmlElement(Order = 3)]
        public string TERM { get; set; }
        /// <summary>
        /// 续存标记 0-不滚存 1-单笔滚存 2-留存滚存
        /// </summary>
        [XmlElement(Order = 4)]
        public int ROLLOVER { get; set; }
        /// <summary>
        /// 活期账户信息
        /// </summary>
        [XmlElement(Order = 5)]
        public ACCTAMT CURRACCTINFO { get; set; }
        /// <summary>
        /// 支取金额，decima(17,2) 即整数位最长15位，小数位2位
        /// </summary>
        [XmlElement(Order = 6)]
        public decimal TRNAMT { get; set; }
        /// <summary>
        /// 指令处理节点
        /// </summary>
        [XmlElement(Order = 20)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
}
