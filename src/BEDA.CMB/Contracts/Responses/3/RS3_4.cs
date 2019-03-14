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
    /// 3.4.查询收方限制列表响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS3_4 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTQRYRVL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQRYRVL";
        /// <summary>
        /// 3.4.查询收方限制列表响应内容    操作人信息
        /// </summary>
        public NTQRYRVLZ NTQRYRVLZ { get; set; }
        /// <summary>
        /// 3.4.查询收方限制列表响应内容    未知内容
        /// </summary>
        public CLTDALCOD CLTDALCOD { get; set; }
        /// <summary>
        /// 3.4.查询收方限制列表响应集合  明细信息
        /// </summary>
        [XmlElement("NTRVLINFY")]
        public List<NTRVLINFY> List { get; set; }
    }
    /// <summary>
    /// 3.4.查询收方限制列表响应内容    未知内容
    /// </summary>
    public class CLTDALCOD
    {
        /// <summary>
        /// 未知 N为可能值之一 估计是用于推断响应是否有值
        /// </summary>
        public string DALCOD { get; set; }
    }
    /// <summary>
    /// 3.4.查询收方限制列表响应内容    操作人信息
    /// </summary>
    public class NTQRYRVLZ
    {
        /// <summary>
        /// 经办用户名	Z(30)
        /// </summary>
        public string OPRLGN { get; set; }
        /// <summary>
        /// 经办日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? OPRDAT { get; set; }
        /// <summary>
        /// 经办日期	D, 对应<see cref="OPRDAT"/>
        /// </summary>
        [XmlElement("OPRDAT")]
        public string OPRDATStr
        {
            get
            {
                return this.OPRDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.OPRDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OPRDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 校验和	C（10）
        /// </summary>
        public string CHKSUM { get; set; }
    }
    /// <summary>
    /// 3.4.查询收方限制列表响应内容    明细信息
    /// </summary>
    public class NTRVLINFY
    {
        /// <summary>
        /// 收方编号	C（20）	
        /// </summary>
        public string CRTSQN { get; set; }
        /// <summary>
        /// 收方分行号	C(2)
        /// </summary>
        public string CRTBBK { get; set; }
        /// <summary>
        /// 收方帐号	C（35）
        /// </summary>
        public string CRTACC { get; set; }
        /// <summary>
        /// 收方帐户名	Z（62）
        /// </summary>
        public string CRTNAM { get; set; }
        /// <summary>
        /// 收方开户行	Z（62）
        /// </summary>
        public string CRTBNK { get; set; }
        /// <summary>
        /// 收方省份	Z（18）
        /// </summary>
        public string CRTPVC { get; set; }
        /// <summary>
        /// 收方城市	Z（22）
        /// </summary>
        public string CRTCTY { get; set; }
        /// <summary>
        /// 收方县/区	Z（22）
        /// </summary>
        public string CRTDTR { get; set; }
        /// <summary>
        /// 收方电子邮件	C（40）
        /// </summary>
        public string NTFCH1 { get; set; }
        /// <summary>
        /// 收方移动电话	C（20）
        /// </summary>
        public string NTFCH2 { get; set; }
        /// <summary>
        /// 提出方式	C(1)
        /// </summary>
        public string STLCHN { get; set; }
        /// <summary>
        /// 提出代码	C(10)
        /// </summary>
        public string STLNBR { get; set; }
        /// <summary>
        /// 额度	M
        /// </summary>
        public decimal LMTAMT { get; set; }
        /// <summary>
        /// 操作类型	C(1)
        /// </summary>
        public string OPRTYP { get; set; }
        /// <summary>
        /// 保留字段	C(30)
        /// </summary>
        public string RSV30Z { get; set; }
    }
}
