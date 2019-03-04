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
    /// 3.12.7.8定活互转智能定期存款—资金支取响应主体
    /// </summary>
    public class V1_DRAWINTELLIGENTTIMETRNRS : IResponse
    {
        /// <summary>
        /// 3.12.7.8定活互转智能定期存款—资金支取响应主体
        /// </summary>
        public DRAWINTELLIGENTTIMETRNRS DRAWINTELLIGENTTIMETRNRS { get; set; }
    }
    /// <summary>
    /// 3.12.7.8定活互转智能定期存款—资金支取响应主体
    /// </summary>
    public class DRAWINTELLIGENTTIMETRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.12.7.8定活互转智能定期存款—资金支取响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public DRAWINTELLIGENTTIMETRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.12.7.8定活互转智能定期存款—资金支取响应内容
    /// </summary>
    public class DRAWINTELLIGENTTIMETRN_RSBODY
    {
        /// <summary>
        /// 签约活期账号	必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string DEMANDACCOUNTNO { get; set; }
        /// <summary>
        /// 活期账号名称	非必回
        /// </summary>
        [XmlElement(Order = 3)]
        public string DEMANDACCOUNTNAME { get; set; }
        /// <summary>
        /// 活期账户余额	必回
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal DEMANDAMOUNT { get; set; }
        /// <summary>
        /// 活期账户可用余额 必回
        /// </summary>
        [XmlElement(Order = 5)]
        public decimal AVAILAMOUNT { get; set; }
        /// <summary>
        /// 关联智能定期存款账号	必回
        /// </summary>
        [XmlElement(Order = 6)]
        public string FIXEDACCOUNTNO { get; set; }
        /// <summary>
        /// 定期账号名称	非必回
        /// </summary>
        [XmlElement(Order = 7)]
        public string FIXEDACCOUNTNAME { get; set; }
        /// <summary>
        /// 开户日期	必回
        /// </summary>
        [XmlIgnore]
        public DateTime OPENDATE { get; set; }
        /// <summary>
        /// 开户日期 ,对应<see cref="OPENDATE"/> 必回
        /// </summary>
        [XmlElement("OPENDATE", Order = 8)]
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
        /// 可用余额 定期账户余额 必回
        /// </summary>
        [XmlElement(Order = 9)]
        public decimal BALANCE { get; set; }
        /// <summary>
        /// 存期（按协议）	必回
        /// </summary>
        [XmlElement(Order = 10)]
        public string TERMTYPE { get; set; }
        /// <summary>
        /// 续存方式（不续存）	必回
        /// </summary>
        [XmlElement(Order = 11)]
        public string CONTINUETERM { get; set; }
        /// <summary>
        /// 指令处理节点
        /// </summary>
        [XmlElement(Order = 20)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
}
