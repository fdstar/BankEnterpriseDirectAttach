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
    /// 3.8.1理财产品认购/申购/撤销购买请求主体
    /// </summary>
    public class V1_FPPURCHTRNRQ : IRequest<V1_FPPURCHTRNRS>
    {
        /// <summary>
        /// 3.8.1理财产品认购/申购/撤销购买请求主体
        /// </summary>
        public FPPURCHTRNRQ FPPURCHTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.8.1理财产品认购/申购/撤销购买请求主体
    /// </summary>
    public class FPPURCHTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.8.1理财产品认购/申购/撤销购买请求内容
        /// </summary>
        [XmlElement(Order = 1)]
        public FPPURCHTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.8.1理财产品认购/申购/撤销购买请求内容
    /// </summary>
    public class FPPURCHTRN_RQBODY
    {
        /// <summary>
        /// 交易种类  0 认购 1 申购 2 撤销购买 必输
        /// </summary>
        [XmlElement(Order = 0)]
        public int TRNTYPE { get; set; }
        /// <summary>
        /// 账户代号，最长32位	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 产品代码，8位	必输
        /// </summary>
        [XmlElement(Order = 2)]
        public string PRODNO { get; set; }
        /// <summary>
        /// 交易金额，decimal(15,2)，即整数位最长13位，小数位2位	必输
        /// </summary>
        [XmlElement(Order = 3)]
        public decimal TRNAMT { get; set; }
        /// <summary>
        /// 手机号码，12位	申购、认购时手机号码与电话号码二选一，必输其中一项，撤销时非必输
        /// </summary>
        [XmlElement(Order = 4)]
        public string MOBILE { get; set; }
        /// <summary>
        /// 电话号码，最长30位	申购、认购时手机号码与电话号码二选一，必输其中一项，撤销时非必输
        /// </summary>
        [XmlElement(Order = 5)]
        public string PHONE { get; set; }
        /// <summary>
        /// 邮政编码，6位	申购、认购时必输，撤销时非必输
        /// </summary>
        [XmlElement(Order = 6)]
        public string ZIP { get; set; }
        /// <summary>
        /// 地址，最长60位	申购、认购时必输，撤销时非必输
        /// </summary>
        [XmlElement(Order = 7)]
        public string ADDR { get; set; }
        /// <summary>
        /// 电子邮箱，最长30位	非必输
        /// </summary>
        [XmlElement(Order = 8)]
        public string EMAIL { get; set; }
    }
}
