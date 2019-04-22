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
    /// 12.1.3.支付机构上传结售汇申请项下售汇明细数据请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ12_1_3 : CMBBase<RQINFO>, IRequest<RS12_1_3>
    {
        /// <summary>
        /// NTVENDTL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTVENDTL";
        /// <summary>
        /// 12.1.3.支付机构上传结售汇申请项下售汇明细数据请求内容
        /// </summary>
        public NTJSHBCHX NTJSHBCHX { get; set; }
        /// <summary>
        /// 12.1.3.支付机构上传结售汇申请项下售汇明细数据请求集合
        /// </summary>
        [XmlElement("NTVENDTLX")]
        public List<NTVENDTLX> List { get; set; }
    }
    /// <summary>
    /// 12.1.3.支付机构上传结售汇申请项下售汇明细数据请求内容
    /// </summary>
    public class NTVENDTLX
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
        /// 结售汇属性	C(4)	A.7 结售汇属性表  在CLTPRO为05居民个人时
        /// 当购汇种类=01，结售汇属性=3222
        /// 当购汇种类=02，结售汇属性=3222
        /// 当购汇种类=10，结售汇属性=310
        /// 当购汇种类=14，结售汇属性=3222
        /// </summary>
        public string EXRPRO { get; set; }
        /// <summary>
        /// 身份证件号码	Z(30)   在CLTPRO为05居民个人时必输，必须等于15位或18位。
        /// </summary>
        public string CIDCOD { get; set; }
        /// <summary>
        /// 购汇种类	C(2)
        /// 在CLTPRO为05居民个人时必输
        /// 01 境外旅游
        /// 02 自费出境学习
        /// 04 探亲
        /// 05 商务考察
        /// 06 朝觐
        /// 07 出境定居
        /// 08 境外就医
        /// 09 被聘工作
        /// 10 境外邮购
        /// 11 缴纳国际组织会员费
        /// 12 境外直系亲属救助
        /// 13 国际交流
        /// 14 境外培训
        /// 16 外派劳务
        /// 17 外汇理财
        /// 18 货物贸易及相关费用
        /// 19 境外咨询
        /// 99 其他
        /// </summary>
        public string EXBTYP { get; set; }
        /// <summary>
        /// 姓名（购汇人名称）	Z(62)   在CLTPRO为05居民个人时必输
        /// </summary>
        public string CLTNAM { get; set; }
        /// <summary>
        /// 国别（地区）代码	C(3)	A.8国家地区代码表  在CLTPRO为05居民个人时必输，使用国家/地区代码表中的3位字母代码 CLTPRO为05时固定为“CHN”
        /// </summary>
        public string CNRCOD { get; set; }
        /// <summary>
        /// 资金币种	C(3)    3位字母代码,必须在币种代码表里存在。但必须与购汇申请时，即母业务的币种一致。
        /// </summary>
        public string TRSCCY { get; set; }
        /// <summary>
        /// 购汇金额	M
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 购汇方式	C(1)    在CLTPRO为05居民个人时必输  6 存入个人外汇账户
        /// </summary>
        public string EXBMED { get; set; }
        /// <summary>
        /// 提钞金额	M   固定为“0”
        /// </summary>
        public decimal? CSHAMT { get; set; }
        /// <summary>
        /// 备注	Z(32)
        /// </summary>
        public string VENRMK { get; set; }
        /// <summary>
        /// 支付机构代码	C（20）   CLTPRO=’05’ 居民个人时，必输
        /// </summary>
        public string PAYBCD { get; set; }
        /// <summary>
        /// 保留字        	C(30)
        /// </summary>
        public string RSV30Z { get; set; }
    }
}
