using BEDA.CIB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 3.9.2.4电子商业汇票提示收票申请请求主体
    /// </summary>
    public class V1_EBCOLLTRNRQ : IRequest<V1_EBCOLLTRNRS>
    {
        /// <summary>
        /// 3.9.2.4电子商业汇票提示收票申请请求主体
        /// </summary>
        public EBCOLLTRNRQ EBCOLLTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.9.2.4电子商业汇票提示收票申请请求主体
    /// </summary>
    public class EBCOLLTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.9.2.4电子商业汇票提示收票申请请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBCOLLTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.9.2.4电子商业汇票提示收票申请请求内容
    /// </summary>
    public class EBCOLLTRN_RQBODY
    {
        /// <summary>
        /// 票据总笔数,8位整数	必输
        /// </summary>
        [XmlElement(Order = 3)]
        public int TOTALCOUNT
        {
            get
            {
                return this.List?.Count ?? 0;
            }
            set { }
        }
        /// <summary>
        /// 票据总金额, 17位(15整数位,2小数位) 	必输
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal TOTALAMT
        {
            get
            {
                return this.List?.Sum(c => c.BILLAMT) ?? 0;
            }
            set { }
        }
        /// <summary>
        /// 操作人账户代号,最大32位	必输
        /// </summary>
        [XmlElement(Order = 5)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 票据类型,4位(AC01:银票,AC02:商票)	必输
        /// </summary>
        [XmlElement(Order = 6)]
        public string BILLTYPE { get; set; }
        /// <summary>
        /// 出票人备注	非必输
        /// </summary>
        [XmlElement(Order = 7)]
        public string MEMO { get; set; }
        /// <summary>
        /// 3.9.2.4电子商业汇票提示收票申请请求集合
        /// </summary>
        [XmlElement("CONTENT", Order = 10)]
        public List<EBCOLLTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.9.2.4电子商业汇票提示收票申请请求明细
    /// </summary>
    public class EBCOLLTRN_CONTENT
    {
        /// <summary>
        /// 小序号,4位	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public int INDX { get; set; }
        /// <summary>
        /// 票据号码,30位	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string BILLCODE { get; set; }
        /// <summary>
        /// 票据金额,17位(15整数位,2小数位)	必输
        /// </summary>
        [XmlElement(Order = 2)]
        public decimal BILLAMT { get; set; }
    }
}
