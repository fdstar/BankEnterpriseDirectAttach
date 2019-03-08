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
    /// 3.12.4通知转活期响应主体
    /// </summary>
    public class V1_CCCALL2CURRTRNRS : IResponse
    {
        /// <summary>
        /// 3.12.4通知转活期响应主体
        /// </summary>
        public CCCALL2CURRTRNRS CCCALL2CURRTRNRS { get; set; }
    }
    /// <summary>
    /// 3.12.4通知转活期响应主体
    /// </summary>
    public class CCCALL2CURRTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.12.4通知转活期响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public CCCALL2CURRTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.12.4通知转活期响应内容
    /// </summary>
    public class CCCALL2CURRTRN_RSBODY
    {
        /// <summary>
        /// 通知帐户信息
        /// </summary>
        [XmlElement(Order = 0)]
        public ACCTAMT CALLACCTINFO { get; set; }
        /// <summary>
        /// 开户日期 YYYY-MM-DD
        /// </summary>
        [XmlIgnore]
        public DateTime OPENDATE { get; set; }
        /// <summary>
        /// 开户日期 YYYY-MM-DD ,对应<see cref="OPENDATE"/>
        /// </summary>
        [XmlElement("OPENDATE", Order = 1)]
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
        [XmlElement(Order = 2)]
        public string TERM { get; set; }
        /// <summary>
        /// 续存标记 0-不滚存 1-单笔滚存 2-留存滚存
        /// </summary>
        [XmlElement(Order = 3)]
        public int ROLLOVER { get; set; }
        /// <summary>
        /// 申请金额，decimal(15,2)，即整数位最长13位，小数位2位
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal TRNAMT { get; set; }
        /// <summary>
        /// 活期帐号，最长32位
        /// </summary>
        [XmlElement(Order = 5)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 活期账户名，最长60位
        /// </summary>
        [XmlElement(Order = 6)]
        public string NAME { get; set; }
        /// <summary>
        /// 指令处理状态
        /// </summary>
        [XmlElement(Order = 7)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
}
