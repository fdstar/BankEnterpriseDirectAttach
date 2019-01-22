using BEDA.CIB.Contracts.Responses;
using BEDA.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 3.6.2虚拟子账户批量开户请求主体（最多20笔）
    /// </summary>
    public class V1_VSABATCHOPENTRNRQ : IRequest<V1_VSABATCHOPENTRNRS>
    {
        /// <summary>
        /// 3.6.2虚拟子账户批量开户请求主体（最多20笔）
        /// </summary>
        public VSABATCHOPENTRNRQ VSABATCHOPENTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.6.2虚拟子账户批量开户请求主体（最多20笔）
    /// </summary>
    public class VSABATCHOPENTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.6.2虚拟子账户批量开户请求内容（最多20笔）
        /// </summary>
        [XmlElement(Order = 1)]
        public VSABATCHOPENTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.6.2虚拟子账户批量开户请求内容（最多20笔）
    /// </summary>
    public class VSABATCHOPENTRN_RQBODY
    {
        /// <summary>
        /// 18位主账户	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public string MAINACCT { get; set; }
        /// <summary>
        /// 总笔数，整数	非必输
        /// </summary>
        [XmlIgnore]
        public int? TOTALCOUNT { get; set; }
        /// <summary>
        /// 总笔数，整数  对应<see cref="TOTALCOUNT"/>	非必输
        /// </summary>
        [XmlElement("TOTALCOUNT", Order = 1)]
        public string TOTALCOUNTStr
        {
            get
            {
                return this.TOTALCOUNT?.ToString();
            }
            set
            {
                this.TOTALCOUNT = value.TryConvert<int>();
            }
        }
        /// <summary>
        /// 3.6.2虚拟子账户批量开户请求集合
        /// </summary>
        [XmlElement("VSAOPENINFO", Order = 2)]
        public List<VSAOPENINFORQ> List { get; set; }
    }
    /// <summary>
    /// 3.6.2虚拟子账户批量开户请求明细
    /// </summary>
    public class VSAOPENINFORQ
    {
        /// <summary>
        /// 子账户，必须为6位数字且在010000-999989之间	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public string SUBACCT { get; set; }
        /// <summary>
        /// 子账户名称	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string SUBNAME { get; set; }
        /// <summary>
        /// 计息标志（目前核心系统仅允许0、1） 必输
        /// 0-不计息
        /// 1-不分段计息
        /// 2-按日分段计息
        /// </summary>
        [XmlElement(Order = 2)]
        public int CALINTSIDENT { get; set; }
        /// <summary>
        /// 利率代号（目前核心系统仅允许01000000）默认01000000 必输
        /// 01000000-人民币零利率
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
        [XmlElement(Order = 3)]
        public string RATECODE { get; set; } = "01000000";
        /// <summary>
        /// 利率比例浮动值（目前核心系统仅允许0.0）	必输
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal RATESCALEFLTVAL { get; set; }
        /// <summary>
        /// 利率点数浮动值	必输
        /// </summary>
        [XmlElement(Order = 5)]
        public decimal RATEPOINTFLTVAL { get; set; }
        /// <summary>
        /// 利率生效日期，YYYY-MM-DD  默认当前日期<see cref="DateTime.Now"/>	必输
        /// </summary>
        [XmlIgnore]
        public DateTime RATEWORKDATE { get; set; } = DateTime.Now;
        /// <summary>
        /// 利率生效日期，YYYY-MM-DD ,对应<see cref="RATEWORKDATE"/>	必输
        /// </summary>
        [XmlElement("RATEWORKDATE", Order = 6)]
        public string RATEWORKDATEStr
        {
            get
            {
                return this.RATEWORKDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (value.TryParse(out DateTime tmp))
                {
                    this.RATEWORKDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 结息标志(即计息周期)（目前核心系统仅允许3-利随本清）默认3 必输
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
        [XmlElement(Order = 7)]
        public string ADJINTSIDENT { get; set; } = "3";
        /// <summary>
        /// 结息周期 默认为 D00	必输
        /// 当结息标志为3、4只能为D00；
        /// 当结息标志为7时，只能为D01；
        /// 当结息标志为C时，只能为D07；
        /// 当结息标志为D时，只能为D10；
        /// 当结息标志为0、8时，只能为M01；
        /// 当结息标志为1、9时，只能为M03；
        /// 当结息标志为E、A时，只能为M06；
        /// 当结息标志为2、B时，只能为Y01；
        /// 当结息标志为F时，允许手工录入数值。
        /// </summary>
        [XmlElement(Order = 8)]
        public string ADJINTSCYCLE { get; set; } = "D00";
        /// <summary>
        /// 初次结息日期，格式YYYY-MM-DD  默认为当前日期<see cref="DateTime.Now"/>	必输
        /// 当结息标志为0默认为起始日期后最近的一个月末21日，不能修改；
        /// 当结息标志为1默认为起始日期后最近的一个季度末21日，不能修改；
        /// 当结息标志为E默认为起始日期后最近的一个半年末21日，不能修改；
        /// 当结息标志为2默认为起始日期后最近的一个年末21日，不能修改；
        /// 当结息标志为4、7、8、9、A、B、C、D默认为起始日期，不能修改；
        /// 当结息标志为3默认为开户日期；
        /// 当结息标志为F默认为起始日期，可修改，但必须大于等于起始日期，小于到期日期。
        /// </summary>
        [XmlIgnore]
        public DateTime FIRADJINTSDATE { get; set; } = DateTime.Now;
        /// <summary>
        /// 初次结息日期，格式YYYY-MM-DD ,对应<see cref="FIRADJINTSDATE"/>	必输
        /// </summary>
        [XmlElement("FIRADJINTSDATE", Order = 9)]
        public string FIRADJINTSDATEStr
        {
            get
            {
                return this.FIRADJINTSDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (value.TryParse(out DateTime tmp))
                {
                    this.FIRADJINTSDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 预算标志,0-否 1-是	必输
        /// </summary>
        [XmlElement(Order = 10)]
        public int BUDGETIDENT { get; set; }
        /// <summary>
        /// 预算额度，不可填负数	必输
        /// </summary>
        [XmlElement(Order = 11)]
        public decimal BUDGETQUOTA { get; set; }
        /// <summary>
        /// 额度循环标志：0-不循环，1-日，3-月，4-季，5-半年，6-年	必输
        /// </summary>
        [XmlElement(Order = 12)]
        public int BUDGETCYCLE { get; set; }
        /// <summary>
        /// 透支额度，不可填负数，大于0表示可透支 必输
        /// </summary>
        [XmlElement(Order = 13)]
        public decimal OVERQUOTA { get; set; }
    }
}
