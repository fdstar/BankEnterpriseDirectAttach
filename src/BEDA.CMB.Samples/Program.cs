using BEDA.CMB.Contracts.Requests;
using BEDA.CMB.Contracts.Responses;
using System;
using System.Text;

namespace BEDA.CMB.Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1.系统管理
            //RQ1_4Sample();
            //RQ1_5Sample();
            //RQ1_6Sample();
            //RQ1_8Sample();
            //RQ1_9Sample();
            #endregion

            Console.ReadLine();
        }

        #region 基础部分
        const string loginName = "银企直连专用集团1";
        const string ip = "127.0.0.1";
        const int port = 8082;
        static ICMBClient client = new CMBClient(ip, port);
        #endregion

        #region 1.系统管理
        /// <summary>
        /// 1.4.取新的通知
        /// </summary>
        public static void RQ1_4Sample()
        {
            var rq = new RQ1_4();
            var rs = client.Execute<RQ1_4, RS1_4>(rq, loginName);
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 1.5.取系统信息
        /// </summary>
        public static void RQ1_5Sample()
        {
            var rq = new RQ1_5()
            {
                SDKSYINFX = new SDKSYINFX()
            };
            var rs = client.Execute<RQ1_5, RS1_5>(rq, loginName);
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 1.6.查询可经办业务模式
        /// </summary>
        public static void RQ1_6Sample()
        {
            var rq = new RQ1_6()
            {
                SDKMDLSTX = new SDKMDLSTX
                {
                     BUSCOD= "N03010"
                }
            };
            var rs = client.Execute<RQ1_6, RS1_6>(rq, loginName);
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 1.8.查询历史通知
        /// </summary>
        public static void RQ1_8Sample()
        {
            var rq = new RQ1_8()
            {
                FBDLRHMGX = new FBDLRHMGX
                {
                    BGNDAT = DateTime.Now.AddDays(-7),
                    ENDDAT = DateTime.Now,
                    //MSGTYP = "NCBUSFIN"
                    //NCBCHOPR 
                    //NCDRTPAY  
                    //NCCRTTRS
                    //NCDBTTRS
                    //NCBUSFIN
                }
            };
            var rs = client.Execute<RQ1_8, RS1_8>(rq, loginName);
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        public static void RQ1_9Sample()
        {
            var rq = new RQ1_9()
            {
                DCHISMSGX = new DCHISMSGX
                {
                    BGNDAT = DateTime.Now.AddDays(-7),
                    ENDDAT = DateTime.Now,
                    RECNUM = "100"
                    //MSGTYP = "NCBUSFIN"
                    //NCBCHOPR 
                    //NCDRTPAY  
                    //NCCRTTRS
                    //NCDBTTRS
                    //NCBUSFIN
                }
            };
            var rs = client.Execute<RQ1_9, RS1_9>(rq, loginName);
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        #endregion
    }
}
