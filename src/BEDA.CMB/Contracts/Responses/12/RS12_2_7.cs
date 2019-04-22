using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Responses
{
    /// <summary>
    /// 12.2.7.支付机构经办实时汇率成交响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS12_2_7 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTSBMEXC
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTSBMEXC";
        /// <summary>
        /// 12.2.7.支付机构经办实时汇率成交响应内容
        /// </summary>
        public NTSBMEXCZ1 NTSBMEXCZ1 { get; set; }
        /// <summary>
        /// 12.2.7.支付机构经办实时汇率成交响应内容
        /// </summary>
        public NTSBMEXCZ2 NTSBMEXCZ2 { get; set; }
    }
    /// <summary>
    /// 12.2.7.支付机构经办实时汇率成交响应内容
    /// </summary>
    public class NTSBMEXCZ1
    {
        /// <summary>
        /// 对方参考号   	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 流程实例号   	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 请求状态     	C(3)	附录A.5
        /// </summary>
        public string REQSTS { get; set; }
        /// <summary>
        /// 待处理操作序列	C(3)
        /// </summary>
        public string OPRSQN { get; set; }
        /// <summary>
        /// 操作别名     	Z(32)
        /// </summary>
        public string OPRALS { get; set; }
        /// <summary>
        /// 业务处理结果 	C(1)	附录A.6
        /// </summary>
        public string RTNFLG { get; set; }
        /// <summary>
        /// 错误码       	C(7)
        /// </summary>
        public string ERRCOD { get; set; }
        /// <summary>
        /// 错误文本     	Z(92)
        /// </summary>
        public string ERRTXT { get; set; }
        /// <summary>
        /// 保留字 30    	C(50)
        /// </summary>
        public string RSV30Z { get; set; }
    }
    /// <summary>
    /// 12.2.7.支付机构经办实时汇率成交响应内容
    /// </summary>
    public class NTSBMEXCZ2
    {
        /// <summary>
        /// 母业务编号	C(30)
        /// </summary>
        public string APPCNO { get; set; }
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 申请类型	C(4)	EXST：实时结汇;EXBT：实时购汇
        /// </summary>
        public string JSHCOD { get; set; }
        /// <summary>
        /// 结售汇类型	C(1)	0:实时交割即期
        /// </summary>
        public string JSHTYP { get; set; }
        /// <summary>
        /// 成交日期	D
        /// </summary>
        public string OPRDAT { get; set; }
        /// <summary>
        /// 成交时间	T
        /// </summary>
        public string OPRTIM { get; set; }
        /// <summary>
        /// 成交时间 由<see cref="OPRDAT"/>和<see cref="OPRTIM"/>组成
        /// </summary>
        [XmlIgnore]
        public DateTime? OperatedTime
        {
            get
            {
                if (DateTime.TryParseExact(string.Format("{0}{1}", this.OPRDAT, this.OPRTIM),
                   new string[] { "yyyyMMdd", "yyyyMMddHHmmss" }, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    return tmp;
                }
                return null;
            }
        }
        /// <summary>
        /// 成交汇率	F(11,7) 实际成交的该笔汇率
        /// </summary>
        public decimal AGRRAT { get; set; }
        /// <summary>
        /// 汇率基数	N
        /// </summary>
        public int RATBAS { get; set; }
        /// <summary>
        /// 买入金额	F(15,2) 支付机构实际买入的金额 注：日元情况下，请使用无小数点13位整型
        /// </summary>
        public decimal? BUYAMT { get; set; }
        /// <summary>
        /// 买入币别	C(2)	A.3 货币代码表
        /// </summary>
        public string BUYCCY { get; set; }
        /// <summary>
        /// 买入账号	C(35)
        /// </summary>
        public string BUYACC { get; set; }
        /// <summary>
        /// 卖出金额	M   支付机构卖出的金额 注：日元情况下，请使用无小数点13位整型
        /// </summary>
        public decimal? SELAMT { get; set; }
        /// <summary>
        /// 卖出币别	C(2)	A.3 货币代码表
        /// </summary>
        public string SELCCY { get; set; }
        /// <summary>
        /// 卖出账号	C(35)
        /// </summary>
        public string SELACC { get; set; }
        /// <summary>
        /// 结售汇编号  	C(10)   RTNFLG = S时，并且有值表示已经成交
        /// </summary>
        public string EXCNBR { get; set; }
        /// <summary>
        /// 资金来源性质	C(3)
        /// 310:货物贸易
        /// 320:服务贸易
        /// 330:收益与经常转移
        /// 400:资本与金融项目
        /// </summary>
        public string SRCNAT { get; set; }
        /// <summary>
        /// 外汇户交易码	C(6)	A.19 外汇户交易码
        /// </summary>
        public string TRSCOD { get; set; }
    }
}
