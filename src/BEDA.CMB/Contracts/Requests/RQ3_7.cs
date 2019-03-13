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
    /// 3.7.直接内转请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ3_7 : CMBBase<RQINFO>, IRequest<RS3_7>
    {
        /// <summary>
        /// DCOPRTRF
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "DCOPRTRF";
        /// <summary>
        /// 3.7.直接内转请求内容 支付概要 注意此处只需传入BUSMOD和MODALS
        /// </summary>
        public SDKPAYRQX SDKPAYRQX { get; set; }
        /// <summary>
        /// 3.7.直接内转请求内容  支付明细  
        /// 允许重复次数1~30
        /// </summary>
        [XmlElement("DCOPRTRFX")]
        public List<DCOPRTRFX> List { get; set; }
    }
    /// <summary>
    /// 3.7.直接内转请求内容 支付明细
    /// </summary>
    public class DCOPRTRFX
    {
        /// <summary>
        /// 业务参考号	C（30）
        /// 用于标识该笔业务的编号，企业银行编号+业务类型+业务参考号必须唯一。企业可以自定义业务参考号，也可使用银行缺省值（单笔支付），批量支付须由企业提供。 直联必须用企业提供
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 期望日	D   默认为当前日期
        /// </summary>
        [XmlIgnore]
        public DateTime? ExpectedTime { get; set; }
        /// <summary>
        /// 期望日	D
        /// </summary>
        [XmlElement("EPTDAT")]
        public string EPTDATStr
        {
            get
            {
                return this.ExpectedTime?.ToString("yyyyMMdd");
            }
        }
        /// <summary>
        /// 期望时间	T   默认为‘000000’
        /// </summary>
        [XmlElement("EPTTIM")]
        public string EPTTIMStr
        {
            get
            {
                return this.ExpectedTime?.ToString("HHmmss");
            }
        }
        /// <summary>
        /// 付方帐号	N（35）	
        /// 企业用于付款的转出帐号，该帐号的币种类型必须与币种字段相符
        /// </summary>
        public string DBTACC { get; set; }
        /// <summary>
        /// 付方开户地区代码	C（2）	附录A.1
        /// </summary>
        public string DBTBBK { get; set; }
        /// <summary>
        /// 交易金额	M
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 币种代码	C(2)	附录A.3
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 用途	Z（62）   对应对账单中的摘要NARTXT
        /// </summary>
        public string NUSAGE { get; set; }
        /// <summary>
        /// 业务摘要	Z（200）用于企业付款时填写说明或者备注
        /// </summary>
        public string BUSNAR { get; set; }
        /// <summary>
        /// 收方帐号	N（35）
        /// 收款企业的转入帐号，该帐号的币种类型必须与币种字段相符
        /// </summary>
        public string CRTACC { get; set; }
        /// <summary>
        /// 收方信息不检查标志	C(1)	Y: 不检查收方开户地区信息 默认为Y
        /// 外币内转不支持
        /// </summary>
        public string CRTFLG { get; set; }
        /// <summary>
        /// 收方开户地区代码	C（2）	附录A.1 CRTFLG不为Y时必填。
        /// 为空则不支持收方识别功能；外币内转不能为空
        /// </summary>
        public string CRTBBK { get; set; }
    }
}
