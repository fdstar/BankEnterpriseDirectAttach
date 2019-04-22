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
    /// 12.1.2.支付机构上传结售汇申请项下结汇明细数据请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ12_1_2 : CMBBase<RQINFO>, IRequest<RS12_1_2>
    {
        /// <summary>
        /// NTBEXDTL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTBEXDTL";
        /// <summary>
        /// 12.1.2.支付机构上传结售汇申请项下结汇明细数据请求内容
        /// </summary>
        public NTJSHBCHX NTJSHBCHX { get; set; }
        /// <summary>
        /// 12.1.2.支付机构上传结售汇申请项下结汇明细数据请求集合
        /// </summary>
        [XmlElement("NTBEXDTLX")]
        public List<NTBEXDTLX> List { get; set; }
    }
    /// <summary>
    /// 12.1.2.支付机构上传结售汇申请项下结汇明细数据请求内容
    /// </summary>
    public class NTJSHBCHX
    {
        /// <summary>
        /// 母业务网上业务编号	C（30）   输入值要与母业务的输入接口NTJSHOPRX. APPCNO相同
        /// </summary>
        public string APPCNO { get; set; }
        /// <summary>
        /// 分行号	C(2)	A.1 招行分行    与母业务相同
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 客户号	C(10)   与母业务相同
        /// </summary>
        public string CLTNBR { get; set; }
        /// <summary>
        /// 业务模式	C(5)    业务N07111的业务模式
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 母业务流程实例号	C(10)   可通过母业务返回报文获得
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 业务种类	C(3)	BEX：结汇申请 VEN：购汇申请
        /// </summary>
        public string TRSTYP { get; set; }
        /// <summary>
        /// 本批次轧差类型	C(1)	0、非轧差数据 3、余额在支出方的轧差 4、余额在收入方的轧差
        /// 余额在支出方的轧差：子业务明细数据有结汇数据也有售汇数据，但是结汇的总金额 > 售汇的总金额；
        /// 余额在购汇方的扎差：子业务明细数据有结汇数据也有售汇数据，但是购汇的总金额 > 结汇的总金额
        /// </summary>
        public string CALTYP { get; set; }
        /// <summary>
        /// 批次总笔数	N(6)    客户填入 如果上传的笔数等于总笔数，则当作收齐 后面不再收
        /// </summary>
        public int ALLCNT { get; set; }
        /// <summary>
        /// 本轮次明细类型	C(3)	BEX：结汇
        /// </summary>
        public string LODTYP { get; set; }
        /// <summary>
        /// 本轮次笔数	N(6)    用于核对本次上传的明细包是否完整，每轮最多100笔
        /// </summary>
        public int LODCNT { get; set; }
        /// <summary>
        /// 上传轮次序号	N(6)    需要指定且按顺序上传
        /// 注意：如果有结汇数据和售汇数据的，结汇数据和售汇数据的轮次序号是一起计算的，不是分别计算的（即同一笔母结汇业务的子业务上传的轮次序号统一计算）
        /// </summary>
        public int LODSEQ { get; set; }
        /// <summary>
        /// 保留字	C(50)
        /// </summary>
        public string RSV50Z { get; set; }
    }
    /// <summary>
    /// 12.1.2.支付机构上传结售汇申请项下结汇明细数据请求内容
    /// </summary>
    public class NTBEXDTLX
    {
        /// <summary>
        /// 交易唯一序号	C(22)   客户提供 本批次内必须唯一
        /// </summary>
        public string EVTSEQ { get; set; }
        /// <summary>
        /// 客户属性	C(2)	02 金融机构 03 中资机构 04 外资机构 05 居民个人 06 非居民个人
        /// </summary>
        public string CLTPRO { get; set; }
        /// <summary>
        /// 结售汇属性	C(4)	A.7 结售汇属性表  在CLTPRO为05居民个人或06非居民个人时，结售汇属性必须与结汇资金属性相同
        /// </summary>
        public string EXRPRO { get; set; }
        /// <summary>
        /// 居民标识	C(1)	Y 境内个人 N 境外个人
        /// 当CLTPRO=05或06时必输。
        /// 当FSTTYP=05时，RSDTAG=Y。
        /// 当FSTTYP=06时，RSDTAG=N
        /// </summary>
        public string RESTYP { get; set; }
        /// <summary>
        /// 国别（地区）代码	C(3)	A.8国家地区代码表  当CLTPRO=05或06时必输。 使用国家/地区代码表中的3位字母代码
        /// </summary>
        public string CNRCOD { get; set; }
        /// <summary>
        /// 证件类型	C(3)	P01 身份证 P18 港澳台来往大陆通行证 P31境外护照  当CLTPRO=05或06时必输
        /// </summary>
        public string CIDTYP { get; set; }
        /// <summary>
        /// 证件号码	Z(30)   当CLTPRO=05或06时必输。 当CIDTYP=P01，CIDCOD只能是15位或18位
        /// </summary>
        public string CIDCOD { get; set; }
        /// <summary>
        /// 结汇资金属性	C(3)    当CLTPRO=05或06时必输。
        /// 110 货物贸易
        /// 121 运输
        /// 122 旅游
        /// 123 金融和保险服务
        /// 124 专有权利使用费和特许费
        /// 125 咨询服务
        /// 126 其他服务
        /// 131 职工报酬和赡家款
        /// 132 投资收益
        /// 133 其他经常转移
        /// 210 资本账户
        /// 220 直接投资
        /// 230 证券投资
        /// 240 其他投资
        /// 250 国内外汇贷款
        /// 270 经批准的资本其他
        /// </summary>
        public string MNYPRO { get; set; }
        /// <summary>
        /// 姓名（收款人名称）	Z(62)
        /// </summary>
        public string BNFNAM { get; set; }
        /// <summary>
        /// 资金币种	C(3)    3位字母代码,必须在币种代码表里存在。 但必须申请时母业务的币种一致。可以是人民币（CNY）
        /// </summary>
        public string TRSCCY { get; set; }
        /// <summary>
        /// 结汇金额	M
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 资金形态	C(1)    当CLTPRO=05或06时必输, 可选项：3 账户资金
        /// </summary>
        public string MNYFOM { get; set; }
        /// <summary>
        /// 备注	Z(32)
        /// </summary>
        public string BEXRMK { get; set; }
        /// <summary>
        /// 支付机构代码	C（20）   CLTPRO=’05’ 居民个人或06非居民个人时，必输
        /// </summary>
        public string PAYBCD { get; set; }
    }
}
