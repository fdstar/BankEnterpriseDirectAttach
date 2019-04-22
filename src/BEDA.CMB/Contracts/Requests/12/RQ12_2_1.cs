using BEDA.CMB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Requests
{
    /// <summary>
    /// 12.2.1.支付机构经办实时购汇请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ12_2_1 : CMBBase<RQINFO>, IRequest<RS12_2_1>
    {
        /// <summary>
        /// NTOPREXB
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTOPREXB";
        /// <summary>
        /// 12.2.1.支付机构经办实时购汇请求内容
        /// </summary>
        public NTOPRMODX NTOPRMODX { get; set; }
        /// <summary>
        /// 12.2.1.支付机构经办实时购汇请求内容
        /// </summary>
        public NTOPREXCX1 NTOPREXCX1 { get; set; }
    }
    /// <summary>
    /// 12.2.1.支付机构经办实时购汇请求内容
    /// </summary>
    public class NTOPREXCX1
    {
        /// <summary>
        /// 网上业务编号(母业务的业务参考号)	C(30)
        /// 必输，支付机构申请母业务的唯一编号 参考号前三位按下面的个规则来填写，否则有可能会经办不通过 1、结汇时，EXS 2、购汇时，EXB
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 受理机构 	C(6)
        /// </summary>
        public string PRCBRN { get; set; }
        /// <summary>
        /// 买入分行号	C(2)	A.1 招行分行
        /// </summary>
        public string BUYBBK { get; set; }
        /// <summary>
        /// 买入金额	M   支付机构买入的金额 注：日元情况下，请使用无小数点13位整型。与卖出金额必填一
        /// </summary>
        public decimal? BUYAMT { get; set; }
        /// <summary>
        /// 买入币别	C(2)	A.3 货币代码表	   支付机构买入的币别。如买入金额有值,必填
        /// </summary>
        public string BUYCCY { get; set; }
        /// <summary>
        /// 买入账号	C(35)
        /// </summary>
        public string BUYACC { get; set; }
        /// <summary>
        /// 卖出分行号	C(2)	A.1 招行分行
        /// </summary>
        public string SELBBK { get; set; }
        /// <summary>
        /// 卖出金额	M	支付机构卖出的金额。 注：日元情况下，请使用无小数点13位整型。与买入金额必填一
        /// </summary>
        public decimal? SELAMT { get; set; }
        /// <summary>
        /// 卖出币别	C(2)	A.3 货币代码表   支付机构卖出的币别。如卖出金额有值必填
        /// </summary>
        public string SELCCY { get; set; }
        /// <summary>
        /// 卖出账号	C(35)
        /// </summary>
        public string SELACC { get; set; }
        /// <summary>
        /// 资金来源性质	C(3)	310:货物贸易 320:服务贸易
        /// </summary>
        public string SRCNAT { get; set; }
        /// <summary>
        /// 外汇户交易码	C(6)	A.19 外汇户交易码
        /// </summary>
        public string TRSCOD { get; set; }
        /// <summary>
        /// 支付机构标志	C(1)	1：支付机构跨境电商外汇集中收付 其他不是支付机构的业务
        /// </summary>
        public string SPLFLG { get; set; }
        /// <summary>
        /// 结汇属性大类	C(4)    100：经常项目（结汇填写）300：经常项目（购汇填写）
        /// </summary>
        public string EXCTYP { get; set; }
        /// <summary>
        /// 结汇属性细分	C(4)
        /// 结汇填下：
        /// 110：货物贸易  
        /// 120：服务贸易
        /// 121：运输  
        /// 122：旅游（含留学、考察、就医等） 
        /// 123：金融和保险服务
        /// 124：专有权利使用费和特许费
        /// 125：咨询服务
        /// 126：其他服务
        /// 购汇填写：
        /// 310：货物贸易
        /// 320：服务贸易
        /// 321：运输
        /// 322：旅游
        /// 323：金融和保险服务
        /// 324：专有权利使用费和特许费
        /// 325：咨询服务
        /// 326：其它服务
        /// </summary>
        public string EXCTY2 { get; set; }
        /// <summary>
        /// 保留字50	C(50)
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
