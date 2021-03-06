﻿using System;
using AntData.ORM.DbEngine.Providers;
using AntData.ORM.Enums;

namespace AntData.ORM.DbEngine.DB
{
    public class DatabaseWrapper
    {
        /// <summary>
        /// 物理数据库名称
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// 数据库主从类型
        /// </summary>
        public DatabaseType DatabaseType { get; set; }


        /// <summary>
        /// 连接字符串
        /// </summary>
        public String ConnectionString { get; set; }

        /// <summary>
        /// Driver Provider类型
        /// </summary>
        public IDatabaseProvider DatabaseProvider { get; set; }

        /// <summary>
        /// 数据库
        /// </summary>
        public Database Database { get; set; }

    }
}
