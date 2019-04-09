using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Responses
{
    /// <summary>
    /// 17.15.查询虚拟户关联公司卡列表响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS17_15 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTDCDRLT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDCDRLT";
        /// <summary>
        /// 17.15.查询虚拟户关联公司卡列表响应集合
        /// </summary>
        [XmlElement("NTDCDRLTZ1")]
        public List<NTDCDRLTZ1> List { get; set; }
    }
    /// <summary>
    /// 17.15.查询虚拟户关联公司卡列表响应内容
    /// </summary>
    public class NTDCDRLTZ1
    {
        /// <summary>
        /// 虚拟户编号	C(20)
        /// </summary>
        public string DMANBR { get; set; }
        /// <summary>
        /// 公司卡号   	C(35)
        /// </summary>
        public string CDSNBR { get; set; }
        /// <summary>
        /// 凭证种类   	C(4)
        /// </summary>
        public string PSBCOD { get; set; }
        /// <summary>
        /// 公司卡户口名	Z(62)
        /// </summary>
        public string CDSNAM { get; set; }
        /// <summary>
        /// 持卡人姓名 	Z(200)
        /// </summary>
        public string CLTNAM { get; set; }
        /// <summary>
        /// 备注名称   	Z(62)
        /// </summary>
        public string TXTNAM { get; set; }
        /// <summary>
        /// 开户日期   	D
        /// </summary>
        [XmlIgnore]
        public DateTime OPNDAT { get; set; }
        /// <summary>
        /// 开户日期   	D, 对应<see cref="OPNDAT"/>
        /// </summary>
        [XmlElement("OPNDAT")]
        public string OPNDATStr
        {
            get
            {
                return this.OPNDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OPNDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 开户城市   	C(6)
        /// </summary>
        public string CTYCOD { get; set; }
        /// <summary>
        /// 开户机构   	C(6)
        /// </summary>
        public string BRNNBR { get; set; }
        /// <summary>
        /// 管理机构   	C(6)
        /// </summary>
        public string MGMBRN { get; set; }
        /// <summary>
        /// 激活标志     	C(1)
        /// </summary>
        public string ACTFLG { get; set; }
        /// <summary>
        /// 新旧户口标志 	C(1)
        /// </summary>
        public string DGRFLG { get; set; }
        /// <summary>
        /// 公司卡户口状态	C(1)
        /// </summary>
        public string STSCOD { get; set; }
        /// <summary>
        /// 公司卡关联付方账号校验标志	C(1)	N：无关联（公司卡进账交易不校验付方账号） Y：有关联（公司卡进账交易要校验付方账号）
        /// </summary>
        public string PDCFLG { get; set; }
        /// <summary>
        /// 入账方式	C(1)    空：公司卡无关联付方账号 N：公司卡进账交易非匹配付方账号入默认虚拟户 Y：公司卡进账交易非匹配付方账号入关联虚拟户
        /// </summary>
        public string TLYOPR { get; set; }
    }
}
