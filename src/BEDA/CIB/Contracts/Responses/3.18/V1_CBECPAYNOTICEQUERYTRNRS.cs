using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.18.9跨境电商付汇通知查询响应主体
    /// </summary>
    public class V1_CBECPAYNOTICEQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 3.18.9跨境电商付汇通知查询响应主体
        /// </summary>
        public CBECPAYNOTICEQUERYTRNRS CBECPAYNOTICEQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 3.18.9跨境电商付汇通知查询响应主体
    /// </summary>
    public class CBECPAYNOTICEQUERYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.18.9跨境电商付汇通知查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public CBECPAYNOTICEQUERYTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.18.9跨境电商付汇通知查询响应内容
    /// </summary>
    public class CBECPAYNOTICEQUERYTRN_RSBODY
    {
        /// <summary>
        /// 是否有下一页，Y有，N无
        /// </summary>
        [XmlAttribute]
        public string MORE { get; set; }
        /// <summary>
        /// 3.18.9跨境电商付汇通知查询响应集合
        /// </summary>
        [XmlElement("CONTENT", Order = 1)]
        public List<CBECPAYNOTICEQUERYTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.18.9跨境电商付汇通知查询响应明细
    /// </summary>
    public class CBECPAYNOTICEQUERYTRN_CONTENT
    {
        /// <summary>
        /// 地区机构号	必回
        /// </summary>
        [XmlElement(Order = 0)]
        public string BRANCH_NO { get; set; }
        /// <summary>
        /// 网银客户号	必回
        /// </summary>
        [XmlElement(Order = 1)]
        public string NCID { get; set; }
        /// <summary>
        /// 核心客户号	必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string CID { get; set; }
        /// <summary>
        /// 关联系统批次号	必回
        /// </summary>
        [XmlElement(Order = 3)]
        public string RLTD_SRVC_NO { get; set; }
        /// <summary>
        /// STL业务编号	必回
        /// </summary>
        [XmlElement(Order = 4)]
        public string STL_BIZ_NO { get; set; }
        /// <summary>
        /// 国际收支申报编号	非必回
        /// </summary>
        [XmlElement(Order = 5)]
        public string BLNC_PYMT_NO { get; set; }
        /// <summary>
        /// 业务创建日期	必回
        /// </summary>
        [XmlIgnore]
        public DateTime BIZ_DATE { get; set; }
        /// <summary>
        /// 业务创建日期, 对应<see cref="BIZ_DATE"/>	必回
        /// </summary>
        [XmlElement("BIZ_DATE", Order = 6)]
        public string BIZ_DATEStr
        {
            get
            {
                return this.BIZ_DATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.BIZ_DATE = tmp;
                }
            }
        }
        /// <summary>
        /// 通知时间	必回
        /// </summary>
        [XmlIgnore]
        public DateTime CREATE_DATE { get; set; }
        /// <summary>
        /// 通知时间, 对应<see cref="CREATE_DATE"/>	必回
        /// </summary>
        [XmlElement("CREATE_DATE", Order = 7)]
        public string CREATE_DATEStr
        {
            get
            {
                return this.CREATE_DATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.CREATE_DATE = tmp;
                }
            }
        }
        /// <summary>
        /// 业务类型  集中付汇:JZF； 轧差付汇:GCF 必回
        /// </summary>
        [XmlElement(Order = 8)]
        public string BUSN_TYPE { get; set; }
        /// <summary>
        /// 汇款币种	必回
        /// </summary>
        [XmlElement(Order = 9)]
        public string CURRENCY { get; set; }
        /// <summary>
        /// 汇款金额	必回
        /// </summary>
        [XmlElement(Order = 10)]
        public decimal REMIT_AMOUNT { get; set; }
        /// <summary>
        /// 实际汇款币种	必回
        /// </summary>
        [XmlElement(Order = 11)]
        public string ACTUAL_CURRENCY { get; set; }
        /// <summary>
        /// 实付金额	必回
        /// </summary>
        [XmlElement(Order = 12)]
        public decimal ACTUAL_AMOUNT { get; set; }
        /// <summary>
        /// 收款人账号	必回
        /// </summary>
        [XmlElement(Order = 13)]
        public string PAYEE_ACCT_NO { get; set; }
        /// <summary>
        /// 收款人名称及地址	必回
        /// </summary>
        [XmlElement(Order = 14)]
        public string PAYEE_ACCT_NAME { get; set; }
        /// <summary>
        /// 汇款附言	非必回
        /// </summary>
        [XmlElement(Order = 15)]
        public string REMIT_MEMO { get; set; }
        /// <summary>
        /// 汇款人账号	必回
        /// </summary>
        [XmlElement(Order = 16)]
        public string REMITTER_ACCT_NO { get; set; }
        /// <summary>
        /// 交易状态 必回
        /// 0 已受理
        /// 1 审核中
        /// 2 退回原系统
        /// 3 已汇出
        /// 4 已退款
        /// 5 已退汇
        /// </summary>
        [XmlElement(Order = 17)]
        public int TRADE_STATUS { get; set; }
        /// <summary>
        /// 处理说明 退回原因描述等 非必回
        /// </summary>
        [XmlElement(Order = 18)]
        public string EXPLAIN { get; set; }
    }
}
