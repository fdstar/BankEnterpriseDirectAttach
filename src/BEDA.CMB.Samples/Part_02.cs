using BEDA.CMB.Contracts.Requests;
using BEDA.CMB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BEDA.CMB.Samples
{
    partial class Program
    {
        static void Part_02()
        {
            //RQ2_1Sample();
            //RQ2_2Sample();
            //RQ2_3Sample();
            //RQ2_4Sample();
            //RQ2_5Sample();
            //RQ2_6Sample();
            //RQ2_7Sample();
            //RQ2_8Sample();
            //RQ2_9Sample();
        }

        #region 2.账户管理
        /// <summary>
        /// 2.1.查询可查询/可经办的账户列表
        /// </summary>
        public static void RQ2_1Sample()
        {
            var rq = new RQ2_1()
            {
                SDKACLSTX = new SDKACLSTX
                {
                    BUSCOD = "N02030",
                    BUSMOD = "00001"
                }
            };
            var rs = client.Execute<RQ2_1, RS2_1>(rq, "银企直连专用集团1");
            var txt = string.Join("\r", rs.List.Select(x => x.BBKNBR + "," + x.ACCNBR));
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 2.2.查询账户详细信息
        /// </summary>
        public static void RQ2_2Sample()
        {
            var rq = new RQ2_2()
            {
                List = new List<SDKACINFX>
                {
                   new SDKACINFX{
                        BBKNBR="59",
                        ACCNBR="591902896732601",
                   },
                   new SDKACINFX{
                       BBKNBR="59",
                       ACCNBR ="591902896810104"
                   }
                }
            };
            var rs = client.Execute<RQ2_2, RS2_2>(rq, "银企直连专用集团1");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 2.3.查询账户交易信息
        /// </summary>
        public static void RQ2_3Sample()
        {
            var rq = new RQ2_3()
            {
                SDKTSINFX = new SDKTSINFX
                {
                    BBKNBR = "59",
                    ACCNBR = "591902896710201",
                    BGNDAT = DateTime.Now.AddYears(-1).AddDays(-10),
                    ENDDAT = DateTime.Now.AddYears(-1).AddDays(-1),
                }
            };
            var rs = client.Execute<RQ2_3, RS2_3>(rq, "银企直连专用集团1");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 2.4.账户交易信息断点查询
        /// </summary>
        public static void RQ2_4Sample()
        {
            var rq = new RQ2_4()
            {
                SDKRBPTRSX = new SDKRBPTRSX
                {
                    BBKNBR = "59",
                    ACCNBR = "591902896710201",
                    TRSDAT = DateTime.Now.AddDays(-370),
                }
            };
            var rs = client.Execute<RQ2_4, RS2_4>(rq, "银企直连专用集团1");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 2.5.查询账户历史余额
        /// </summary>
        public static void RQ2_5Sample()
        {
            var rq = new RQ2_5()
            {
                NTQABINFY = new NTQABINFY
                {
                    BBKNBR = "59",
                    ACCNBR = "591902896710201",
                    BGNDAT = DateTime.Now.AddYears(-1).AddDays(-30),
                    ENDDAT = DateTime.Now.AddYears(-1).AddDays(-5)
                }
            };
            var rs = client.Execute<RQ2_5, RS2_5>(rq, "银企直连专用集团1");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 2.6.查询分行号信息
        /// </summary>
        public static void RQ2_6Sample()
        {
            var rq = new RQ2_6()
            {
                NTACCBBKY = new NTACCBBKY
                {
                    ACCNBR = ""
                }
            };
            var rs = client.Execute<RQ2_6, RS2_6>(rq, "银企直连专用集团1");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 2.7.查询电子回单信息
        /// </summary>
        public static void RQ2_7Sample()
        {
            var rq = new RQ2_7()
            {
                CSRRCFDFY0 = new CSRRCFDFY0
                {
                    EACNBR = "591902896710201",
                    BEGDAT = DateTime.Now.AddDays(-370),
                    ENDDAT = DateTime.Now.AddDays(-369),
                    RRCFLG = 1,
                }
            };
            var rs = client.Execute<RQ2_7, RS2_7>(rq, "银企直连专用集团1");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 2.8.查询电子回单信息（保存图片）
        /// </summary>
        public static void RQ2_8Sample()
        {
            var rq = new RQ2_8()
            {
                CSRRCFDFY0 = new CSRRCFDFY0
                {
                    EACNBR = "591902896710201",
                    BEGDAT = DateTime.Now.AddDays(-370),
                    ENDDAT = DateTime.Now.AddDays(-369),
                    RRCFLG = 1,
                }
            };
            var rs = client.Execute<RQ2_8, RS2_8>(rq, "银企直连专用集团1");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 2.9.批量查询余额
        /// </summary>
        public static void RQ2_9Sample()
        {
            var rq = new RQ2_9()
            {
                List = new List<NTQADINFX>
                {
                   new NTQADINFX{
                        BBKNBR="59",
                        ACCNBR="591902896732601",
                   },
                   new NTQADINFX{
                       BBKNBR="59",
                       ACCNBR ="591902896810104"
                   }
                }
            };
            var rs = client.Execute<RQ2_9, RS2_9>(rq, "银企直连专用集团1");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        #endregion
    }
}
