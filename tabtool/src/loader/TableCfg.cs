﻿using System;

namespace Saro.Table
{
    public sealed class TableCfg
    {
        /// <summary>
        /// 数据表加载路径
        /// </summary>
        public static string s_TableSrc;

        /// <summary>
        /// 数据表加载委托
        /// </summary>
        public static Func<string, byte[]> s_BytesLoader;
    }
}
