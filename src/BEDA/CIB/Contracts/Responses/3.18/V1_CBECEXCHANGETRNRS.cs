using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.18.2跨境电商结/售汇响应主体
    /// </summary>
    public class V1_CBECEXCHANGETRNRS : IResponse
    {
        /// <summary>
        /// 3.18.2跨境电商结/售汇响应主体
        /// </summary>
        public CBECEXCHANGETRNRS CBECEXCHANGETRNRS { get; set; }
    }
    /// <summary>
    /// 3.18.2跨境电商结/售汇响应主体
    /// </summary>
    public class CBECEXCHANGETRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.18.2跨境电商结/售汇响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public CBECEXCHANGETRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.18.2跨境电商结/售汇响应内容
    /// </summary>
    public class CBECEXCHANGETRN_RSBODY
    {
        /// <summary>
        /// 业务类型 0-结汇  1-购汇 必回
        /// </summary>
        [XmlElement(Order = 1)]
        public int BIZTYPE { get; set; }
        /// <summary>
        /// 外币账号	必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string FORCURRACCTNO { get; set; }
        /// <summary>
        /// 外币账户名称	必回
        /// </summary>
        [XmlElement(Order = 3)]
        public string FORCURRACCTNAME { get; set; }
        /// <summary>
        /// 人民币账号	必回
        /// </summary>
        [XmlElement(Order = 4)]
        public string RMBACCTNO { get; set; }
        /// <summary>
        /// 人民币账户名称	必回
        /// </summary>
        [XmlElement(Order = 5)]
        public string RMBACCTNAME { get; set; }
        /// <summary>
        /// 金额(外币)	必回
        /// </summary>
        [XmlElement(Order = 6)]
        public decimal FORCURRAMT { get; set; }
        /// <summary>
        /// 金额(人民币)	必回
        /// </summary>
        [XmlElement(Order = 7)]
        public decimal RMBAMT { get; set; }
        /// <summary>
        /// 结售汇类别  必回
        /// 结汇类别
        /// 0-贸易项下结汇   
        /// 1-非贸易项下结汇
        /// 2-资本项下结汇
        /// 售汇类别
        /// 3-贸易项下购汇
        /// 4-非贸易项下购汇
        /// 5-资本项下购汇
        /// </summary>
        [XmlElement(Order = 8)]
        public int EXCHANGECATEGORY { get; set; }
        /// <summary>
        /// 外汇账户交易编码	必回  参考附件 外汇账户交易编码（收入） 外汇账户交易编码（支出）
        /// </summary>
        [XmlElement(Order = 9)]
        public string TRANSCODE { get; set; }
        /// <summary>
        /// 成交汇率	非必回
        /// </summary>
        [XmlElement(Order = 10)]
        public decimal? EXCHANGERATE { get; set; }
        /// <summary>
        /// 利率浮动方式 0-按浮动值浮动，1-按百分比浮动 必回
        /// </summary>
        [XmlElement(Order = 11)]
        public int FLOWTYPE { get; set; }
        /// <summary>
        /// 浮动值	必回
        /// </summary>
        [XmlElement(Order = 12)]
        public decimal FLOWVALUE { get; set; }
        /// <summary>
        /// 结售汇编码	必回  参考附件“结售汇编码”
        /// </summary>
        [XmlElement(Order = 13)]
        public string EXCHANGECODE { get; set; }
        /// <summary>
        /// 备注	必回
        /// </summary>
        [XmlElement(Order = 14)]
        public string MEMO { get; set; }
        /// <summary>
        /// 结售汇银行自身流水号	必回
        /// </summary>
        [XmlElement(Order = 15)]
        public string EXCHANGEBANKLSH { get; set; }
        /// <summary>
        /// 指令处理状态	必回
        /// </summary>
        [XmlElement(Order = 16)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
}
