using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.12.6.1定活互转结构性存款产品信息查询响应主体
    /// </summary>
    public class V1_STRUCTPRODUCTTRNRS : IResponse
    {
        /// <summary>
        /// 3.12.6.1定活互转结构性存款产品信息查询响应主体
        /// </summary>
        public STRUCTPRODUCTTRNRS STRUCTPRODUCTTRNRS { get; set; }
    }
    /// <summary>
    /// 3.12.6.1定活互转结构性存款产品信息查询响应主体
    /// </summary>
    public class STRUCTPRODUCTTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.12.6.1定活互转结构性存款产品信息查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public STRUCTPRODUCTTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.12.6.1定活互转结构性存款产品信息查询响应内容
    /// </summary>
    public class STRUCTPRODUCTTRN_RSBODY
    {
        /// <summary>
        /// 3.12.6.1定活互转结构性存款产品信息查询响应集合
        /// </summary>
        [XmlElement("CONTENT", Order = 0)]
        public List<STRUCTPRODUCTTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.12.6.1定活互转结构性存款产品信息查询响应明细
    /// </summary>
    public class STRUCTPRODUCTTRN_CONTENT
    {
        /// <summary>
        /// 结构性存款产品序号
        /// </summary>
        [XmlElement( Order = 1)]
        public string PRODUCTNO { get; set; }
        /// <summary>
        /// 结构性存款产品名称
        /// </summary>
        [XmlElement(Order = 2)]
        public string PRODUCTNAME { get; set; }
        /// <summary>
        /// 结构性存款产品类型
        /// </summary>
        [XmlElement(Order = 3)]
        public string PRODUCTTYPE { get; set; }
        /// <summary>
        /// 结构性存款产品期限
        /// </summary>
        [XmlElement(Order = 4)]
        public string PRODUCTTERM { get; set; }
        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement(Order = 5)]
        public string CURRENCY { get; set; }
        /// <summary>
        /// 参考利率，即客户收益率
        /// </summary>
        [XmlElement(Order = 6)]
        public decimal REFERRATE { get; set; }
        /// <summary>
        /// 起存金额
        /// </summary>
        [XmlElement(Order = 7)]
        public decimal MINOPENAMOUNT { get; set; }
        /// <summary>
        /// 递增金额
        /// </summary>
        [XmlElement(Order = 8)]
        public decimal INCREASEAMOUNT { get; set; }
        /// <summary>
        /// 剩余额度
        /// </summary>
        [XmlElement(Order = 9)]
        public decimal LEFTEDBALANCE { get; set; }
    }
}
