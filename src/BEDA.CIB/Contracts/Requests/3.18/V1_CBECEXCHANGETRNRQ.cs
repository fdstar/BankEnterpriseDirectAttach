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
    /// 3.18.2跨境电商结/售汇请求主体
    /// </summary>
    public class V1_CBECEXCHANGETRNRQ : IRequest<V1_CBECEXCHANGETRNRS>
    {
        /// <summary>
        /// 3.18.2跨境电商结/售汇请求主体
        /// </summary>
        public CBECEXCHANGETRNRQ CBECEXCHANGETRNRQ { get; set; }
    }
    /// <summary>
    /// 3.18.2跨境电商结/售汇请求主体
    /// </summary>
    public class CBECEXCHANGETRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.18.2跨境电商结/售汇请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public CBECEXCHANGETRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.18.2跨境电商结/售汇请求内容
    /// </summary>
    public class CBECEXCHANGETRN_RQBODY
    {
        /// <summary>
        /// 业务类型 0-结汇  1-购汇 必输
        /// </summary>
        [XmlElement(Order = 1)]
        public int BIZTYPE { get; set; }
        /// <summary>
        /// 外币账号	必输
        /// </summary>
        [XmlElement(Order = 2)]
        public string FORCURRACCTNO { get; set; }
        /// <summary>
        /// 外币账户名称	非必输
        /// </summary>
        [XmlElement(Order = 3)]
        public string FORCURRACCTNAME { get; set; }
        /// <summary>
        /// 人民币账号	必输
        /// </summary>
        [XmlElement(Order = 4)]
        public string RMBACCTNO { get; set; }
        /// <summary>
        /// 人民币账户名称	非必输
        /// </summary>
        [XmlElement(Order = 5)]
        public string RMBACCTNAME { get; set; }
        /// <summary>
        /// 金额(外币)	必输
        /// </summary>
        [XmlElement(Order = 6)]
        public decimal FORCURRAMT { get; set; }
        /// <summary>
        /// 结售汇类别  必输
        /// 结汇类别
        /// 0-贸易项下结汇   
        /// 1-非贸易项下结汇
        /// 2-资本项下结汇
        /// 售汇类别
        /// 3-贸易项下购汇
        /// 4-非贸易项下购汇
        /// 5-资本项下购汇
        /// </summary>
        [XmlElement(Order = 7)]
        public int EXCHANGECATEGORY { get; set; }
        /// <summary>
        /// 外汇账户交易编码 必输 参考附件 外汇账户交易编码（收入） 外汇账户交易编码（支出）
        /// </summary>
        [XmlElement(Order = 8)]
        public string TRANSCODE { get; set; }
        /// <summary>
        /// 结售汇编码 参考附件“结售汇编码”	必输
        /// </summary>
        [XmlElement(Order = 9)]
        public string EXCHANGECODE { get; set; }
        /// <summary>
        /// 备注	必输
        /// </summary>
        [XmlElement(Order = 10)]
        public string MEMO { get; set; }
    }
}
