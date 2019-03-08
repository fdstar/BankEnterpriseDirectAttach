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
    /// 3.8.5理产产品客户理财资产信息查询响应主体
    /// </summary>
    public class V1_FPASSETSTRNRS : IResponse
    {
        /// <summary>
        /// 3.8.5理产产品客户理财资产信息查询响应主体
        /// </summary>
        public FPASSETSTRNRS FPASSETSTRNRS { get; set; }
    }
    /// <summary>
    /// 3.8.5理产产品客户理财资产信息查询响应主体
    /// </summary>
    public class FPASSETSTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.8.5理产产品客户理财资产信息查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public FPASSETSTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.8.5理产产品客户理财资产信息查询响应内容
    /// </summary>
    public class FPASSETSTRN_RSBODY
    {
        /// <summary>
        /// MORE是否有下一页，Y有，N无
        /// </summary>
        [XmlAttribute]
        public string MORE { get; set; }
        /// <summary>
        /// 产品余额 对应产品余额响应
        /// </summary>
        [XmlElement("BLNC", Order = 0)]
        public List<BLNC> BLNCList { get; set; }
        /// <summary>
        /// 交易明细 对应产品余额响应
        /// </summary>
        [XmlElement("STMT", Order = 1)]
        public List<STMT> STMTList { get; set; }
        /// <summary>
        /// 可撤单交易 对应产品可撤单交易
        /// </summary>
        [XmlElement("CANCANCL", Order = 2)]
        public List<CANCANCL> CANCANCLList { get; set; }
    }
    /// <summary>
    /// 3.8.3理财产品信息查询响应 产品余额
    /// </summary>
    public class BLNC
    {
        /// <summary>
        /// 产品代码，8位
        /// </summary>
        [XmlElement(Order = 0)]
        public string PRODNO { get; set; }
        /// <summary>
        /// 产品简称，最长50位
        /// </summary>
        [XmlElement(Order = 1)]
        public string SHORTNAME { get; set; }
        /// <summary>
        /// 产品份额，decimal(15,2)，即整数位最长13位，小数位2位
        /// </summary>
        [XmlElement(Order = 2)]
        public decimal PRODSHARE { get; set; }
        /// <summary>
        /// 可用份额，decimal(15,2)，即整数位最长13位，小数位2位
        /// </summary>
        [XmlElement(Order = 3)]
        public decimal AVAILBAL { get; set; }
        /// <summary>
        /// 钞汇标识0 钞1 汇
        /// </summary>
        [XmlElement(Order = 4)]
        public int CASHFLAG { get; set; }
    }
    /// <summary>
    /// 3.8.3理财产品信息查询响应 交易明细
    /// </summary>
    public class STMT
    {
        /// <summary>
        /// 交易日期	必回
        /// </summary>
        [XmlIgnore]
        public DateTime DTTRN { get; set; }
        /// <summary>
        /// 交易日期 ,对应<see cref="DTTRN"/> 
        /// </summary>
        [XmlElement("DTTRN", Order = 0)]
        public string DTTRNStr
        {
            get
            {
                return this.DTTRN.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DTTRN = tmp;
                }
            }
        }
        /// <summary>
        /// 交易代码	必回
        /// </summary>
        [XmlElement(Order = 1)]
        public string TRNCODE { get; set; }
        /// <summary>
        /// 业务受理编号	必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string ACCEPTNO { get; set; }
        /// <summary>
        /// 交易处理状态 必回
        /// 1 未上送                        
        /// 2 已上送                        
        /// 3 已撤销                        
        /// 4 确认成功                      
        /// 5 确认部分成功                  
        /// 6 确认失败                       
        /// 7 核对错误
        /// A 赎回未完成
        /// B 未确认处理(仅用于BTA确认数据)
        /// C 募集失败
        /// D 募集成功
        /// </summary>
        [XmlElement(Order = 3)]
        public string TRNSTATUS { get; set; }
        /// <summary>
        /// 产品代码，8位	必回
        /// </summary>
        [XmlElement(Order = 4)]
        public string PRODNO { get; set; }
        /// <summary>
        /// 产品简称	必回
        /// </summary>
        [XmlElement(Order = 5)]
        public string SHORTNAME { get; set; }
        /// <summary>
        /// 申请金额，decimal(15,2)，即整数位最长13位，小数位2位	必回
        /// </summary>
        [XmlElement(Order = 6)]
        public decimal APPLYAMT { get; set; }
        /// <summary>
        /// 申请份额，decimal(15,2)，即整数位最长13位，小数位2位	必回
        /// </summary>
        [XmlElement(Order = 7)]
        public decimal SHAREAPPLY { get; set; }
        /// <summary>
        /// 钞汇标识 0 钞1 汇	必回
        /// </summary>
        [XmlElement(Order = 8)]
        public int CASHFLAG { get; set; }
        /// <summary>
        /// 成交金额，decimal(15,2)，即整数位最长13位，小数位2位	必回
        /// </summary>
        [XmlElement(Order = 9)]
        public decimal DEALAMT { get; set; }
        /// <summary>
        /// 成交份额，decimal(15,2)，即整数位最长13位，小数位2位	必回
        /// </summary>
        [XmlElement(Order = 10)]
        public decimal DEALSHARES { get; set; }
    }
    /// <summary>
    /// 3.8.3理财产品信息查询响应 可撤单交易
    /// </summary>
    public class CANCANCL
    {
        /// <summary>
        /// 交易自然日期YYYY-MM-DD	必回
        /// </summary>
        [XmlIgnore]
        public DateTime DTTRNMACHINE { get; set; }
        /// <summary>
        /// 交易自然日期YYYY-MM-DD ,对应<see cref="DTTRNMACHINE"/> 必回
        /// </summary>
        [XmlElement("DTTRNMACHINE", Order = 0)]
        public string DTTRNMACHINEStr
        {
            get
            {
                return this.DTTRNMACHINE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DTTRNMACHINE = tmp;
                }
            }
        }
        /// <summary>
        /// 交易系统日期YYYY-MM-DD	必回
        /// </summary>
        [XmlIgnore]
        public DateTime DTTRNSYSTEM { get; set; }
        /// <summary>
        /// 交易系统日期YYYY-MM-DD ,对应<see cref="DTTRNSYSTEM"/> 必回
        /// </summary>
        [XmlElement("DTTRNSYSTEM", Order = 1)]
        public string DTTRNSYSTEMStr
        {
            get
            {
                return this.DTTRNSYSTEM.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DTTRNSYSTEM = tmp;
                }
            }
        }
        /// <summary>
        /// 内部交易代码，4位	必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string INNERTRNCODE { get; set; }
        /// <summary>
        /// 业务受理编号，最长16位	必回
        /// </summary>
        [XmlElement(Order = 3)]
        public string ACCEPTNO { get; set; }
        /// <summary>
        /// 交易处理状态 必回
        /// 1 未上送                        
        /// 2 已上送                        
        /// 3 已撤销                        
        /// 4 确认成功                      
        /// 5 确认部分成功                  
        /// 6 确认失败                       
        /// 7 核对错误
        /// A 赎回未完成
        /// B 未确认处理(仅用于BTA确认数据)
        /// C 募集失败
        /// D 募集成功
        /// </summary>
        [XmlElement(Order = 4)]
        public string TRNSTATUS { get; set; }
        /// <summary>
        /// 申请金额，decimal(15,2)，即整数位最长13位，小数位2位	必回
        /// </summary>
        [XmlElement(Order = 5)]
        public decimal APPLYAMT { get; set; }
        /// <summary>
        /// 申请份额，decimal(15,2)，即整数位最长13位，小数位2位	必回
        /// </summary>
        [XmlElement(Order = 6)]
        public decimal SHAREAPPLY { get; set; }
        /// <summary>
        /// 钞汇标识 0 钞1 汇	必回
        /// </summary>
        [XmlElement(Order = 7)]
        public int CASHFLAG { get; set; }
    }
}
