﻿namespace EasyAbp.WeChatManagement.MiniPrograms
{
    public static class MiniProgramsDbProperties
    {
        public static string DbTablePrefix { get; set; } = "WeChat";

        public static string DbSchema { get; set; } = null;

        public const string ConnectionStringName = "WeChatMini";
    }
}
