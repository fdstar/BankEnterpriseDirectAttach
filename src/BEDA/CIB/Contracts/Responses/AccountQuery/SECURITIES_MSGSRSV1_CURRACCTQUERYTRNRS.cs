using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 活期账户信息查询响应主体
    /// </summary>
    public class SECURITIES_MSGSRSV1_CURRACCTQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 活期账户信息查询响应
        /// </summary>
        public CURRACCTQUERYTRNRS CURRACCTQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 活期账户信息查询响应
    /// </summary>
    public class CURRACCTQUERYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 账户信息，非必回
        /// </summary>
        [XmlElement(Order = 2)]
        public CURRACCTRSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 活期账户查询结果
    /// </summary>
    public class CURRACCTRSBODY
    {
        /// <summary>
        /// 查询账户代号，最长32位
        /// </summary>
        [XmlElement(Order = 0)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 账户名称，最长60位
        /// </summary>
        [XmlElement(Order = 1)]
        public string NAME { get; set; }
        /// <summary>
        /// 活期账户状态 0 删除 1 激活
        /// </summary>
        [XmlElement(Order = 2)]
        public byte STATUS { get; set; }
        /// <summary>
        /// 账户类型 0-一般账户 1-授权帐户
        /// </summary>
        [XmlElement(Order = 3)]
        public byte ACCTTYPE { get; set; }
        /// <summary>
        /// 账户余额 整数最长13位，小数2位
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal BALAMT { get; set; }
        /// <summary>
        /// 可用余额 整数最长13位，小数2位
        /// </summary>
        [XmlElement(Order = 5)]
        public decimal AVAILBAL { get; set; }
        /// <summary>
        /// 利率代号 8位
        /// </summary>
        [XmlElement(Order = 6)]
        public string INTRST { get; set; }
        /// <summary>
        /// 币种,2位
        /// </summary>
        [XmlElement(Order = 7)]
        public string CURRENCY { get; set; }
        /// <summary>
        /// 开户日期 yyyy-MM-dd
        /// </summary>
        [XmlElement(Order = 8)]
        public string OPENDAT { get; set; }
        /// <summary>
        /// 控制额度，decimal(17,2)，即整数最长15位，小数2位
        /// </summary>
        [XmlElement(Order = 9)]
        public decimal? CTRLLMT { get; set; }
        /// <summary>
        /// 冻结余额 ，decimal(17,2)，即整数最长15位，小数2位
        /// </summary>
        [XmlElement(Order = 10)]
        public decimal? FREEZELMT { get; set; }
    }
}
