using BEDA.CIB.Contracts.Responses;
using BEDA.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 工资发放服务请求主体
    /// </summary>
    public class V1_RPAYOFFTRNRQ : IRequest<V1_RPAYOFFTRNRS>
    {
        /// <summary>
        /// 工资发放服务请求，实时代发（建议200笔以下）工资指令，最多支持300笔
        /// </summary>
        public RPAYOFFTRNRQ RPAYOFFTRNRQ { get; set; }
    }
    /// <summary>
    /// 工资发放服务请求，实时代发（建议200笔以下）工资指令，最多支持300笔
    /// </summary>
    public class RPAYOFFTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 在响应报文中包含该内容 	非必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string CLTCOOKIE { get; set; }
        /// <summary>
        /// 生成工资指令请求 若该项为空，则查询对应客户流水号的实时工资指令状态 必输
        /// </summary>
        [XmlElement(Order = 2)]
        public RPAYOFFRQ RPAYOFFRQ { get; set; }
    }
    /// <summary>
    /// 生成工资指令请求
    /// </summary>
    public class RPAYOFFRQ
    {
        /// <summary>
        /// 工资发放指令
        /// </summary>
        [XmlElement("RPAYOFFINFO")]
        public RPAYOFFINFO<RPAYOFF> RPAYOFFINFO { get; set; }
    }
    /// <summary>
    /// 工资发放指令
    /// </summary>
    public class RPAYOFFINFO<T>
        where T : RPAYOFF
    {
        /// <summary>
        /// 付款人账户信息 必输
        /// </summary>
        [XmlElement(Order = 0)]
        public ACCTFROM ACCTFROM { get; set; }
        /// <summary>
        /// 工资指令标题，长度：30	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string TITLE { get; set; }
        /// <summary>
        /// 工资用途:006-工资，022-奖金，047-福利，008-水费，007-电费，
        /// 813-高温费，080-报刊费，048-费用报销，605保险理赔， 747住房公积金，
        /// 长度3，仅传递标识码，如006	必输
        /// </summary>
        [XmlElement(Order = 2)]
        public string DESCRIPTION { get; set; }
        /// <summary>
        /// 总笔数	非必输
        /// </summary>
        [XmlIgnore]
        public int? TOTALCOUNT { get; set; }
        /// <summary>
        /// 总笔数，整数  对应<see cref="TOTALCOUNT"/>	非必输
        /// </summary>
        [XmlElement("TOTALCOUNT", Order = 3)]
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
        /// 总金额	非必输
        /// </summary>
        [XmlIgnore]
        public decimal? TOTALAMOUNT { get; set; }
        /// <summary>
        /// 总金额，整数  对应<see cref="TOTALAMOUNT"/>	非必输
        /// </summary>
        [XmlElement("TOTALAMOUNT", Order = 4)]
        public string TOTALAMOUNTStr
        {
            get
            {
                return this.TOTALAMOUNT?.ToString();
            }
            set
            {
                this.TOTALAMOUNT = value.TryConvert<decimal>();
            }
        }
        /// <summary>
        /// 凭证号，最大长度7位
        /// 目前工资发放指令可自动生成凭证 非必输
        /// </summary>
        [XmlElement(Order = 5)]
        public string CHEQUENUM { get; set; }
        /// <summary>
        /// 货币符号,RMB,目前仅支持RMB	非必输
        /// </summary>
        [XmlElement(Order = 6)]
        public string CURSYM { get; set; }
        /// <summary>
        /// 客户端要求的指令执行日期，如果客户端未发送DTDUE，则服务器将尽可能早执行转账。格式：YYYY-MM-DD
        /// 允许填写当日至当日加29天，不允许填写当日之前的日期。	非必输
        /// </summary>
        [XmlIgnore]
        public DateTime? DTDUE { get; set; }
        /// <summary>
        /// 客户端期望的转账执行日期，格式：YYYY-MM-DD, 对应<see cref="DTDUE"/>	非必输 
        /// 允许填写当日至当日加29天，不允许填写当日之前的日期
        /// </summary>
        [XmlElement("DTDUE", Order = 7)]
        public string DTDUEStr
        {
            get
            {
                return this.DTDUE?.ToString("yyyy-MM-dd");
            }
            set
            {
                this.DTDUE = value.TryConvert<DateTime>();
            }
        }
        /// <summary>
        /// 工资指令备注，长度50	非必输
        /// </summary>
        [XmlElement(Order = 8)]
        public string REMARK { get; set; }
        /// <summary>
        /// 工资发放列表	必输
        /// </summary>
        [XmlElement("RPAYOFFLIST", Order = 9)]
        public RPAYOFFLIST<T> RPAYOFFLIST { get; set; }
    }
    /// <summary>
    /// 工资发放列表
    /// </summary>
    public class RPAYOFFLIST<T>
        where T : RPAYOFF
    {
        /// <summary>
        /// 工资信息集合
        /// </summary>
        [XmlElement("RPAYOFF")]
        public List<T> List { get; set; }
    }
    /// <summary>
    /// 工资信息
    /// </summary>
    public class RPAYOFF
    {
        /// <summary>
        /// 排序号，最大长度 10位	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public int INDX { get; set; }
        /// <summary>
        /// 员工姓名，最大长度 20位	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string ACCTNAME { get; set; }
        /// <summary>
        /// 员工卡号，最大长度 18位	必输
        /// </summary>
        [XmlElement(Order = 2)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 实发工资，最大长度 17位含2位小数	必输
        /// </summary>
        [XmlElement(Order = 3)]
        public decimal TRNAMT { get; set; }
    }
}
