using BEDA.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.6.3虚拟子账户信息查询响应主体
    /// </summary>
    public class V1_VSASUBACCTINFOTRNRS : IResponse
    {
        /// <summary>
        /// 3.6.3虚拟子账户信息查询响应主体
        /// </summary>
        public VSASUBACCTINFOTRNRS VSASUBACCTINFOTRNRS { get; set; }
    }
    /// <summary>
    /// 3.6.3虚拟子账户信息查询响应主体
    /// </summary>
    public class VSASUBACCTINFOTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.6.3虚拟子账户信息查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public SUBACCTLIST SUBACCTLIST { get; set; }
    }
    /// <summary>
    /// 3.6.3虚拟子账户信息查询响应内容
    /// </summary>
    public class SUBACCTLIST
    {
        /// <summary>
        /// MORE是否有下一页，Y有，N无
        /// </summary>
        [XmlAttribute]
        public string MORE { get; set; }
        /// <summary>
        /// 3.6.3虚拟子账户信息查询响应集合
        /// </summary>
        [XmlElement("SUBACCTINFO", Order = 0)]
        public List<SUBACCTINFO> List { get; set; }
    }
    /// <summary>
    /// 3.6.3虚拟子账户信息查询响应明细
    /// </summary>
    public class SUBACCTINFO
    {
        /// <summary>
        /// 18位主账户
        /// </summary>
        [XmlElement(Order = 0)]
        public string MAINACCT { get; set; }
        /// <summary>
        /// 子账户
        /// </summary>
        [XmlElement(Order = 1)]
        public string SUBACCT { get; set; }
        /// <summary>
        /// 子账户名
        /// </summary>
        [XmlElement(Order = 2)]
        public string SUBACCTNAME { get; set; }
        /// <summary>
        /// 子账户利率
        /// </summary>
        [XmlElement(Order = 3)]
        public decimal RATE { get; set; }
        /// <summary>
        /// 子账户余额
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal BALANCE { get; set; }
        /// <summary>
        /// 子账户累计积数
        /// </summary>
        [XmlElement(Order = 5)]
        public decimal SUMMED { get; set; }
        /// <summary>
        /// 子账户利息
        /// </summary>
        [XmlElement(Order = 6)]
        public decimal INTEREST { get; set; }
        /// <summary>
        /// 子账户状态
        /// </summary>
        [XmlElement(Order = 7)]
        public string STATUS { get; set; }
        /// <summary>
        /// 利率代号,查询模式为1时返回
        /// 01010000-单位活期 
        /// 01021D01-单位一天通知 
        /// 01021D07-单位7天通知 
        /// 01030M03-单位定期3个月 
        /// 01030M06-单位定期6个月 
        /// 01030Y01-单位定期1年 
        /// 01030Y02-单位定期2年 
        /// 01030Y03-单位定期3年 
        /// 01030Y05-单位定期5年
        /// </summary>
        [XmlElement(Order = 8)]
        public string RATECODE { get; set; }
        /// <summary>
        /// 利率生效日期，格式YYYY-MM-DD,查询模式为1时返回
        /// </summary>
        [XmlIgnore]
        public DateTime? RATEWORKDATE { get; set; }
        /// <summary>
        /// 利率生效日期，YYYY-MM-DD ,对应<see cref="RATEWORKDATE"/> 查询模式为1时返回
        /// </summary>
        [XmlElement("RATEWORKDATE", Order = 9)]
        public string RATEWORKDATEStr
        {
            get
            {
                return this.RATEWORKDATE?.ToString("yyyy-MM-dd");
            }
            set
            {
                this.RATEWORKDATE = value.TryConvert<DateTime>();
            }
        }
        /// <summary>
        /// 利率比例浮动值 查询模式为1时返回
        /// </summary>
        [XmlElement(Order = 10)]
        public decimal? RATESCALEFLTVAL { get; set; }
        /// <summary>
        /// 利率点数浮动值 查询模式为1时返回
        /// </summary>
        [XmlElement(Order = 11)]
        public decimal? RATEPOINTFLTVAL { get; set; }
        /// <summary>
        /// 执行利率 查询模式为1时返回
        /// </summary>
        [XmlElement(Order = 12)]
        public decimal? EXECRATE { get; set; }
        /// <summary>
        /// 计息标志 查询模式为1时返回
        /// 0-不计息
        /// 1-不分段计息
        /// 2-按日分段计息
        /// </summary>
        [XmlElement(Order = 13)]
        public int? CALINTSIDENT { get; set; }
        /// <summary>
        /// 结息标志(即计息周期) 查询模式为1时返回
        /// 0-按月结息
        /// 1-按季结息
        /// 2-按年结息
        /// 3-利随本清
        /// 4-手工结息
        /// 7-按日结息
        /// 8-满月结息
        /// 9-满季结息
        /// A-满半年结息
        /// B-满一年结息
        /// C-满周结息
        /// D-满10天结息
        /// E-按半年结息
        /// F-自定义周期结息
        /// </summary>
        [XmlElement(Order = 14)]
        public string ADJINTSIDENT { get; set; }
        /// <summary>
        /// 结息周期  查询模式为1时返回
        /// 当结息标志为3、4只能为D00；
        /// 当结息标志为7时，只能为D01；
        /// 当结息标志为C时，只能为D07；
        /// 当结息标志为D时，只能为D10；
        /// 当结息标志为0、8时，只能为M01；
        /// 当结息标志为1、9时，只能为M03；
        /// 当结息标志为E、A时，只能为M06；
        /// 当结息标志为2、B时，只能为Y01；
        /// 当结息标志为F时，为客户手工录入数值。
        /// </summary>
        [XmlElement(Order = 15)]
        public string ADJINTSCYCLE { get; set; }
        /// <summary>
        /// 初次结息日期，格式YYYY-MM-DD  查询模式为1时返回
        /// </summary>
        [XmlIgnore]
        public DateTime? FIRADJINTSDATE { get; set; }
        /// <summary>
        /// 初次结息日期，格式YYYY-MM-DD ,对应<see cref="FIRADJINTSDATE"/>	查询模式为1时返回
        /// </summary>
        [XmlElement("FIRADJINTSDATE", Order = 16)]
        public string FIRADJINTSDATEStr
        {
            get
            {
                return this.FIRADJINTSDATE?.ToString("yyyy-MM-dd");
            }
            set
            {
                this.FIRADJINTSDATE = value.TryConvert<DateTime>();
            }
        }
        /// <summary>
        /// 应加应减积数 查询模式为1时返回
        /// </summary>
        [XmlElement(Order = 17)]
        public decimal? ADDREDMED { get; set; }
        /// <summary>
        /// 未结利息 查询模式为1时返回
        /// </summary>
        [XmlElement(Order = 18)]
        public decimal? NOKOTINTS { get; set; }
        /// <summary>
        /// 预算标志，0-否 1-是 查询模式为1时返回
        /// </summary>
        [XmlElement(Order = 19)]
        public int? BUDGETIDENT { get; set; }
        /// <summary>
        /// 预算额度 查询模式为1时返回
        /// </summary>
        [XmlElement(Order = 20)]
        public decimal? BUDGETQUOTA { get; set; }
        /// <summary>
        /// 预算额度起始日，格式YYYY-MM-DD  查询模式为1时返回
        /// </summary>
        [XmlIgnore]
        public DateTime? BUDGETDTSTART { get; set; }
        /// <summary>
        /// 预算额度起始日，格式YYYY-MM-DD ,对应<see cref="BUDGETDTSTART"/>	查询模式为1时返回
        /// </summary>
        [XmlElement("BUDGETDTSTART", Order = 21)]
        public string BUDGETDTSTARTStr
        {
            get
            {
                return this.BUDGETDTSTART?.ToString("yyyy-MM-dd");
            }
            set
            {
                this.BUDGETDTSTART = value.TryConvert<DateTime>();
            }
        }
        /// <summary>
        /// 预算额度到期日，格式YYYY-MM-DD  查询模式为1时返回
        /// </summary>
        [XmlIgnore]
        public DateTime? BUDGETDTEND { get; set; }
        /// <summary>
        /// 预算额度到期日，格式YYYY-MM-DD ,对应<see cref="BUDGETDTEND"/>	查询模式为1时返回
        /// </summary>
        [XmlElement("BUDGETDTEND", Order = 22)]
        public string BUDGETDTENDStr
        {
            get
            {
                return this.BUDGETDTEND?.ToString("yyyy-MM-dd");
            }
            set
            {
                this.BUDGETDTEND = value.TryConvert<DateTime>();
            }
        }
        /// <summary>
        /// 额度循环标志，查询模式为1时返回 
        /// 0-不循环，1-日，3-月，4-季，5-半年，6-年
        /// </summary>
        [XmlElement(Order = 23)]
        public int? BUDGETCYCLE { get; set; }
        /// <summary>
        /// 透支额度，大于0表示可透支，查询模式为1时返回 
        /// </summary>
        [XmlElement(Order = 24)]
        public decimal? OVERQUOTA { get; set; }
        /// <summary>
        /// 结算账号，查询模式为1时返回 
        /// </summary>
        [XmlElement(Order = 25)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 主账户户名，查询模式为1时返回 
        /// </summary>
        [XmlElement(Order = 26)]
        public string ACCTNAME { get; set; }
        /// <summary>
        /// 主账户余额，查询模式为1时返回 
        /// </summary>
        [XmlElement(Order = 27)]
        public decimal? ACCTBAL { get; set; }
        /// <summary>
        /// 子账户汇总余额，查询模式为1时返回 
        /// </summary>
        [XmlElement(Order = 28)]
        public decimal? SUBSUMBAL { get; set; }
    }
}
