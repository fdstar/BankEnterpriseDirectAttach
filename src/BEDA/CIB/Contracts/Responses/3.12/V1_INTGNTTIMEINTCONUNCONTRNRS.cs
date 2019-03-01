using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.12.7.4定活互转智能定期存款互联互通—关联/解关联响应主体
    /// </summary>
    public class V1_INTGNTTIMEINTCONUNCONTRNRS : IResponse
    {
        /// <summary>
        /// 3.12.7.4定活互转智能定期存款互联互通—关联/解关联响应主体
        /// </summary>
        public INTGNTTIMEINTCONUNCONTRNRS INTGNTTIMEINTCONUNCONTRNRS { get; set; }
    }
    /// <summary>
    /// 3.12.7.4定活互转智能定期存款互联互通—关联/解关联响应主体
    /// </summary>
    public class INTGNTTIMEINTCONUNCONTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.12.7.4定活互转智能定期存款互联互通—关联/解关联响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public INTGNTTIMEINTCONUNCONTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.12.7.4定活互转智能定期存款互联互通—关联/解关联响应内容
    /// </summary>
    public class INTGNTTIMEINTCONUNCONTRN_RSBODY
    {
        /// <summary>
        /// 活期账号	必回
        /// </summary>
        [XmlElement(Order = 1)]
        public string DEMANDACCOUNTNO { get; set; }
        /// <summary>
        /// 活期账号名称	必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string DEMANDACCOUNTNAME { get; set; }
        /// <summary>
        /// 关联智能定期存款账号	必回
        /// </summary>
        [XmlElement(Order = 3)]
        public string FIXEDACCOUNTNO { get; set; }
        /// <summary>
        /// 活期账户余额	必回
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal DEMANDAMOUNT { get; set; }
        /// <summary>
        /// 活期账户可用余额	必回
        /// </summary>
        [XmlElement(Order = 5)]
        public decimal AVAILAMOUNT { get; set; }
        /// <summary>
        /// 关联智能定期存款余额	必回
        /// </summary>
        [XmlElement(Order = 6)]
        public decimal BAMOUNT { get; set; }
        /// <summary>
        /// 可用余额  关联智能存款B款可用余额 必回
        /// </summary>
        [XmlElement(Order = 7)]
        public decimal BAVAILAMOUNT { get; set; }
        /// <summary>
        /// 智能定期存款互联互通业务余额	必回
        /// </summary>
        [XmlElement(Order = 8)]
        public decimal TOTALAMOUNT { get; set; }
        /// <summary>
        /// 可用余额 智能定期存款互联互通业务可用余额(活期账户账户可用余额+关联的智能定期账户可用余额)  必回
        /// </summary>
        [XmlElement(Order = 9)]
        public decimal TOTALAVAILAMOUNT { get; set; }
        /// <summary>
        /// 当日可透支额度	必回
        /// </summary>
        [XmlElement(Order = 10)]
        public decimal QUOTA { get; set; }
        /// <summary>
        /// 指令处理节点
        /// </summary>
        [XmlElement(Order = 40)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
}
