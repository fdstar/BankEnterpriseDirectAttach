using BEDA.CIB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 3.9.3.16电子商业汇票质押托管转换登记簿请求主体
    /// </summary>
    public class V1_EBPCONVERTREGISTERTRNRQ : IRequest<V1_EBPCONVERTREGISTERTRNRS>
    {
        /// <summary>
        /// 3.9.3.16电子商业汇票质押托管转换登记簿请求主体
        /// </summary>
        public EBPCONVERTREGISTERTRNRQ EBPCONVERTREGISTERTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.9.3.16电子商业汇票质押托管转换登记簿请求主体
    /// </summary>
    public class EBPCONVERTREGISTERTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.9.3.16电子商业汇票质押托管转换登记簿请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBPCONVERTREGISTERTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.9.3.16电子商业汇票质押托管转换登记簿请求内容
    /// </summary>
    public class EBPCONVERTREGISTERTRN_RQBODY
    {
        /// <summary>
        /// 查询页数默认为1
        /// </summary>
        [XmlAttribute]
        public int PAGE { get; set; } = 1;
        /// <summary>
        /// 起始日期 YYYY-MM-DD 必输
        /// </summary>
        [XmlIgnore]
        public DateTime BEGINDATE { get; set; }
        /// <summary>
        /// 起始日期，格式yyyy-MM-dd ,对应<see cref="BEGINDATE"/> 必输
        /// </summary>
        [XmlElement("BEGINDATE", Order = 1)]
        public string BEGINDATEStr
        {
            get
            {
                return this.BEGINDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.BEGINDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 终止日期 YYYY-MM-DD 必输
        /// </summary>
        [XmlIgnore]
        public DateTime DUEDATE { get; set; }
        /// <summary>
        /// 终止日期，格式yyyy-MM-dd ,对应<see cref="DUEDATE"/> 必输
        /// </summary>
        [XmlElement("DUEDATE", Order = 2)]
        public string DUEDATEStr
        {
            get
            {
                return this.DUEDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DUEDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 票据介质，1-纸票  2-电票	非必输
        /// </summary>
        [XmlElement(Order = 3)]
        public string BILLMEDIUM { get; set; }
        /// <summary>
        /// 票据类型, AC01-银承  AC02-商承	非必输
        /// </summary>
        [XmlElement(Order = 4)]
        public string BILLTYPE { get; set; }
        /// <summary>
        /// 业务类型，01-质押转托管  02-托管转质押	非必输
        /// </summary>
        [XmlElement(Order = 5)]
        public string BIZTYPE { get; set; }
        /// <summary>
        /// 票据号码，16位	非必输
        /// </summary>
        [XmlElement(Order = 6)]
        public string BILLCODE { get; set; }
    }
}
