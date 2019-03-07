using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.5.13证券交易类指令查询响应主体
    /// </summary>
    public class V1_QUERYTRADECOMMANDTRNRS : IResponse
    {
        /// <summary>
        /// 3.5.13证券交易类指令查询响应主体
        /// </summary>
        public QUERYTRADECOMMANDTRNRS QUERYTRADECOMMANDTRNRS { get; set; }
    }
    /// <summary>
    /// 3.5.13证券交易类指令查询响应主体
    /// </summary>
    public class QUERYTRADECOMMANDTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.5.13证券交易类指令查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public QUERYTRADECOMMANDTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.5.13证券交易类指令查询响应内容
    /// </summary>
    public class QUERYTRADECOMMANDTRN_RSBODY
    {
        /// <summary>
        /// 账户代号
        /// </summary>
        [XmlElement(Order = 2)]
        public string ACCTNO { get; set; }
        /// <summary>
        /// 账户名称
        /// </summary>
        [XmlElement(Order = 3)]
        public string NAME { get; set; }
        /// <summary>
        /// 资金账户
        /// </summary>
        [XmlElement(Order = 4)]
        public string FUNDACCTNO { get; set; }
        /// <summary>
        /// 券商编号/期货代码
        /// </summary>
        [XmlElement(Order = 5)]
        public string STCOKBRANCHCODE { get; set; }
        /// <summary>
        /// 凭证号
        /// </summary>
        [XmlElement(Order = 6)]
        public string CHEQUENUM { get; set; }
        /// <summary>
        /// 业务类型：
        /// 0-第三方存管
        /// 1-融资融券
        /// 2-银衍转账
        /// 3-银期直通车转账
        /// 4-期权现货转账
        /// </summary>
        [XmlElement(Order = 7)]
        public int BUSINESSTYPE { get; set; }
        /// <summary>
        /// 转账类型:  0-银转期/银行转证券，1-期转银/证券转银行
        /// </summary>
        [XmlElement(Order = 8)]
        public int TRANSFERTYPE { get; set; }
        /// <summary>
        /// 转账金额
        /// </summary>
        [XmlElement(Order = 9)]
        public decimal TRANSFERAMT { get; set; }
        /// <summary>
        /// 指令处理节点
        /// </summary>
        [XmlElement(Order = 20)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
}
