using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.8.1理财产品认购/申购/撤销购买响应主体
    /// </summary>
    public class V1_FPPURCHTRNRS : IResponse
    {
        /// <summary>
        /// 3.8.1理财产品认购/申购/撤销购买响应主体
        /// </summary>
        public FPPURCHTRNRS FPPURCHTRNRS { get; set; }
    }
    /// <summary>
    /// 3.8.1理财产品认购/申购/撤销购买响应主体
    /// </summary>
    public class FPPURCHTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.8.1理财产品认购/申购/撤销购买响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public FPPURCHTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.8.1理财产品认购/申购/撤销购买响应内容
    /// </summary>
    public class FPPURCHTRN_RSBODY
    {
        /// <summary>
        /// 交易种类  0 认购 1 申购 2 撤销购买
        /// </summary>
        [XmlElement(Order = 0)]
        public int TRNTYPE { get; set; }
        /// <summary>
        /// 业务受理编号，最长16位
        /// </summary>
        [XmlElement(Order = 1)]
        public string ACCEPTNO { get; set; }
        /// <summary>
        /// 账户代号，最长32位
        /// </summary>
        [XmlElement(Order = 2)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 账户名称，最长60位
        /// </summary>
        [XmlElement(Order = 3)]
        public string NAME { get; set; }
        /// <summary>
        /// 证件类型
        /// 0 居民身份证或临时身份证     
        /// 1 企业客户营业执照           
        /// 2 企业代码证                 
        /// 3 企业客户其他有效证件
        /// 4 军人身份证                 
        /// 5 武警身份证                 
        /// 6 港、澳、台居民有效身份证   
        /// 7 外国护照                   
        /// 8 个人客户其他有效证件       
        /// 9 中国护照
        /// </summary>
        [XmlElement(Order = 4)]
        public int IDTYPE { get; set; }
        /// <summary>
        /// 证件号码，最长20位
        /// </summary>
        [XmlElement(Order = 5)]
        public string IDNO { get; set; }
        /// <summary>
        /// 手机号码，12位
        /// </summary>
        [XmlElement(Order = 6)]
        public string MOBILE { get; set; }
        /// <summary>
        /// 电话号码，最长30位
        /// </summary>
        [XmlElement(Order = 7)]
        public string PHONE { get; set; }
        /// <summary>
        /// 邮政编码，6位
        /// </summary>
        [XmlElement(Order = 8)]
        public string ZIP { get; set; }
        /// <summary>
        /// 地址，最长60位
        /// </summary>
        [XmlElement(Order = 9)]
        public string ADDR { get; set; }
        /// <summary>
        /// 电子邮箱，最长30位
        /// </summary>
        [XmlElement(Order = 10)]
        public string EMAIL { get; set; }
        /// <summary>
        /// 账户余额，decimal(15,2)，即整数位最长13位，小数位2位
        /// </summary>
        [XmlElement(Order = 11)]
        public decimal BALAMT { get; set; }
        /// <summary>
        /// 可用余额，decimal(15,2)，即整数位最长13位，小数位2位
        /// </summary>
        [XmlElement(Order = 12)]
        public decimal AVAILBAL { get; set; }
        /// <summary>
        /// 指令处理状态
        /// </summary>
        [XmlElement(Order = 13)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
}
