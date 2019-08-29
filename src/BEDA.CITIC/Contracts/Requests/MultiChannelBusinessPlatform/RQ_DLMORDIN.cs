using BEDA.CITIC.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CITIC.Contracts.Requests
{
    /// <summary>
    /// 订单信息新增请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLMORDIN : RqBase<RS_DLMORDIN>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLMORDIN"; set { } }

        /// <summary>
        /// 订单号varchar(20)
        /// </summary>
        [XmlElement("orderNo")]
        public string OrderNo { get; set; }
        /// <summary>
        /// 商户编号(0001) char(4)
        /// </summary>
        [XmlElement("bizCode")]
        public string BizCode { get; set; }
        /// <summary>
        /// 订单支付币种 char(2)
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }
        /// <summary>
        /// 交易金额 decimal(15,2)
        /// </summary>
        [XmlElement("tranAmt")]
        public decimal TranAmt { get; set; }
        /// <summary>
        /// 折扣金额 decimal(15,2) 可空
        /// </summary>
        [XmlElement("discount")]
        public decimal? Discount { get; set; }
        /// <summary>
        /// 折扣金额2 decimal(15,2) 可空
        /// </summary>
        [XmlElement("discount2")]
        public decimal? Discount2 { get; set; }
        /// <summary>
        /// 折扣金额3 decimal(15,2) 可空
        /// </summary>
        [XmlElement("discount3")]
        public decimal? Discount3 { get; set; }
        /// <summary>
        /// 实收金额 decimal(15,2)
        /// </summary>
        [XmlElement("realAmt")]
        public decimal RealAmt { get; set; }
        /// <summary>
        /// 付款方手机号varchar(11)
        /// </summary>
        [XmlElement("payMobile")]
        public string PayMobile { get; set; }
        /// <summary>
        /// 客户号varchar(20) 付款客户在ERP系统中的客户号
        /// </summary>
        [XmlElement("cstNo")]
        public string CstNo { get; set; }
        /// <summary>
        /// 付款客户名称varchar(122)
        /// </summary>
        [XmlElement("payCstName")]
        public string PayCstName { get; set; }
        /// <summary>
        /// 有效期 小时int 
        /// </summary>
        [XmlElement("validTime")]
        public int ValidTime { get; set; }
        /// <summary>
        /// 订单类型 varchar(2) 1：现结货单；2：赊账货单；3：到期应收货款；4：收押冷饮设备；5：免押冷饮设备；6：临赊
        /// </summary>
        [XmlElement("orderType")]
        public int OrderType { get; set; }
        /// <summary>
        /// 订单支付模式　目前只能填0或2，0：直接支付；1：冻结支付，先冻结，商户确认之后才扣账；2：只确认，不付款 char(1)
        /// </summary>
        [XmlElement("orderMode")]
        public int OrderMode { get; set; }
        /// <summary>
        /// 摘要 varchar(102) 可空
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }
        /// <summary>
        /// 支持卡种char(1) 0：全部；1：借计卡；2：信用卡
        /// </summary>
        [XmlElement("cardType")]
        public int CardType { get; set; }
        /// <summary>
        /// 支付结果通知范围 0：全部；1：成功的；2：失败的
        /// </summary>
        [XmlElement("notifyScope")]
        public int NotifyScope { get; set; }
        /// <summary>
        /// 结果通知范围0：全部（默认）；1：只通知付款或签收手机
        /// </summary>
        [XmlElement("notifyBody")]
        public int NotifyBody { get; set; }

        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlElement("list")]
        public List<CITICCollection<AddOrderInfo>> List { get; set; }

        
    }
    /// <summary>
    /// 订单信息新增
    /// </summary>
    public class AddOrderInfo
    {
        /// <summary>
        /// 序号 varchar(4)
        /// </summary>
        [XmlElement("seqNo")]
        public string SeqNo { get; set; }
        /// <summary>
        /// 商品名称 varchar(80) 可乐、联品、设备等
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
        /// <summary>
        /// 数量 bigInt
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }
        /// <summary>
        /// 单位varchar(20)
        /// </summary>
        [XmlElement("unit")]
        public string Unit { get; set; }
        /// <summary>
        /// 金额小记 decimal(15,2)
        /// </summary>
        [XmlElement("subTotal")]
        public string SubTotal { get; set; }
        /// <summary>
        /// 分期方式 int 0：全款； n：分n期
        /// </summary>
        [XmlElement("term")]
        public string Term { get; set; }
        /// <summary>
        /// 备注 varchar(200)
        /// </summary>
        [XmlElement("note")]
        public string Note { get; set; }

        /// <summary>
        /// 手机号 varchar(11)
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }
        /// <summary>
        /// 发送时间 char(1) 0：订单接收后；1：订单处理后
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
        /// <summary>
        /// 短信模版 int
        /// </summary>
        [XmlElement("msgModel")]
        public string MsgModel { get; set; }
        /// <summary>
        /// 用户类型 char(1) 可空 0：付款人； 1： 送货司机；2：收款方财务经理；3：付款方财务经理
        /// </summary>
        [XmlElement("ownerType")]
        public string OwnerType { get; set; }
        /// <summary>
        /// 用户姓名 varchar(20) 可空
        /// </summary>
        [XmlElement("ownerName")]
        public string OwnerName { get; set; }
    }
}
