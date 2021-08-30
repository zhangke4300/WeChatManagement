using EasyAbp.WeChatManagement.MiniPrograms.Localization;
using Volo.Abp.Localization;
using Volo.Abp.Settings;

namespace EasyAbp.WeChatManagement.MiniPrograms.Settings
{
    public class MiniProgramsSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            /* Define module settings here.
             * Use names from MiniProgramsSettings class.
             */

            context.Add(new SettingDefinition(
                MiniProgramsSettings.PcLogin.DefaultProgramName,
                "Default",
                L("DisplayName:EasyAbp.WeChatManagement.MiniPrograms.DefaultMiniProgramName"),
                L("Description:EasyAbp.WeChatManagement.MiniPrograms.DefaultMiniProgramName"),
                isVisibleToClients: false)
                .WithProperty("Group1", "WeChat")
            );

            context.Add(new SettingDefinition(
                MiniProgramsSettings.PcLogin.HandlePage,
                null,
                L("DisplayName:EasyAbp.WeChatManagement.MiniPrograms.HandlePage"),
                L("Description:EasyAbp.WeChatManagement.MiniPrograms.HandlePage"),
                isVisibleToClients: false)
                .WithProperty("Group1", "WeChat")
            );

            context.Add(new SettingDefinition(
                MiniProgramsSettings.AllowCreateUserWhenLogin,
                "False",
                L("DisplayName:EasyAbp.WeChatManagement.MiniPrograms.AllowCreateUserWhenLogin"),
                L("Description:EasyAbp.WeChatManagement.MiniPrograms.AllowCreateUserWhenLogin"),
                isVisibleToClients: false)
                .WithProperty("Type", "select")
                .WithProperty("Options", "True|False")
                .WithProperty("Group1", "WeChat")
            );
        }
        
        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<MiniProgramsResource>(name);
        }
    }
}