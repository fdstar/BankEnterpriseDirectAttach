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
    /// 3.12.1活期转定期  3.12.1定期转活期响应主体
    /// </summary>
    public class V1_FINANCINGTRNRS : IResponse
    {
        /// <summary>
        /// 3.12.1活期转定期  3.12.1定期转活期响应主体
        /// </summary>
        public FINANCINGTRNRS FINANCINGTRNRS { get; set; }
    }
    /// <summary>
    /// 3.12.1活期转定期  3.12.1定期转活期响应主体
    /// </summary>
    public class FINANCINGTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.12.1活期转定期  3.12.1定期转活期响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public FINANCEINFO FINANCEINFO { get; set; }
        /// <summary>
        /// 指令处理状态
        /// </summary>
        [XmlElement(Order = 3)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
    /// <summary>
    /// 3.12.1活期转定期  3.12.1定期转活期响应内容
    /// </summary>
    public class FINANCEINFO
    {
        /// <summary>
        /// 活期账户号，最长32位
        /// </summary>
        [XmlElement(Order = 0)]
        public string DEMANDACCT { get; set; }
        /// <summary>
        /// 定期账户号，最长32位
        /// </summary>
        [XmlElement(Order = 1)]
        public string TIMEACCT { get; set; }
        /// <summary>
        /// 凭证号，8位
        /// </summary>
        [XmlElement(Order = 2)]
        public string VOUCHER { get; set; }
        /// <summary>
        /// 开户日期 YYYY-MM-DD
        /// </summary>
        [XmlIgnore]
        public DateTime OPENDATE { get; set; }
        /// <summary>
        /// 开户日期 YYYY-MM-DD ,对应<see cref="OPENDATE"/>
        /// </summary>
        [XmlElement("OPENDATE", Order = 3)]
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
        /// 存期：M03（3个月）、M06（6个月）、Y01（一年）、Y02（两年）、Y03（三年）、Y05（五年）
        /// </summary>
        [XmlElement(Order = 4)]
        public string TERM { get; set; }
        /// <summary>
        /// 转账日期 YYYY-MM-DD
        /// </summary>
        [XmlIgnore]
        public DateTime TRNDATE { get; set; }
        /// <summary>
        /// 转账日期 YYYY-MM-DD ,对应<see cref="TRNDATE"/>
        /// </summary>
        [XmlElement("TRNDATE", Order = 5)]
        public string TRNDATEStr
        {
            get
            {
                return this.TRNDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.TRNDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 利率
        /// </summary>
        [XmlElement(Order = 6)]
        public decimal RATIO { get; set; }
        /// <summary>
        /// 余额
        /// </summary>
        [XmlElement(Order = 7)]
        public decimal AMOUNT { get; set; }
        /// <summary>
        /// 续存标志，
        /// 0 不续存  
        /// 1 存本付息 
        /// 2 本息续存 
        /// 3 本利转活期 
        /// 4 部分转定期
        /// 5 部分转活期
        /// </summary>
        [XmlElement(Order = 8)]
        public int CONTFLAG { get; set; }
        /// <summary>
        /// 处理状态（中文） 
        /// </summary>
        [XmlElement(Order = 9)]
        public string PRCCODE { get; set; }
        /// <summary>
        /// 处理信息
        /// </summary>
        [XmlElement(Order = 10)]
        public string MESSAGE { get; set; }
    }
}
