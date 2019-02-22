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
    /// 3.9.3.9电子商业汇票票据池可操作票据查询响应主体
    /// </summary>
    public class V1_EBPOPERATEBILLQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 3.9.3.9电子商业汇票票据池可操作票据查询响应主体
        /// </summary>
        public EBPOPERATEBILLQUERYTRNRS EBPOPERATEBILLQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 3.9.3.9电子商业汇票票据池可操作票据查询响应主体
    /// </summary>
    public class EBPOPERATEBILLQUERYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.9.3.9电子商业汇票票据池可操作票据查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBPOPERATEBILLQUERYTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.9.3.9电子商业汇票票据池可操作票据查询响应内容
    /// </summary>
    public class EBPOPERATEBILLQUERYTRN_RSBODY
    {
        /// <summary>
        /// MORE是否有下一页，Y有，N无
        /// </summary>
        [XmlAttribute]
        public string MORE { get; set; }
        /// <summary>
        /// 票据总笔数	必回
        /// </summary>
        [XmlElement(Order = 3)]
        public int TOTALCOUNT { get; set; }
        /// <summary>
        /// 票据总金额（18,2） 	必回
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal TOTALAMT { get; set; }
        /// <summary>
        /// 3.9.3.9电子商业汇票票据池可操作票据查询响应集合
        /// </summary>
        [XmlElement("CONTENT", Order = 10)]
        public List<EBPOPERATEBILLQUERYTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.9.3.9电子商业汇票票据池可操作票据查询响应内容
    /// </summary>
    public class EBPOPERATEBILLQUERYTRN_CONTENT
    {
        /// <summary>
        /// 业务编号，商票系统内部编号	必回
        /// </summary>
        [XmlElement(Order = 1)]
        public string BIZNO { get; set; }
        /// <summary>
        /// 归属机构号，票据机构所属机构号	必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string BELONGORGNO { get; set; }
        /// <summary>
        /// 票据号码，16位	必回
        /// </summary>
        [XmlElement(Order = 3)]
        public string BILLCODE { get; set; }
        /// <summary>
        /// 票据金额（18,2）	必回
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal BILLAMT { get; set; }
        /// <summary>
        /// 票据类型，AC01银承 AC02商承	必回
        /// </summary>
        [XmlElement(Order = 5)]
        public string BILLTYPE { get; set; }
        /// <summary>
        /// 票据状态  必回
        /// 92-托管在池
        /// 93-质押在池
        /// </summary>
        [XmlElement(Order = 6)]
        public string BILLSTATUS { get; set; }
        /// <summary>
        /// 出票日期 YYYY-MM-DD 必回
        /// </summary>
        [XmlIgnore]
        public DateTime OUTDATE { get; set; }
        /// <summary>
        /// 出票日期，格式yyyy-MM-dd ,对应<see cref="OUTDATE"/> 必回
        /// </summary>
        [XmlElement("OUTDATE", Order = 7)]
        public string OUTDATEStr
        {
            get
            {
                return this.OUTDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OUTDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 出票截止日期 YYYY-MM-DD 必回
        /// </summary>
        [XmlIgnore]
        public DateTime DUEDATE { get; set; }
        /// <summary>
        /// 出票截止日期，格式yyyy-MM-dd ,对应<see cref="DUEDATE"/> 必回
        /// </summary>
        [XmlElement("DUEDATE", Order = 8)]
        public string DUEDATEStr
        {
            get
            {
                return this.DUEDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DUEDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 出票人名称	必回
        /// </summary>
        [XmlElement(Order = 9)]
        public string DRAWERNAME { get; set; }
        /// <summary>
        /// 出票人账号	必回
        /// </summary>
        [XmlElement(Order = 10)]
        public string DRAWERACCTNO { get; set; }
        /// <summary>
        /// 付款行名称，商承时指付款人开户行名称	必回
        /// </summary>
        [XmlElement(Order = 11)]
        public string DRAWERBANKNAME { get; set; }
        /// <summary>
        /// 付款行行号	必回
        /// </summary>
        [XmlElement(Order = 12)]
        public string DRAWERBANKCODE { get; set; }
        /// <summary>
        /// 收款人名称	必回
        /// </summary>
        [XmlElement(Order = 13)]
        public string PAYEENAME { get; set; }
        /// <summary>
        /// 收款人账号	必回
        /// </summary>
        [XmlElement(Order = 14)]
        public string PAYEEACCTNO { get; set; }
        /// <summary>
        /// 收款人开户行名称	必回
        /// </summary>
        [XmlElement(Order = 15)]
        public string PAYEEBANKNAME { get; set; }
        /// <summary>
        /// 收款人开户行行号	必回
        /// </summary>
        [XmlElement(Order = 16)]
        public string PAYEEBANKCODE { get; set; }
    }
}
