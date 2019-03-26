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
    /// 6.13.采购分离平台订单推送请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ6_13 : CMBBase<RQINFO>, IRequest<RS6_13>
    {
        /// <summary>
        /// NTORDSND
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTORDSND";
        /// <summary>
        /// 6.13.采购分离平台订单推送请求内容
        /// </summary>
        public NTORDSNDX1 NTORDSNDX1 { get; set; }
    }
    /// <summary>
    /// 6.13.采购分离平台订单推送请求内容
    /// </summary>
    public class NTORDSNDX1
    {
        /// <summary>
        /// 结算种类	C(1)	C：出票 B：背书   若平台传空，则有买家登录网银选择结算方式
        /// </summary>
        public string STLTYP { get; set; }
        /// <summary>
        /// 付款账号	C(20)   买方账号
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 收款人名称	Z(62)   出票对应收票人，背书对应被背书人
        /// </summary>
        public string OPCNAM { get; set; }
        /// <summary>
        /// 收款人行号	C(12)
        /// </summary>
        public string OPCBRD { get; set; }
        /// <summary>
        /// 收款人账号	C(35)
        /// </summary>
        public string OPCEAC { get; set; }
        /// <summary>
        /// 商户编号     	C(10)
        /// </summary>
        public string MCHNBR { get; set; }
        /// <summary>
        /// 合同号  	C(40)
        /// </summary>
        public string CTRNBR { get; set; }
        /// <summary>
        /// 合同描述	Z(402)
        /// </summary>
        public string CTRDSP { get; set; }
        /// <summary>
        /// 对方商户号	C(10)
        /// </summary>
        public string REFMCH { get; set; }
        /// <summary>
        /// 对方订单号	C(40)
        /// 订单号+订单支付号必须唯一 查询对账单时，可查到订单号+订单支付号信息，但只显示20个字符，因此建议商户生成的订单号+订单支付号长度不要超过20个字符
        /// </summary>
        public string REFORD { get; set; }
        /// <summary>
        /// 对方订单支付号	C(10)
        /// </summary>
        public string SUBORD { get; set; }
        /// <summary>
        /// 担保开票支付模式标志	C(1)	Y: 担保出票标志 N: 非担保出票（默认值） 该字段只适合于出票支付，背书时该字段无效。
        /// </summary>
        public string GRNTEE { get; set; }
        /// <summary>
        /// 订单金额     	M   后续出票或背书的票据金额必须等于这个金额
        /// </summary>
        public decimal ORDAMT { get; set; }
        /// <summary>
        /// 订单种类     	C(1)	1：水电费       2：税务缴费     3：网站购物     4：电话费       5：行政事业收费 6：其他
        /// </summary>
        public string ORDTYP { get; set; }
        /// <summary>
        /// 失效日期     	D   若不指定则按商银协议设定自动计算失效日期。 超过该日期日初自动撤销订单
        /// </summary>
        [XmlIgnore]
        public DateTime? CNLDAT { get; set; }
        /// <summary>
        /// 失效日期     	D, 对应<see cref="CNLDAT"/>
        /// </summary>
        [XmlElement("CNLDAT")]
        public string CNLDATStr
        {
            get
            {
                return this.CNLDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.CNLDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.CNLDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 采购人员名称	Z(22)
        /// </summary>
        public string PCHUSR { get; set; }
        /// <summary>
        /// 采购人员手机	C(15)
        /// </summary>
        public string PCHPHN { get; set; }
        /// <summary>
        /// 承兑人/行名称	Z(62)
        /// </summary>
        public string ACPNAM { get; set; }
        /// <summary>
        /// 承兑人/行账号	C(20)
        /// </summary>
        public string ACPACC { get; set; }
        /// <summary>
        /// 承兑人/行号	C(12)
        /// </summary>
        public string ACPBRD { get; set; }
        /// <summary>
        /// 承兑人/行信息是否可编辑	C(1)	Y: 买方企业指定承兑人/行 N: 买方企业不能修改承兑人/行（商户指定承兑人/行）  未输入则默认为Y
        /// </summary>
        public string ACPEDT { get; set; }
        /// <summary>
        /// 票据种类	C(4)	AC01：银承 AC02：商承 如果有值则锁定传入值，买方只能使用平台指定的票据种类出票（此票据种类对背书支付无影响）
        /// </summary>
        public string BLITYP { get; set; }
        /// <summary>
        /// 定制类型	C(2)	00：无定制 01：3合1   如果有值则锁定传入值。买方只能使用平台指定的定制类型出票
        /// </summary>
        public string CLTCNV { get; set; }
        /// <summary>
        /// 金额检查方式	C(1)	0：不检查 E：背书票据金额必须等于订单金额 L:背书票据金额必须大于等于订单金额 S：背书票据金额必须小于等于订单金额
        /// 仅对背书支付方式有效 未输入则默认为E
        /// </summary>
        public string CHKAMT { get; set; }
        /// <summary>
        /// 保留字段	C(50)
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
