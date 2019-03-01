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
    /// 3.12.7.2定活互转智能定期存款互联互通—签约账户查询响应主体
    /// </summary>
    public class V1_INTGNTTIMEINTCONQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 3.12.7.2定活互转智能定期存款互联互通—签约账户查询响应主体
        /// </summary>
        public INTGNTTIMEINTCONQUERYTRNRS INTGNTTIMEINTCONQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 3.12.7.2定活互转智能定期存款互联互通—签约账户查询响应主体
    /// </summary>
    public class INTGNTTIMEINTCONQUERYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.12.7.2定活互转智能定期存款互联互通—签约账户查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public INTGNTTIMEINTCONQUERYTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.12.7.2定活互转智能定期存款互联互通—签约账户查询响应内容
    /// </summary>
    public class INTGNTTIMEINTCONQUERYTRN_RSBODY
    {
        /// <summary>
        /// MORE是否有下一页，Y有，N无
        /// </summary>
        [XmlAttribute]
        public string MORE { get; set; }
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
        /// 留存金额	必回
        /// </summary>
        [XmlElement(Order = 3)]
        public decimal OBLIGATEAMOUNT { get; set; }
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
        /// 智能定期存款互联互通业务余额 (活期账户账户余额+关联的智能定期账户余额)	必回
        /// </summary>
        [XmlElement(Order = 6)]
        public decimal TOTALAMOUNT { get; set; }
        /// <summary>
        /// 可用余额 智能定期存款互联互通业务可用余额(活期账户账户可用余额+关联的智能定期账户可用余额)  必回
        /// </summary>
        [XmlElement(Order = 7)]
        public decimal TOTALAVAILAMOUNT { get; set; }
        /// <summary>
        /// 关联智能定期存款余额 (关联智能存款B款余额) 必回
        /// </summary>
        [XmlElement(Order = 8)]
        public decimal BAMOUNT { get; set; }
        /// <summary>
        /// 可用余额 关联智能存款B款可用余额 必回
        /// </summary>
        [XmlElement(Order = 9)]
        public decimal BAVAILAMOUNT { get; set; }
        /// <summary>
        /// 当日可透支额度	必回
        /// </summary>
        [XmlElement(Order = 10)]
        public decimal QUOTA { get; set; }
        /// <summary>
        /// 3.12.7.2定活互转智能定期存款互联互通—签约账户查询响应集合
        /// </summary>
        [XmlElement("CONTENT", Order = 30)]
        public List<INTGNTTIMEINTCONQUERYTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.12.7.2定活互转智能定期存款互联互通—签约账户查询响应明细
    /// </summary>
    public class INTGNTTIMEINTCONQUERYTRN_CONTENT
    {
        /// <summary>
        /// 账户序号	非必回
        /// </summary>
        [XmlElement(Order = 1)]
        public string ACCTSEQ { get; set; }
        /// <summary>
        /// 开户金额	必回
        /// </summary>
        [XmlElement(Order = 2)]
        public decimal OPENAMT { get; set; }
        /// <summary>
        /// 账户余额	必回
        /// </summary>
        [XmlElement(Order = 3)]
        public decimal ACCTAMOUNT { get; set; }
        /// <summary>
        /// 开户日期，格式yyyy-MM-dd
        /// </summary>
        [XmlIgnore]
        public DateTime OPENDATE { get; set; }
        /// <summary>
        /// 开户日期，格式yyyy-MM-dd ,对应<see cref="OPENDATE"/>
        /// </summary>
        [XmlElement("OPENDATE", Order = 4)]
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
        /// 账户状态  必回
        /// 0：删除  1：有效 2：销户 4：冻结
        /// 5：挂失  6暂收账 7：已入账 
        /// 8：销账未成功  9：退票 A:结清
        /// B：控制 C：抵押 D：回收 E：休假
        /// F：协防 G：公示催告 H：久悬
        /// I：开户暂封
        /// </summary>
        [XmlElement(Order = 5)]
        public string STATUS { get; set; }
        /// <summary>
        /// 开户机构	必回
        /// </summary>
        [XmlElement(Order = 6)]
        public string ORGCODE { get; set; }
        /// <summary>
        /// 开户柜员	必回
        /// </summary>
        [XmlElement(Order = 7)]
        public string OPERCODE { get; set; }
    }
}
