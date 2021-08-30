﻿namespace EasyAbp.WeChatManagement.Common
{
    public static class CommonDbProperties
    {
        public static string DbTablePrefix { get; set; } = "";

        public static string DbSchema { get; set; } = null;

        public const string ConnectionStringName = "WeChatCom";
    }
}
