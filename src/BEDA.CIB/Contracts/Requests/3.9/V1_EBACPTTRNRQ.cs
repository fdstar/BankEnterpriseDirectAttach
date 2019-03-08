using BEDA.CIB.Contracts.Responses;
using BEDA.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 3.9.2.3电子商业汇票提示承兑申请请求主体
    /// </summary>
    public class V1_EBACPTTRNRQ : IRequest<V1_EBACPTTRNRS>
    {
        /// <summary>
        /// 3.9.2.3电子商业汇票提示承兑申请请求主体
        /// </summary>
        public EBACPTTRNRQ EBACPTTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.9.2.3电子商业汇票提示承兑申请请求主体
    /// </summary>
    public class EBACPTTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.9.2.3电子商业汇票提示承兑申请请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBACPTTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.9.2.3电子商业汇票提示承兑申请请求内容
    /// </summary>
    public class EBACPTTRN_RQBODY
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
        /// 出票人账户代号	必输
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
        /// 3.9.2.3电子商业汇票提示承兑申请请求集合
        /// </summary>
        [XmlElement("CONTENT", Order = 10)]
        public List<EBACPTTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.9.2.3电子商业汇票提示承兑申请请求明细
    /// </summary>
    public class EBACPTTRN_CONTENT
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
        /// <summary>
        /// 到期无条件支付委托,4位只能是CC00	必输
        /// </summary>
        [XmlElement(Order = 3)]
        public string ENTRSPAY { get; set; }
        /// <summary>
        /// 交易合同号,最大30位	非必输
        /// </summary>
        [XmlElement(Order = 4)]
        public string CONTRACTID { get; set; }
        /// <summary>
        /// 发票号码,最大30位	非必输
        /// </summary>
        [XmlElement(Order = 5)]
        public string INVCNO { get; set; }
        /// <summary>
        /// 承兑金额,17位(15整数位,2小数位)(暂只能是票面金额) 非必输
        /// </summary>
        [XmlIgnore]
        public decimal? ACPTAMT { get; set; }
        /// <summary>
        /// 承兑金额,17位(15整数位,2小数位)(暂只能是票面金额) 对应<see cref="ACPTAMT"/>	非必输
        /// </summary>
        [XmlElement("ACPTAMT", Order = 6)]
        public string ACPTAMTStr
        {
            get
            {
                return this.ACPTAMT?.ToString();
            }
            set
            {
                this.ACPTAMT = value.TryConvert<decimal>();
            }
        }
    }
}
