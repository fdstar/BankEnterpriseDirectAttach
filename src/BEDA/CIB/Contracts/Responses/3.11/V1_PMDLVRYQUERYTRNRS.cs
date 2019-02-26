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
    /// 3.11.1.5提货申请查询响应主体
    /// </summary>
    public class V1_PMDLVRYQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 3.11.1.5提货申请查询响应主体
        /// </summary>
        public PMDLVRYQUERYTRNRS PMDLVRYQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 3.11.1.5提货申请查询响应主体
    /// </summary>
    public class PMDLVRYQUERYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.11.1.5提货申请查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public PMDLVRYQUERYTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.11.1.5提货申请查询响应内容
    /// </summary>
    public class PMDLVRYQUERYTRN_RSBODY : BANKACCT
    {
        /// <summary>
        /// MORE是否有下一页，Y有，N无
        /// </summary>
        [XmlAttribute]
        public string MORE { get; set; }
        /// <summary>
        /// 3.11.1.5提货申请查询响应集合
        /// </summary>
        [XmlElement("CONTENT", Order = 10)]
        public List<PMDLVRYQUERYTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.11.1.5提货申请查询响应内容
    /// </summary>
    public class PMDLVRYQUERYTRN_CONTENT
    {
        /// <summary>
        /// 品种代码，
        /// 201 AU99.99       
        /// 202 AU99.95       
        /// 203 PT99.95       
        /// 207 AU100g
        /// </summary>
        [XmlElement(Order = 3)]
        public string PRODNO { get; set; }
        /// <summary>
        /// 提货流水号，16位	必回
        /// </summary>
        [XmlElement(Order = 4)]
        public string SEQ { get; set; }
        /// <summary>
        /// 提货状态 必回
        /// 1 未处理  
        /// 0 已提货  
        /// 2 划拨成功
        /// 3 可以提货
        /// 4 已撤销  
        /// 9 失败
        /// </summary>
        [XmlElement(Order = 5)]
        public int STATUS { get; set; }
        /// <summary>
        /// 提货单到期日 YYYY-MM-DD 必回
        /// </summary>
        [XmlIgnore]
        public DateTime DTEND { get; set; }
        /// <summary>
        /// 提货单到期日 YYYY-MM-DD, 对应<see cref="DTEND"/> 必回
        /// </summary>
        [XmlElement("DTEND", Order = 6)]
        public string DTENDStr
        {
            get
            {
                return this.DTEND.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DTEND = tmp;
                }
            }
        }
        /// <summary>
        /// 提货重量，decimal(17,2) 即整数位最长15位，小数位2位 必回
        /// </summary>
        [XmlElement(Order = 7)]
        public decimal PICKCNT { get; set; }
        /// <summary>
        /// 仓库代码，参见附录	必回
        /// </summary>
        [XmlElement(Order = 8)]
        public string STRGCODE { get; set; }
        /// <summary>
        /// 处理信息，最长60位	必回
        /// </summary>
        [XmlElement(Order = 9)]
        public string MSG { get; set; }
    }
}
