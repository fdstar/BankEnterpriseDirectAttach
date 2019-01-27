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
    /// 集团服务归集调拨查询请求主体
    /// </summary>
    public class V1_CMTRANSDETAILTRNRQ : IRequest<V1_CMTRANSDETAILTRNRS>
    {
        /// <summary>
        /// 集团服务归集调拨查询请求主体
        /// </summary>
        public CMTRANSDETAILTRNRQ CMTRANSDETAILTRNRQ { get; set; }
    }
    /// <summary>
    /// 集团服务归集调拨查询请求主体
    /// </summary>
    public class CMTRANSDETAILTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 集团服务归集调拨查询请求内容，必输
        /// </summary>
        [XmlElement(Order = 1)]
        public CMTRANSDETAILTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 集团服务归集调拨查询请求内容
    /// </summary>
    public class CMTRANSDETAILTRN_RQBODY
    {
        /// <summary>
        /// PAGE查询页码，每页100笔，不输默认第1页，必输
        /// </summary>
        [XmlAttribute]
        public int PAGE { get; set; } = 1;
        /// <summary>
        /// 结算中心账户信息，非必输
        /// </summary>
        [XmlElement(Order = 0)]
        public RQACCT FUNDACCT { get; set; }
        /// <summary>
        /// 查询账户代号，最长32位	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string ACCTID { get; set; }
        /// <summary>
        /// CM\MEM\ALL三种选项  必输  默认查询ALL
        /// 如果查询账号作为结算中心，则输入CM；
        /// 如果查询账号是成员单位，则输入MEM；
        /// 查询账户如果是三级结算中心中的二级结算中心账户，此处可根据查询需要输入—CM（结算中心账户字段不输入，查询二级账号作为结算中心与下属三级的明细）、MEM（结算中心账户字段输入总中心账号，查询总结算中心与二级结算中心之间的明细）、ALL（结算中心账户字段不输，查询二级账号与总结算中心以及下属账号之间的所有明细数据）
        /// </summary>
        [XmlElement(Order = 2)]
        public string SCOPE { get; set; } = "ALL";
        /// <summary>
        /// 开始日期YYYY-MM-DD	必输
        /// </summary>
        [XmlIgnore]
        public DateTime DTSTART { get; set; }
        /// <summary>
        /// 开始日期YYYY-MM-DD ,对应<see cref="DTSTART"/>	必输
        /// </summary>
        [XmlElement("DTSTART", Order = 3)]
        public string DTSTARTStr
        {
            get
            {
                return this.DTSTART.ToString("yyyy-MM-dd");
            }
            set
            {
                if (value.TryParse(out DateTime tmp))
                {
                    this.DTSTART = tmp;
                }
            }
        }
        /// <summary>
        /// 结束日期YYYY-MM-DD	必输
        /// </summary>
        [XmlIgnore]
        public DateTime DTEND { get; set; }
        /// <summary>
        /// 结束日期YYYY-MM-DD ,对应<see cref="DTEND"/>	必输
        /// </summary>
        [XmlElement("DTEND", Order = 4)]
        public string DTENDStr
        {
            get
            {
                return this.DTEND.ToString("yyyy-MM-dd");
            }
            set
            {
                if (value.TryParse(out DateTime tmp))
                {
                    this.DTEND = tmp;
                }
            }
        }
    }
}
