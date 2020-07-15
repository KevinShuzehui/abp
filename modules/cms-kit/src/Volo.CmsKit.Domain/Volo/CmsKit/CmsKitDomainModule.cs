﻿using Volo.Abp.Modularity;
using Volo.CmsKit.Reactions;

namespace Volo.CmsKit
{
    [DependsOn(
        typeof(CmsKitDomainSharedModule)
    )]
    public class CmsKitDomainModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<CmsKitOptions>(options =>
            {
                options.Reactions.AddOrReplace(StandardReactions.Smile);
                options.Reactions.AddOrReplace(StandardReactions.ThumbsUp);
            });
        }
    }
}
