using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.4.5单笔托收、子账户托收、回款查询响应主体
    /// </summary>
    public class V1_GATHERTRNRS : IResponse
    {
        /// <summary>
        /// 3.4.5单笔托收、子账户托收、回款查询响应
        /// </summary>
        public GATHERTRNRS GATHERTRNRS { get; set; }
    }
    /// <summary>
    /// 3.4.5单笔托收、子账户托收、回款查询响应
    /// </summary>
    public class GATHERTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.4.5提交返回节点，系统错误时没有此节点
        /// </summary>
        [XmlElement(Order = 2)]
        public GATHERRS GATHERRS { get; set; }
    }
    /// <summary>
    /// 提交返回节点
    /// </summary>
    public class GATHERRS
    {
        /// <summary>
        /// 请求托收、回款信息节点 必回
        /// </summary>
        [XmlElement(Order = 0)]
        public GATHERRSINFO GATHERINFO { get; set; }
        /// <summary>
        /// 交易结果
        /// </summary>
        [XmlElement(Order = 1)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
    /// <summary>
    /// 请求托收、回款信息节点
    /// </summary>
    public class GATHERRSINFO
    {
        /// <summary>
        /// 受理编号，托收时 必回
        /// </summary>
        [XmlElement(Order = 0)]
        public string ACCEPTNO { get; set; }
        /// <summary>
        /// 收款账户信息节点
        /// </summary>
        [XmlElement(Order = 1)]
        public GATHERRS_ACCTTO ACCTTO { get; set; }
        /// <summary>
        /// 单位编码， 4位	必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string FIRMCODE { get; set; }
        /// <summary>
        /// 业务编码， 5位。 <see cref="Requests.GATHERRQINFO.BIZCODE"/>	必回
        /// </summary>
        [XmlElement(Order = 3)]
        public string BIZCODE { get; set; }
        /// <summary>
        /// 托收摘要代号 <see cref="Requests.GATHERRQINFO.SUMM"/> 非必回
        /// </summary>
        [XmlElement(Order = 4)]
        public string SUMM { get; set; }
        /// <summary>
        /// 回款期限:1/2/3天 默认为3天 必回
        /// </summary>
        [XmlElement(Order = 5)]
        public int LIMITDAYS { get; set; }
        /// <summary>
        /// 标题，最大30位
        /// </summary>
        [XmlElement(Order = 6)]
        public string TITLE { get; set; }
        /// <summary>
        /// 托收备注，最大50位
        /// </summary>
        [XmlElement(Order = 7)]
        public string MEMO { get; set; }
        /// <summary>
        /// 凭证号，7位数字；可不填，默认使用电子凭证号。 托收时	必回
        /// </summary>
        [XmlElement(Order = 8)]
        public string CHEQUENUM { get; set; }
        /// <summary>
        /// 付款信息节点	必回
        /// </summary>
        [XmlElement(Order = 9)]
        public RSPAYINFO PAYINFO { get; set; }
    }
    /// <summary>
    /// 收款账户信息节点
    /// </summary>
    public class GATHERRS_ACCTTO
    {
        /// <summary>
        /// 收款账户(兴业银行账户)，32位
        /// 子账户托收返回22位或24位子账户 必回
        /// </summary>
        [XmlElement(Order = 0)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 收款人账户名称	非必回
        /// </summary>
        [XmlElement(Order = 1)]
        public string NAME { get; set; }
    }
    /// <summary>
    /// 付款信息节点
    /// </summary>
    public class RSPAYINFO : Requests.RQPAYINFO
    {
        /// <summary>
        /// 支付金额，整数位最长15位，小数2位
        /// </summary>
        [XmlElement(Order = 9)]
        public decimal PAYAMT { get; set; }
        /// <summary>
        /// 托收结果代码，整数。非0表示错误，  必回
        /// -1：表示处理未提交
        /// 0: 托收成功
        /// 1：托收失败
        /// 2：银行处理中
        /// 3：销账处理
        /// </summary>
        [XmlElement(Order = 10)]
        public int RESULT { get; set; }
        /// <summary>
        /// 错误信息，最大60位	必回
        /// </summary>
        [XmlElement(Order = 11)]
        public string MSG { get; set; }
    }
}
